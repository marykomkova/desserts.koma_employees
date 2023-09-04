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
    public partial class InProgressOrdersRowControl : UserControl
    {
        SqlDataAdapter ordersAdapter;
        DataSet ordersDataSet;
        OrdersControl ordersControl;
        string id;
        public InProgressOrdersRowControl(string i, OrdersControl cntrl)
        {
            InitializeComponent();
            id = i;
            ordersControl = cntrl;
        }

        private void InProgressOrdersRowControl_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT p.Логин as Заказчик, z.[Дата заказа], z.[Дата выдачи], z.Стоимость, p2.Логин as Сотрудник FROM Заказы z " +
                    $"JOIN Пользователи p ON p.Номер = z.Пользователь JOIN Пользователи p2 ON p2.Номер = z.Сотрудник WHERE z.Номер = {id}", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }
            loginLabel.Text = ordersDataSet.Tables[0].Rows[0]["Заказчик"].ToString();
            employeeLabel.Text = ordersDataSet.Tables[0].Rows[0]["Сотрудник"].ToString();
            orderDateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата заказа"]).ToShortDateString();
            dateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата выдачи"]).ToShortDateString();
            costLabel.Text = ordersDataSet.Tables[0].Rows[0]["Стоимость"].ToString() + " руб.";
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
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"UPDATE Заказы SET Статус = 4 WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            ordersControl.LoadOrders();
            ordersControl.LoadNotVerOrders();
            ordersControl.LoadInPrOrders();
            ordersControl.LoadReadyOrders();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DessertsInOrderControl dessertsInOrderControl = new DessertsInOrderControl(id);
            ordersControl.Controls.Add(dessertsInOrderControl);
            dessertsInOrderControl.Location = new Point(100, 50);
            dessertsInOrderControl.BringToFront();
        }
    }
}
