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
    public partial class NotVerifiedOrderRowControl : UserControl
    {
        SqlDataAdapter ordersAdapter;
        DataSet ordersDataSet;
        OrdersControl ordersControl;
        string id;
        public NotVerifiedOrderRowControl(string i, OrdersControl cntrl)
        {
            InitializeComponent();
            id = i;
            ordersControl = cntrl; 
        }

        private void NotVerifiedOrderRowControl_Load(object sender, EventArgs e)
        {
            SqlDataAdapter employeesAdapter;
            DataSet employeesDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                employeesAdapter = new SqlDataAdapter($"SELECT Номер, Логин FROM Пользователи WHERE Роль != 4", connection);
                employeesDataSet = new DataSet();
                employeesAdapter.Fill(employeesDataSet);
            }

            employeeComboBox.Items.Clear();
            for (int j = 0; j < employeesDataSet.Tables[0].Rows.Count; j++)
            {
                employeeComboBox.Items.Add(employeesDataSet.Tables[0].Rows[j]["Логин"]);
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT p.Логин as Заказчик, z.[Дата заказа], z.[Дата выдачи], z.Стоимость FROM Заказы z " +
                    $"JOIN Пользователи p ON p.Номер = z.Пользователь WHERE z.Номер = {id}", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }
            loginLabel.Text = ordersDataSet.Tables[0].Rows[0]["Заказчик"].ToString();
            orderDateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата заказа"]).ToShortDateString();
            dateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата выдачи"]).ToShortDateString();
            costLabel.Text = ordersDataSet.Tables[0].Rows[0]["Стоимость"].ToString() + " руб.";
            employeeComboBox.Text = "Выберите сотрудника";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM ДесертыВЗаказе WHERE Заказ={id}", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM Заказы WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            ordersControl.LoadOrders();
            ordersControl.LoadNotVerOrders();
            ordersControl.LoadInPrOrders();
            ordersControl.LoadReadyOrders();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter employeesAdapter;
            DataSet employeesDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                employeesAdapter = new SqlDataAdapter($"SELECT * FROM Пользователи WHERE Логин = '{employeeComboBox.Text}'", connection);
                employeesDataSet = new DataSet();
                employeesAdapter.Fill(employeesDataSet);
            }
            if (employeesDataSet.Tables[0].Rows.Count == 0)
            {
                error_label.Text = "Вы не выбрали сотрудника!";
                error_label.Visible = true;
            } else
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"UPDATE Заказы SET Сотрудник = {employeesDataSet.Tables[0].Rows[0]["Номер"]}, Статус = 3 WHERE Номер={id}", connection);
                    command.ExecuteNonQuery();
                }
                ordersControl.LoadOrders();
                ordersControl.LoadNotVerOrders();
                ordersControl.LoadInPrOrders();
            }
            
        }
    }
}
