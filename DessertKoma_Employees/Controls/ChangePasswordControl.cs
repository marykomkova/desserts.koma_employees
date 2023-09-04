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
    public partial class ChangePasswordControl : UserControl
    {
        UserAccountControl userAccountControl;
        public ChangePasswordControl(UserAccountControl obj)
        {
            InitializeComponent();
            userAccountControl = obj;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (oldPasswordTextBox.Text.Length == 0)
            {
                error_label.Text = "Поле не заполнено!";
                error_label.Visible = true;
                oldPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            else if (newPasswordTextBox.Text.Length == 0)
            {
                error_label2.Text = "Поле не заполнено!";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            }

            for (int i = 0; i < newPasswordTextBox.Text.Length; i++)
            {
                if (newPasswordTextBox.Text[i] >= 'А' && newPasswordTextBox.Text[i] <= 'Я')
                {
                    error_label2.Text = "!Могут использоваться только английские буквы";
                    error_label2.Visible = true;
                    newPasswordTextBox.BorderColor = Color.Red;
                    return;
                }
                else if (newPasswordTextBox.Text[i] == ' ')
                {
                    error_label2.Text = "!Пароль не может содержать пробел";
                    error_label2.Visible = true;
                    newPasswordTextBox.BorderColor = Color.Red;
                    return;
                }
            }
            int coun = 0;
            for (int i = 0; i < newPasswordTextBox.Text.Length; i++)
            {
                if (newPasswordTextBox.Text[i] >= '0' && newPasswordTextBox.Text[i] <= '9')
                {
                    ++coun;
                }
            }
            if (coun == 0)
            {
                error_label2.Text = "!Пароль должен содержать хотя бы одну цифру";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            else if (coun == newPasswordTextBox.Text.Length)
            {
                error_label2.Text = "!Пароль должен содержать хотя бы одну букву";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            }

            string sqlExpression = $"SELECT * FROM Пользователи WHERE Номер={userAccountControl.id} and Пароль='{oldPasswordTextBox.Text}'";
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                var reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    error_label.Text = "Неверный пароль!";
                    error_label.Visible = true;
                    oldPasswordTextBox.BorderColor = Color.Red;
                    return;
                } else
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(2) == newPasswordTextBox.Text)
                        {
                            error_label2.Text = "Пароль не изменен!";
                            error_label2.Visible = true;
                            newPasswordTextBox.BorderColor = Color.Red;
                            return;
                        }
                    }
                }
                reader.Close();
            }

            for (int i = 0; i < newPasswordTextBox.Text.Length; i++)
            {
                if (newPasswordTextBox.Text[i] >= 'А' && newPasswordTextBox.Text[i] <= 'Я')
                {
                    error_label2.Text = "Могут использоваться только английские буквы!";
                    error_label2.Visible = true;
                    newPasswordTextBox.BorderColor = Color.Red;
                    return;
                }
                else if (newPasswordTextBox.Text[i] == ' ')
                {
                    error_label2.Text = "Пароль не может содержать пробел!";
                    error_label2.Visible = true;
                    newPasswordTextBox.BorderColor = Color.Red;
                    return;
                }
            }
            int count = 0;
            for (int i = 0; i < newPasswordTextBox.Text.Length; i++)
            {
                if (newPasswordTextBox.Text[i] >= '0' && newPasswordTextBox.Text[i] <= '9')
                {
                    ++count;
                }
            }
            if (count == 0)
            {
                error_label2.Text = "Пароль должен содержать хотя бы одну цифру!";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            else if (count == newPasswordTextBox.Text.Length)
            {
                error_label2.Text = "Пароль должен содержать хотя бы одну букву!";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            else if (newPasswordTextBox.Text.Length < 6)
            {
                error_label2.Text = "Пароль должен быть длинее 6 символов!";
                error_label2.Visible = true;
                newPasswordTextBox.BorderColor = Color.Red;
                return;
            } else
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression2 = $"UPDATE Пользователи SET Пароль='{newPasswordTextBox.Text}' WHERE Номер = {userAccountControl.id}";
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.ExecuteNonQuery();
                }
                Hide();
            }
        }

        private void seePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = false;
            hidePasswordBtn.Visible = true;
            oldPasswordTextBox.PasswordChar = '\0';
        }

        private void seeNewPasswordBtn_Click(object sender, EventArgs e)
        {
            seeNewPasswordBtn.Visible = false;
            hideNewPasswordBtn.Visible = true;
            newPasswordTextBox.PasswordChar = '\0';
        }

        private void hidePasswordBtn_Click(object sender, EventArgs e)
        {
            seePasswordBtn.Visible = true;
            hidePasswordBtn.Visible = false;
            oldPasswordTextBox.PasswordChar = '●';
        }

        private void hideNewPasswordBtn_Click(object sender, EventArgs e)
        {
            seeNewPasswordBtn.Visible = true;
            hideNewPasswordBtn.Visible = false;
            newPasswordTextBox.PasswordChar = '●';
        }

        private void oldPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            error_label2.Visible = false; 
            oldPasswordTextBox.BorderColor = Color.Gainsboro;
            newPasswordTextBox.BorderColor = Color.Gainsboro;
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            error_label2.Visible = false;
            oldPasswordTextBox.BorderColor = Color.Gainsboro;
            newPasswordTextBox.BorderColor = Color.Gainsboro;
        }
    }
}
