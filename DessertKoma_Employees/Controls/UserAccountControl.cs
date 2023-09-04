using DessertKoma_Employees.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = DessertsKoma_Employees.Classes.Image;
using Image2 = System.Drawing.Image;

namespace DessertKoma_Employees.Controls
{
    public partial class UserAccountControl : UserControl
    {
        public long id;
        string password;
        public static SqlDataAdapter usersAdapter;
        public static DataSet usersDataSet;
        ChangePhotoControl changePhotoControl;
        public UserAccountControl(long i)
        {
            SqlDataAdapter imageAdapter;
            DataSet imageDataSet;
            InitializeComponent();
            this.id = i;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                usersAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин, p.Пароль, p.Изображение, r.Название FROM Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Номер = {id}", connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet); 
                userNameLabel.Text = usersDataSet.Tables[0].Rows[0]["Имя"].ToString();
                emailNameLabel.Text = usersDataSet.Tables[0].Rows[0]["Логин"].ToString();
                userRoleLabel.Text = usersDataSet.Tables[0].Rows[0]["Название"].ToString();
                password = usersDataSet.Tables[0].Rows[0]["Пароль"].ToString();

                var l = usersDataSet.Tables[0].Rows[0]["Изображение"];
                if (usersDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                {
                    string sqlExpression = $"SELECT * FROM Изображения WHERE Номер={usersDataSet.Tables[0].Rows[0]["Изображение"]}";
                    imageAdapter = new SqlDataAdapter(sqlExpression, connection);
                    imageDataSet = new DataSet();
                    imageAdapter.Fill(imageDataSet);
                    int id = Convert.ToInt32(imageDataSet.Tables[0].Rows[0]["Номер"]);
                    string filename = imageDataSet.Tables[0].Rows[0]["ИмяФайла"].ToString();
                    string title = imageDataSet.Tables[0].Rows[0]["Название"].ToString();
                    byte[] data = (byte[])imageDataSet.Tables[0].Rows[0]["Данные"];
                    Image image = new Image(id, filename, title, data);
                    string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{image.FileName}");
                    if (!File.Exists(path))
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.OpenOrCreate))
                        {
                            fs.Write(image.Data, 0, image.Data.Length);
                        }
                    }

                    userIcon.Image = Image2.FromFile(path);
                }
            }
        }

        private void UserAccountControl_Load(object sender, EventArgs e)
        {

        }

        private void userIcon_MouseHover(object sender, EventArgs e)
        {
            changePhotoControl = new ChangePhotoControl("user", this);
            Controls.Add(changePhotoControl);
            changePhotoControl.Location = new Point(25, 110);
            changePhotoControl.BringToFront();
        }

        private void userIcon_MouseHover_1(object sender, EventArgs e)
        {
            changePhotoControl = new ChangePhotoControl("user", this);
            Controls.Add(changePhotoControl);
            changePhotoControl.Location = new Point(25, 110);
            changePhotoControl.BringToFront();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 8)
                Controls.RemoveAt(0);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            nameTextBox.BorderColor = Color.DarkGray;
            if (userNameLabel.Visible == true)
            {
                userNameLabel.Visible = false;
                nameTextBox.Text = userNameLabel.Text;
                nameTextBox.Visible = true;
                save_button.Visible = true;
            } else
            {
                userNameLabel.Visible = true;
                nameTextBox.Visible = false;
                save_button.Visible = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                error_label.Text = "Вы не ввели имя!";
                error_label.Visible = true;
                nameTextBox.BorderColor = Color.Red;
                return;
            } else
            {
                error_label.Visible = false;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Пользователи SET Имя='{nameTextBox.Text}' WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                userNameLabel.Text = nameTextBox.Text;
                userNameLabel.Visible = true;
                nameTextBox.Visible = false;
                save_button.Visible = false;
            }
        }

        private void edit_email_button_Click(object sender, EventArgs e)
        {
            error_label2.Visible = false;
            emailTextBox.BorderColor = Color.DarkGray;
            if (emailNameLabel.Visible == true)
            {
                emailNameLabel.Visible = false;
                emailTextBox.Text = emailNameLabel.Text;
                emailTextBox.Visible = true;
                save_email_button.Visible = true;
            }
            else
            {
                emailNameLabel.Visible = true;
                emailTextBox.Visible = false;
                save_email_button.Visible = false;
            }
        }

        private void save_email_button_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == emailNameLabel.Text)
            {
                emailNameLabel.Visible = true;
                emailTextBox.Visible = false;
                save_email_button.Visible = false;
                return;
            }
            if (emailTextBox.Text == "")
            {
                error_label2.Text = "Вы не ввели email!";
                error_label2.Visible = true;
                emailTextBox.BorderColor = Color.Red;
                return;
            }
            else
            {
                string[] dataLogin = emailTextBox.Text.Split('@');
                if (dataLogin.Length == 2)
                {
                    string[] data2Login = dataLogin[1].Split('.');
                    if (data2Login.Length != 2)
                    {
                        error_label2.Text = "!Укажите логин в форме х@x.x";
                        error_label2.Visible = true;
                        emailTextBox.BorderColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    error_label2.Text = "!Укажите логин в форме х@x.x";
                    error_label2.Visible = true;
                    emailTextBox.BorderColor = Color.Red;
                    return;
                }
                for (int i = 0; i < emailTextBox.Text.Length; i++)
                {
                    if (emailTextBox.Text[i] >= 'а' && emailTextBox.Text[i] <= 'я')
                    {
                        error_label2.Text = "!Могут использоваться только английские буквы";
                        error_label2.Visible = true;
                        emailTextBox.BorderColor = Color.Red;
                        return;
                    }
                }

                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    string sqlExpression = $"SELECT * FROM Пользователи WHERE Логин='{emailTextBox.Text}'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            error_label2.Text = "!Пользователь с таким логином уже существует";
                            error_label2.Visible = true;
                            emailTextBox.BorderColor = Color.Red;
                            return;
                        }
                    }
                    reader.Close();
                }
            }

            error_label2.Visible = false;
            emailTextBox.BorderColor = Color.DarkGray;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                string sqlExpression = $"UPDATE Пользователи SET Логин='{emailTextBox.Text}' WHERE Номер = {id}";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            emailNameLabel.Text = emailTextBox.Text;
            emailNameLabel.Visible = true;
            emailTextBox.Visible = false;
            save_email_button.Visible = false;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 8)
                Controls.RemoveAt(0);
            ChangePasswordControl changePasswordControl = new ChangePasswordControl(this);
            Controls.Add(changePasswordControl);
            changePasswordControl.Location = new Point(100, 50);
            changePasswordControl.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Main.Exit();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BorderColor = Color.DarkGray;
            error_label.Visible = false;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.BorderColor = Color.DarkGray;
            error_label2.Visible = false;
        }
    }
}
