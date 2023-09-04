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

namespace DessertKoma_Employees.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private static int AddUser(string login, string password, string name)
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
                SqlParameter view_on_siteParam = new SqlParameter
                {
                    ParameterName = "@ОтображениеНаСайте",
                    Value = 0
                };
                command.Parameters.Add(view_on_siteParam);
                SqlParameter verificationParam = new SqlParameter
                {
                    ParameterName = "@Подтверждение",
                    Value = 0
                };
                command.Parameters.Add(verificationParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void seeRepeatPasswordBtn_Click(object sender, EventArgs e)
        {
            seeRepeatPasswordBtn.Visible = false;
            hideRepeatPasswordBtn.Visible = true;
            repeatPassword_textBox.PasswordChar = '\0';
        }

        private void seePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = false;
            hidePasswordBtn.Visible = true;
            password_textBox.PasswordChar = '\0';
        }

        private void hidePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = true;
            hidePasswordBtn.Visible = false;
            password_textBox.PasswordChar = '●';
        }

        private void hideRepeatPasswordBtn_Click(object sender, EventArgs e)
        {
            seeRepeatPasswordBtn.Visible = true;
            hideRepeatPasswordBtn.Visible = false;
            repeatPassword_textBox.PasswordChar = '●';
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            Hide();
            signIn.ShowDialog();
            Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_textBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            repeatPassword_textBox.BorderColor = Color.DarkGray;
            name_textBox.BorderColor = Color.DarkGray;
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            repeatPassword_textBox.BorderColor = Color.DarkGray;
            name_textBox.BorderColor = Color.DarkGray;
        }

        private void repeatPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            repeatPassword_textBox.BorderColor = Color.DarkGray;
            name_textBox.BorderColor = Color.DarkGray;
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            repeatPassword_textBox.BorderColor = Color.DarkGray;
            name_textBox.BorderColor = Color.DarkGray;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            repeatPassword_textBox.BorderColor = Color.DarkGray;
            name_textBox.BorderColor = Color.DarkGray;
            if (login_textBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели логин";
                errorLabel.Visible = true;
                login_textBox.BorderColor = Color.Red;
            }
            else if (password_textBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели пароль";
                errorLabel.Visible = true;
                password_textBox.BorderColor = Color.Red;
            }
            else if (repeatPassword_textBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не повторили пароль";
                errorLabel.Visible = true;
                repeatPassword_textBox.BorderColor = Color.Red;
            }
            else if (name_textBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели имя";
                errorLabel.Visible = true;
                name_textBox.BorderColor = Color.Red;
            }
            else
            {
                bool can = true;
                string[] dataLogin = login_textBox.Text.Split('@');
                if (dataLogin.Length == 2)
                {
                    string[] data2Login = dataLogin[1].Split('.');
                    if (data2Login.Length != 2)
                    {
                        can = false;
                        errorLabel.Text = "!Укажите логин в форме х@x.x";
                        errorLabel.Visible = true;
                        login_textBox.BorderColor = Color.Red;
                        return;
                    }
                        
                }
                else
                {
                    errorLabel.Text = "!Укажите логин в форме х@x.x";
                    errorLabel.Visible = true;
                    login_textBox.BorderColor = Color.Red;
                    return;
                }
                for (int i = 0; i < login_textBox.Text.Length; i++)
                {
                    if (login_textBox.Text[i] >= 'а' && login_textBox.Text[i] <= 'я')
                        can = false;
                }

                if (!can)
                {
                    errorLabel.Text = "!Могут использоваться только английские буквы";
                    errorLabel.Visible = true;
                    login_textBox.BorderColor = Color.Red;
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        string sqlExpression = $"SELECT * FROM Пользователи WHERE Логин='{login_textBox.Text}'";
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
                            login_textBox.BorderColor = Color.Red;
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
                            if (can)
                            {
                                if (password_textBox.Text.Length < 6)
                                {
                                    errorLabel.Text = "!Пароль должен быть длинее 6 символов";
                                    errorLabel.Visible = true;
                                    password_textBox.BorderColor = Color.Red;
                                    return;
                                }
                                else if (password_textBox.Text != repeatPassword_textBox.Text)
                                {
                                    errorLabel.Text = "!Пароли не совпадают";
                                    errorLabel.Visible = true;
                                    password_textBox.BorderColor = Color.Red;
                                    repeatPassword_textBox.BorderColor = Color.Red;
                                    return;
                                }
                                else
                                {
                                    AddUser(login_textBox.Text, password_textBox.Text, name_textBox.Text);
                                    NoVerificationUser noVerificationUser = new NoVerificationUser();
                                    Hide();
                                    noVerificationUser.ShowDialog();
                                    Close();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
