using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace DessertKoma_Employees.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
            if (login_textBox.Text.Length == 0)
            {
                errorLabel.Text = "Вы не ввели логин";
                errorLabel.Visible = true;
                login_textBox.BorderColor = Color.Red;
                return;
            }
            else if (password_textBox.Text.Length == 0)
            {
                errorLabel.Text = "Вы не ввели пароль";
                errorLabel.Visible = true;
                password_textBox.BorderColor = Color.Red;
                return;
            }
            else
            {
                string sqlExpression = $"SELECT * FROM Пользователи WHERE Логин='{login_textBox.Text}' and Пароль='{password_textBox.Text}'";
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            long id = reader.GetInt64(0);
                            long role = reader.GetInt64(5);
                            SqlString name = reader.GetSqlString(3);
                            int hours = DateTime.Now.Hour;

                            if (name.IsNull)
                            {
                                string[] dataLogin = login_textBox.Text.Split('@');
                                if (hours >= 4 && hours <= 11)
                                {
                                    MessageBox.Show($"Доброе утро, {dataLogin[0]}! Хорошего дня ;)");
                                }
                                else if (hours > 11 && hours <= 16)
                                {
                                    MessageBox.Show($"Добрый день, {dataLogin[0]}!");
                                }
                                else if (hours > 16 && hours <= 22)
                                {
                                    MessageBox.Show($"Добрый вечер, {dataLogin[0]}!");
                                }
                                else if (hours > 22 && hours < 4)
                                {
                                    MessageBox.Show($"Здравствуйте, {dataLogin[0]}!");
                                }
                            } else
                            {
                                if (hours >= 4 && hours <= 11)
                                {
                                    MessageBox.Show($"Доброе утро, {name}! Хорошего дня ;)");
                                }
                                else if (hours > 11 && hours <= 16)
                                {
                                    MessageBox.Show($"Добрый день, {name}!");
                                }
                                else if (hours > 16 && hours <= 22)
                                {
                                    MessageBox.Show($"Добрый вечер, {name}!");
                                }
                                else if (hours > 22 && hours < 4)
                                {
                                    MessageBox.Show($"Здравствуйте, {name}!");
                                }
                            }
                            if (role == 4)
                            {
                                errorLabel.Text = "Заказчики не имеют доступ к программе!";
                                errorLabel.Visible = true;
                                login_textBox.BorderColor = Color.Red;
                                return;
                            }
                            
                            Main main = new Main(id, role);
                            Hide();
                            main.ShowDialog();
                            Close();
                        }
                    }
                    else
                    {
                        errorLabel.Text = "!Пользователь не найден";
                        errorLabel.Visible = true;
                        login_textBox.BorderColor = Color.Red;
                        return;
                    }
                    reader.Close();
                }
            }
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
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            login_textBox.BorderColor = Color.DarkGray;
            password_textBox.BorderColor = Color.DarkGray;
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            Hide();
            signUp.ShowDialog();
            Close();
        }
    }
}
