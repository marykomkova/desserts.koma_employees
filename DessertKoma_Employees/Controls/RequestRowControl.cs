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
    public partial class RequestRowControl : UserControl
    {
        UsersControl usersControl;
        string id;
        SqlDataAdapter usersAdapter;
        DataSet usersDataSet;
        public RequestRowControl(string i, UsersControl cntrl)
        {
            InitializeComponent(); 
            usersControl = cntrl;
            id = i;
            ролиTableAdapter.Fill(dessertsKomaDataSet.Роли);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
                    return;
                }
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Пользователи SET Роль={roleComboBox.SelectedValue}, Подтверждение = 1 WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            usersControl.LoadReqCntrl();
            usersControl.LoadEmplCntrl();
        }

        private void RequestRowControl_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                usersAdapter = new SqlDataAdapter($"SELECT p.Логин, p.Имя, p.Подтверждение as Подтверждение, " +
                    $"p.НомерТелефона as [Номер телефона], p.Изображение FROM Пользователи p WHERE p.Номер = {id}", connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet);
            }
            loginLabel.Text = usersDataSet.Tables[0].Rows[0]["Логин"].ToString();
            nameLabel.Text = usersDataSet.Tables[0].Rows[0]["Имя"].ToString();
            roleComboBox.Text = "Выберите роль";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM Пользователи WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            usersControl.LoadReqCntrl();
            usersControl.LoadEmplCntrl();
        }

        private void roleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
