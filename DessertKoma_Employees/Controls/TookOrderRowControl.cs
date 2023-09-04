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
    public partial class TookOrderRowControl : UserControl
    {
        SqlDataAdapter ordersAdapter;
        DataSet ordersDataSet;
        OrdersForEmplControl ordersControl;
        string id;
        public TookOrderRowControl(string i, OrdersForEmplControl cntrl)
        {
            InitializeComponent();
            id = i;
            ordersControl = cntrl;
        }

        private void TookOrderRowControl_Load(object sender, EventArgs e)
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

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"UPDATE Заказы SET Статус = 4 WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            ordersControl.inProgressOrdersPanel.Controls.Clear();
            ordersControl.LoadNotVerForEmplOrders();
            ordersControl.LoadReadyOrders();
            ordersControl.LoadTookForEmplOrders();
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
