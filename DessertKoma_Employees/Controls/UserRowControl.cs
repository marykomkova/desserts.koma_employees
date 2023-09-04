using DessertKoma_Employees.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Image = DessertsKoma_Employees.Classes.Image;
using Image2 = System.Drawing.Image;

namespace DessertKoma_Employees.Controls
{
    public partial class UserRowControl : UserControl
    {
        SqlDataAdapter usersAdapter;
        DataSet usersDataSet;
        UsersControl usersControl;
        bool imageChange;
        string id; 
        OpenFileDialog textDialogIMG;
        public static string fileName;
        public UserRowControl(string i, UsersControl cntrl)
        {
            InitializeComponent();
            usersControl = cntrl;
            textDialogIMG = new OpenFileDialog();
            textDialogIMG.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            id = i;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            loginLabel.Visible = false;
            loginTextBox.Text = loginLabel.Text;
            loginTextBox.Visible = true;
            nameLabel.Visible = false;
            nameTextBox.Text = nameLabel.Text;
            nameTextBox.Visible = true;
            phoneLabel.Visible = false;
            phoneTextBox.Text = phoneLabel.Text;
            phoneTextBox.Visible = true;
            roleLabel.Visible = false;
            roleComboBox.Visible = true;
            ролиTableAdapter.Fill(dessertsKomaDataSet.Роли);
            roleComboBox.SelectedItem = roleLabel.Text;
            roleComboBox.Text = roleLabel.Text;
            verificationCheckBox.Enabled = true;
            pic.Enabled = true;
            editButton.Visible = false;
            saveButton.Visible = true;
            closeButton.Visible = true;
            error_label.Visible = false;
            loginTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            nameTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void UserRowControl_Load(object sender, EventArgs e)
        {
            imageChange = false;
            using(SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                usersAdapter = new SqlDataAdapter($"SELECT p.Логин, p.Имя, r.Название as Роль,  r.Номер as РольНомер, p.Подтверждение as Подтверждение, " +
                    $"p.НомерТелефона as [Номер телефона], p.Изображение FROM Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Номер = {id}", connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet);
            }
            loginLabel.Text = usersDataSet.Tables[0].Rows[0]["Логин"].ToString();
            nameLabel.Text = usersDataSet.Tables[0].Rows[0]["Имя"].ToString();
            if (usersDataSet.Tables[0].Rows[0]["Номер телефона"].ToString() == "")
                phoneLabel.Text = "не задан";
            else
                phoneLabel.Text = usersDataSet.Tables[0].Rows[0]["Номер телефона"].ToString();
            roleLabel.Text = usersDataSet.Tables[0].Rows[0]["Роль"].ToString();
            var p = (bool)usersDataSet.Tables[0].Rows[0]["Подтверждение"];
            verificationCheckBox.Checked = p;
            if (p)
                verificationCheckBox.Text = "Подтвержден";
            else
                verificationCheckBox.Text = "Не подтвержден";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlDataAdapter imageAdapter;
                DataSet imageDataSet;
                if (usersDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                {
                    imageAdapter = new SqlDataAdapter($"SELECT i.Номер, i.ИмяФайла, i.Название, i.Данные FROM Пользователи p JOIN Изображения i ON p.Изображение = i.Номер WHERE p.Номер = {id}", connection);
                    imageDataSet = new DataSet();
                    imageAdapter.Fill(imageDataSet);

                    int id2 = Convert.ToInt32(imageDataSet.Tables[0].Rows[0]["Номер"]);
                    string filename = imageDataSet.Tables[0].Rows[0]["ИмяФайла"].ToString();
                    string title = imageDataSet.Tables[0].Rows[0]["Название"].ToString();
                    byte[] data = (byte[])imageDataSet.Tables[0].Rows[0]["Данные"];
                    Image image = new Image(id2, filename, title, data);
                    string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{image.FileName}");
                    if (!File.Exists(path))
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.OpenOrCreate))
                        {
                            fs.Write(image.Data, 0, image.Data.Length);
                        }
                    }

                    pic.Image = Image2.FromFile(path);
                }
            }
        }

        private void verificationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (verificationCheckBox.Checked)
                verificationCheckBox.Text = "Подтвержден";
            else
                verificationCheckBox.Text = "Не подтвержден";
        }

        private void pic_Click(object sender, EventArgs e)
        {
            if (textDialogIMG.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fileName = textDialogIMG.FileName; 
            Stream myStream;
            using (myStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                pic.Image = Image2.FromStream(myStream);
            }
            imageChange = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool login = false;
            bool name = false;
            bool phone = false;
            bool role = false;
            if (loginTextBox.Text != usersDataSet.Tables[0].Rows[0]["Логин"].ToString())
            {
                if (loginTextBox.Text == "")
                {
                    error_label.Text = "Вы не ввели логин!";
                    error_label.Visible = true;
                    loginTextBox.BorderColor = Color.Red;
                    return;
                }
                else
                {
                    string[] dataLogin = loginTextBox.Text.Split('@');
                    if (dataLogin.Length == 2)
                    {
                        string[] data2Login = dataLogin[1].Split('.');
                        if (data2Login.Length != 2)
                        {
                            error_label.Text = "!Укажите логин в форме х@x.x";
                            error_label.Visible = true;
                            loginTextBox.BorderColor = Color.Red;
                            return;
                        }
                    }
                    else
                    {
                        error_label.Text = "!Укажите логин в форме х@x.x";
                        error_label.Visible = true;
                        loginTextBox.BorderColor = Color.Red;
                        return;
                    }
                    for (int i = 0; i < loginTextBox.Text.Length; i++)
                    {
                        if (loginTextBox.Text[i] >= 'а' && loginTextBox.Text[i] <= 'я')
                        {
                            error_label.Text = "!Могут использоваться только английские буквы";
                            error_label.Visible = true;
                            loginTextBox.BorderColor = Color.Red;
                            return;
                        }
                    }

                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        string sqlExpression = $"SELECT * FROM Пользователи WHERE Логин='{loginTextBox.Text}'";
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                error_label.Text = "!Пользователь с таким логином уже существует";
                                error_label.Visible = true;
                                loginTextBox.BorderColor = Color.Red;
                                return;
                            }
                        }
                        reader.Close();
                    }

                    login = true;
                }
            }
            if (nameTextBox.Text != usersDataSet.Tables[0].Rows[0]["Имя"].ToString())
            {
                if (nameTextBox.Text == "")
                {
                    error_label.Text = "Вы не ввели имя!";
                    error_label.Visible = true;
                    nameTextBox.BorderColor = Color.Red;
                    return;
                }
                else
                {
                    name = true;
                }
            }
            if (roleComboBox.Text != usersDataSet.Tables[0].Rows[0]["Роль"].ToString())
            {
                SqlDataAdapter rolesAdapter;
                DataSet rolesDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    rolesAdapter = new SqlDataAdapter($"SELECT * FROM Роли r WHERE r.Название = '{roleComboBox.Text}'", connection);
                    rolesDataSet = new DataSet();
                    rolesAdapter.Fill(rolesDataSet);
                }
                if (roleComboBox.Text != "")
                {
                    if (rolesDataSet.Tables[0].Rows.Count == 0)
                    {
                        error_label.Visible = true;
                        error_label.Text = "Такой роли не существует!";
                        return;
                    }
                }
                role = true;
            }
            if (verificationCheckBox.Checked != (bool)usersDataSet.Tables[0].Rows[0]["Подтверждение"])
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    int b;
                    if (verificationCheckBox.Checked)
                    {
                        b = 1;
                    }
                    else
                        b = 0;
                    string sqlExpression = $"UPDATE Пользователи SET Подтверждение={b} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            if (imageChange)
            {
                int i = Main.AddImage(fileName);
                SqlDataAdapter usAdapter;
                DataSet usDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    usAdapter = new SqlDataAdapter($"SELECT * FROM Пользователи WHERE Номер = {id}", connection);
                    usDataSet = new DataSet();
                    usAdapter.Fill(usDataSet);

                    string sqlExpression = $"UPDATE Пользователи SET Изображение={i} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();

                    if (usDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                    {
                        command = new SqlCommand($"DELETE FROM Изображения WHERE Номер={usDataSet.Tables[0].Rows[0]["Изображение"]}", connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (phoneTextBox.Text != usersDataSet.Tables[0].Rows[0]["Номер телефона"].ToString())
            {
                if (phoneTextBox.Text == "+375 (  )    -  -" && usersDataSet.Tables[0].Rows[0]["Номер телефона"].ToString() != "")
                {
                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        connection.Open();

                        string sqlExpression = $"UPDATE Пользователи SET [Номер телефона]='NULL' WHERE Номер = {id}";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                    }
                }
                else if (phoneTextBox.Text != "+375 (  )    -  -")
                {
                    if (Regex.IsMatch(phoneTextBox.Text[phoneTextBox.Text.Length - 1].ToString(), @"^\d+$") && phoneTextBox.Text.Length == 19)
                    {
                        using (SqlConnection connection = new SqlConnection(Main.connectionString))
                        {
                            connection.Open();

                            string sqlExpression = $"UPDATE Пользователи SET [НомерТелефона]='{phoneTextBox.Text}' WHERE Номер = {id}";
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            command.ExecuteNonQuery();
                        }
                        phoneLabel.Text = phoneTextBox.Text;
                    } else
                    {
                        error_label.Visible = true;
                        error_label.Text = "Неверный номер!";
                        return;
                    }
                }
            }
            if (role)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Пользователи SET Роль={roleComboBox.SelectedValue} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                roleLabel.Text = roleComboBox.Text;
            }
            if (name)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Пользователи SET Имя='{nameTextBox.Text}' WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                nameLabel.Text = nameTextBox.Text;
            }
            if (login)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Пользователи SET Логин='{loginTextBox.Text}' WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                loginLabel.Text = loginTextBox.Text;
            }
            //usersControl.LoadEmplCntrl();
            //usersControl.LoadReqCntrl();
            loginLabel.Visible = true;
            loginTextBox.Visible = false;
            nameLabel.Visible = true;
            nameTextBox.Visible = false;
            phoneLabel.Visible = true;
            phoneTextBox.Visible = false;
            roleLabel.Visible = true;
            roleComboBox.Visible = false;
            verificationCheckBox.Enabled = false;
            pic.Enabled = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            closeButton.Visible = false;
            error_label.Visible = false;

            if (role)
            {
                usersControl.LoadEmplCntrl();
                usersControl.LoadReqCntrl();
            }
            if (verificationCheckBox.Checked != (bool)usersDataSet.Tables[0].Rows[0]["Подтверждение"])
            {
                usersControl.LoadEmplCntrl();
                usersControl.LoadReqCntrl();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM ДесертыВКорзине WHERE (Корзина = (SELECT Номер FROM Корзина WHERE Пользователь = {id}))", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM Корзина WHERE Пользователь={id}", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM ДесертыВЗаказе WHERE (Заказ = (SELECT Номер FROM Заказы WHERE Пользователь = {id}))", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM Заказы WHERE Пользователь={id}", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"UPDATE Заказы SET Сотрудник=NULL, Статус=1 WHERE Сотрудник={id}", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM Пользователи WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            usersControl.LoadEmplCntrl();
            usersControl.LoadReqCntrl();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            loginLabel.Visible = true;
            loginTextBox.Visible = false;
            nameLabel.Visible = true;
            nameTextBox.Visible = false;
            phoneLabel.Visible = true;
            phoneTextBox.Visible = false;
            roleLabel.Visible = true;
            roleComboBox.Visible = false;
            verificationCheckBox.Enabled = false;
            pic.Enabled = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            closeButton.Visible = false;
        }
    }
}
