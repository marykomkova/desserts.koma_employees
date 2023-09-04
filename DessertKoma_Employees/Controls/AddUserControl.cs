using DessertKoma_Employees.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class AddUserControl : UserControl
    {
        ChangePhotoControl changePhotoControl;
        public bool ph;
        UsersControl usersControl;
        public AddUserControl(UsersControl u)
        {
            InitializeComponent();
            ph = false;
            usersControl = u;
            changePhotoControl = new ChangePhotoControl("newUser", this);
            Controls.Add(changePhotoControl);
            changePhotoControl.Hide();
            changePhotoControl.Location = new Point(340, 240);
            changePhotoControl.BringToFront();
        }

        private static int AddUser(string login, string password, string name, int role, int img, bool verification)
        {
            string sqlExpression = "sp_InsertUser5";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter loginParam = new SqlParameter
                {
                    ParameterName = "@Логин",
                    Value = login
                };
                command.Parameters.Add(loginParam);
                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@Пароль",
                    Value = password
                };
                command.Parameters.Add(passwordParam);
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Имя",
                    Value = name
                };
                command.Parameters.Add(nameParam);
                SqlParameter roleParam = new SqlParameter
                {
                    ParameterName = "@Роль",
                    Value = role
                };
                command.Parameters.Add(roleParam);
                SqlParameter imgParam = new SqlParameter
                {
                    ParameterName = "@Изображение",
                    Value = img
                };
                command.Parameters.Add(imgParam);
                SqlParameter verificationParam = new SqlParameter
                {
                    ParameterName = "@Подтверждение",
                    Value = verification
                };
                command.Parameters.Add(verificationParam);
                SqlParameter view_on_siteParam = new SqlParameter
                {
                    ParameterName = "@ОтображениеНаСайте",
                    Value = 0
                };
                command.Parameters.Add(view_on_siteParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private static int AddUser(string login, string password, string name, int role, bool verification)
        {
            string sqlExpression = "sp_InsertUser2";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter loginParam = new SqlParameter
                {
                    ParameterName = "@Логин",
                    Value = login
                };
                command.Parameters.Add(loginParam);
                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@Пароль",
                    Value = password
                };
                command.Parameters.Add(passwordParam);
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Имя",
                    Value = name
                };
                command.Parameters.Add(nameParam);
                SqlParameter roleParam = new SqlParameter
                {
                    ParameterName = "@Роль",
                    Value = role
                };
                command.Parameters.Add(roleParam);
                SqlParameter verificationParam = new SqlParameter
                {
                    ParameterName = "@Подтверждение",
                    Value = verification
                };
                command.Parameters.Add(verificationParam);
                SqlParameter view_on_siteParam = new SqlParameter
                {
                    ParameterName = "@ОтображениеНаСайте",
                    Value = 0
                };
                command.Parameters.Add(view_on_siteParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private static int AddUser(string login, string password, string name, int role, bool verification, string phone)
        {
            string sqlExpression = "sp_InsertUser3";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter loginParam = new SqlParameter
                {
                    ParameterName = "@Логин",
                    Value = login
                };
                command.Parameters.Add(loginParam);
                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@Пароль",
                    Value = password
                };
                command.Parameters.Add(passwordParam);
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Имя",
                    Value = name
                };
                command.Parameters.Add(nameParam); 
                SqlParameter roleParam = new SqlParameter
                {
                    ParameterName = "@Роль",
                    Value = role
                };
                command.Parameters.Add(roleParam);
                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@НомерТелефона",
                    Value = phone
                };
                command.Parameters.Add(phoneParam);
                SqlParameter verificationParam = new SqlParameter
                {
                    ParameterName = "@Подтверждение",
                    Value = verification
                };
                command.Parameters.Add(verificationParam);
                SqlParameter view_on_siteParam = new SqlParameter
                {
                    ParameterName = "@ОтображениеНаСайте",
                    Value = 0
                };
                command.Parameters.Add(view_on_siteParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private static int AddUser(string login, string password, string name, int role, bool verification, string phone, int img)
        {
            string sqlExpression = "sp_InsertUser";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter loginParam = new SqlParameter
                {
                    ParameterName = "@Логин",
                    Value = login
                };
                command.Parameters.Add(loginParam);
                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@Пароль",
                    Value = password
                };
                command.Parameters.Add(passwordParam);
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Имя",
                    Value = name
                };
                command.Parameters.Add(nameParam);
                SqlParameter roleParam = new SqlParameter
                {
                    ParameterName = "@Роль",
                    Value = role
                };
                command.Parameters.Add(roleParam);
                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@НомерТелефона",
                    Value = phone
                };
                command.Parameters.Add(phoneParam);
                SqlParameter imgParam = new SqlParameter
                {
                    ParameterName = "@Изображение",
                    Value = img
                };
                command.Parameters.Add(imgParam);
                SqlParameter verificationParam = new SqlParameter
                {
                    ParameterName = "@Подтверждение",
                    Value = verification
                };
                command.Parameters.Add(verificationParam);
                SqlParameter view_on_siteParam = new SqlParameter
                {
                    ParameterName = "@ОтображениеНаСайте",
                    Value = 0
                };
                command.Parameters.Add(view_on_siteParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (changePhotoControl.getD())
                changePhotoControl.Hide();
            changePhotoControl.setD(false);
        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (!changePhotoControl.getD())
            {
                changePhotoControl.Show();
                changePhotoControl.setD(true);
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void roleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void verificationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {

            ролиTableAdapter.Fill(dessertsKomaDataSet.Роли);
        }

        private void hidePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = true;
            hidePasswordBtn.Visible = false;
            password_textBox.PasswordChar = '●';
        }

        private void seePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = false;
            hidePasswordBtn.Visible = true;
            password_textBox.PasswordChar = '\0';
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            loginTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            nameTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            password_textBox.BorderColor = Color.FromArgb(213, 218, 223);
            if (loginTextBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели логин";
                errorLabel.Visible = true;
                loginTextBox.BorderColor = Color.Red;
                return;
            }
            else if (password_textBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели пароль";
                errorLabel.Visible = true;
                password_textBox.BorderColor = Color.Red;
                return;
            }
            else if (nameTextBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели имя";
                errorLabel.Visible = true;
                nameTextBox.BorderColor = Color.Red;
                return;
            }
            else
            {
                bool can = true;
                string[] dataLogin = loginTextBox.Text.Split('@');
                if (dataLogin.Length == 2)
                {
                    string[] data2Login = dataLogin[1].Split('.');
                    if (data2Login.Length != 2)
                    {
                        errorLabel.Text = "!Укажите логин в форме х@x.x";
                        errorLabel.Visible = true;
                        loginTextBox.BorderColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    errorLabel.Text = "!Укажите логин в форме х@x.x";
                    errorLabel.Visible = true;
                    loginTextBox.BorderColor = Color.Red;
                    return;
                }
                for (int i = 0; i < loginTextBox.Text.Length; i++)
                {
                    if (loginTextBox.Text[i] >= 'а' && loginTextBox.Text[i] <= 'я')
                        can = false;
                }

                if (!can)
                {
                    errorLabel.Text = "!Могут использоваться только английские буквы";
                    errorLabel.Visible = true;
                    loginTextBox.BorderColor = Color.Red;
                    return;
                }

                SqlDataAdapter rolesAdapter;
                DataSet rolesDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    rolesAdapter = new SqlDataAdapter($"SELECT * FROM Роли r WHERE r.Название = '{roleComboBox.Text}'", connection);
                    rolesDataSet = new DataSet();
                    rolesAdapter.Fill(rolesDataSet);
                }
                if (rolesDataSet.Tables[0].Rows.Count == 0)
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Такой роли не существует!";
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        can = true;
                        string sqlExpression = $"SELECT * FROM Пользователи WHERE Логин='{loginTextBox.Text}'";
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                can = false;
                            }
                        }
                        reader.Close();
                        if (!can)
                        {
                            errorLabel.Text = "!Пользователь с таким логином уже существует";
                            errorLabel.Visible = true;
                            loginTextBox.BorderColor = Color.Red;
                            return;
                        }
                        else
                        {
                            for (int i = 0; i < password_textBox.Text.Length; i++)
                            {
                                if (password_textBox.Text[i] >= 'А' && password_textBox.Text[i] <= 'Я')
                                {
                                    can = false;
                                    errorLabel.Text = "!Могут использоваться только английские буквы";
                                    errorLabel.Visible = true;
                                    password_textBox.BorderColor = Color.Red;
                                    return;
                                }
                                else if (password_textBox.Text[i] == ' ')
                                {
                                    can = false;
                                    errorLabel.Text = "!Пароль не может содержать пробел";
                                    errorLabel.Visible = true;
                                    password_textBox.BorderColor = Color.Red;
                                    return;
                                }
                            }
                            int count = 0;
                            for (int i = 0; i < password_textBox.Text.Length; i++)
                            {
                                if (password_textBox.Text[i] >= '0' && password_textBox.Text[i] <= '9')
                                {
                                    ++count;
                                }
                            }
                            if (count == 0)
                            {
                                errorLabel.Text = "!Пароль должен содержать хотя бы одну цифру";
                                errorLabel.Visible = true;
                                password_textBox.BorderColor = Color.Red;
                                return;
                            } else if (count == password_textBox.Text.Length)
                            {
                                errorLabel.Text = "!Пароль должен содержать хотя бы одну букву";
                                errorLabel.Visible = true;
                                password_textBox.BorderColor = Color.Red;
                                return;
                            }
                            if (password_textBox.Text.Length < 6)
                            {
                                errorLabel.Text = "!Пароль должен быть длинее 6 символов";
                                errorLabel.Visible = true;
                                password_textBox.BorderColor = Color.Red;
                                return;
                            }

                            if (phoneTextBox.Text != "+375 (  )    -  -")
                            {
                                AddUser(loginTextBox.Text, password_textBox.Text, nameTextBox.Text, Convert.ToInt32(roleComboBox.SelectedValue), verificationCheckBox.Checked, phoneTextBox.Text);
                            }
                            else if (phoneTextBox.Text != "+375 (  )    -  -" && ph)
                            {
                                int i = Main.AddImage(changePhotoControl.getAddUserFileName());
                                AddUser(loginTextBox.Text, password_textBox.Text, nameTextBox.Text, Convert.ToInt32(roleComboBox.SelectedValue), verificationCheckBox.Checked, phoneTextBox.Text, i);
                            }
                            else if (ph)
                            {
                                int i = Main.AddImage(changePhotoControl.getAddUserFileName());
                                AddUser(loginTextBox.Text, password_textBox.Text, nameTextBox.Text, Convert.ToInt32(roleComboBox.SelectedValue), i, verificationCheckBox.Checked);
                            }
                            else
                            {
                                AddUser(loginTextBox.Text, password_textBox.Text, nameTextBox.Text, Convert.ToInt32(roleComboBox.SelectedValue), verificationCheckBox.Checked);
                            }
                            Hide();
                            usersControl.LoadEmplCntrl();
                            usersControl.LoadReqCntrl();
                        }
                    }
                }
            }
        }

        private void userPic_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
