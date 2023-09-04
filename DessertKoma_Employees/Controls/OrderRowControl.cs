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
    public partial class OrderRowControl : UserControl
    {
        SqlDataAdapter ordersAdapter;
        DataSet ordersDataSet;
        OrdersControl ordersControl; 
        string id;
        public OrderRowControl(string i, OrdersControl cntrl)
        {
            InitializeComponent();
            id = i;
            ordersControl = cntrl;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            DessertsInOrderControl dessertsInOrderControl = new DessertsInOrderControl(id);
            ordersControl.Controls.Add(dessertsInOrderControl);
            dessertsInOrderControl.Location = new Point(100, 50);
            dessertsInOrderControl.BringToFront();
        }

        private void OrderRowControl_Load(object sender, EventArgs e)
        {
            if (Main.role == 3)
            {
                deleteButton.Visible = false;
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT p.Логин as Заказчик, z.[Дата заказа], z.[Дата выдачи], s.Название as Статус, z.Стоимость, z.Сотрудник FROM Заказы z " +
                    $"JOIN Пользователи p ON p.Номер = z.Пользователь JOIN Статусы s ON s.Номер = z.Статус WHERE z.Номер = {id}", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }
            var i = ordersDataSet.Tables[0].Rows.Count;
            if (ordersDataSet.Tables[0].Rows[0]["Сотрудник"].ToString() == "")
            {
                loginLabel.Text = ordersDataSet.Tables[0].Rows[0]["Заказчик"].ToString();
                orderDateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата заказа"]).ToShortDateString();
                employeeLabel.Text = "не назначен";
                dateLabel.Text = Convert.ToDateTime(ordersDataSet.Tables[0].Rows[0]["Дата выдачи"]).ToShortDateString();
                statusLabel.Text = ordersDataSet.Tables[0].Rows[0]["Статус"].ToString();
                costLabel.Text = $"{ordersDataSet.Tables[0].Rows[0]["Стоимость"]} руб.";
            } else
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    ordersAdapter = new SqlDataAdapter($"SELECT p.Логин as Заказчик, z.[Дата заказа], p2.Логин as Сотрудник, z.[Дата выдачи], s.Название as Статус, z.Стоимость FROM Заказы z JOIN Пользователи p ON p.Номер = z.Пользователь JOIN Пользователи p2 ON p2.Номер = z.Сотрудник JOIN Статусы s ON s.Номер = z.Статус WHERE z.Номер = {id}", connection);
                    ordersDataSet = new DataSet();
                    ordersAdapter.Fill(ordersDataSet);
                }

                loginLabel.Text = ordersDataSet.Tables[0].Rows[0]["Заказчик"].ToString();
                orderDateLabel.Text = ordersDataSet.Tables[0].Rows[0]["Дата заказа"].ToString();
                employeeLabel.Text = ordersDataSet.Tables[0].Rows[0]["Сотрудник"].ToString();
                dateLabel.Text = ordersDataSet.Tables[0].Rows[0]["Дата выдачи"].ToString();
                statusLabel.Text = ordersDataSet.Tables[0].Rows[0]["Статус"].ToString();
                costLabel.Text = $"{ordersDataSet.Tables[0].Rows[0]["Стоимость"]} руб.";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM ДесертыВЗаказе WHERE Заказ IN ({id})", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"DELETE FROM Заказы WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            ordersControl.LoadOrders();
        }
    }
}
