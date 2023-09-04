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
    public partial class OrdersForEmplControl : UserControl
    {
        int notVerForEmplPage;
        int notVerForEmplPageCount;
        int tookPage;
        int tookPageCount;
        int readyPage;
        int readyPageCount;
        public OrdersForEmplControl()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersForEmplControl_Load(object sender, EventArgs e)
        {
            notVerForEmplPage = 0;
            notVerForEmplPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 1 ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                notVerForEmplPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    notVerForEmplPage += 1;
                if (notVerForEmplPage > 1)
                {
                    guna2Button2.Visible = true;
                    guna2Button1.Visible = true;
                    guna2Button2.Enabled = false;
                }
                else
                {
                    guna2Button2.Visible = false;
                    guna2Button1.Visible = false;
                }
                if (notVerForEmplPage != 0)
                    FillNotVerForEmpl();
                else
                {

                }
            }

            tookPage = 0;
            tookPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы WHERE Статус = 3 AND Сотрудник = {Main.id} ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                tookPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    tookPage += 1;
                if (tookPage > 1)
                {
                    to_previous_in_progress_button.Visible = true;
                    to_next_in_progress_button.Visible = true;
                    to_previous_in_progress_button.Enabled = false;
                }
                else
                {
                    to_previous_in_progress_button.Visible = false;
                    to_next_in_progress_button.Visible = false;
                }
                if (tookPage != 0)
                    FillTookOrders();
                else
                {

                }
            }

            readyPage = 0;
            readyPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы WHERE Статус = 4 AND Сотрудник = {Main.id} ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                readyPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    readyPage += 1;
                if (readyPage > 1)
                {
                    to_previous_ready_button.Visible = true;
                    to_next_ready_button.Visible = true;
                    to_previous_ready_button.Enabled = false;
                }
                else
                {
                    to_previous_ready_button.Visible = false;
                    to_next_ready_button.Visible = false;
                }
                if (readyPage != 0)
                    FillReadyOrders();
                else
                {

                }
            }
        }

        private void FillReadyOrders()
        {
            readyOrdersPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы WHERE Статус = 4 AND Сотрудник = {Main.id} ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = readyPageCount * 5 - 5, j = 0; i < readyPageCount * 5; i++, j++)
            {

                ReadyOrderForEmplRowControl readyOrderForEmplRowControl = new ReadyOrderForEmplRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                readyOrdersPanel.Controls.Add(readyOrderForEmplRowControl);
                readyOrderForEmplRowControl.Location = new Point(0, j * 57);
                readyOrderForEmplRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        private void FillTookOrders()
        {
            inProgressOrdersPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы WHERE Статус = 3 AND Сотрудник = {Main.id} ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = tookPageCount * 5 - 5, j = 0; i < tookPageCount * 5; i++, j++)
            {

                TookOrderRowControl tookOrderRowControl = new TookOrderRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                inProgressOrdersPanel.Controls.Add(tookOrderRowControl);
                tookOrderRowControl.Location = new Point(0, j * 57);
                tookOrderRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        private void FillNotVerForEmpl()
        {
            notVerifiedForEmplPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы z WHERE z.Статус = 1 ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = notVerForEmplPageCount * 5 - 5, j = 0; i < notVerForEmplPageCount * 5; i++, j++)
            {

                NotVerifiedForEmplRowControl notVerifiedOrderRowControl = new NotVerifiedForEmplRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                notVerifiedForEmplPanel.Controls.Add(notVerifiedOrderRowControl);
                notVerifiedOrderRowControl.Location = new Point(0, j * 57);
                notVerifiedOrderRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        public void LoadNotVerForEmplOrders()
        {
            notVerForEmplPage = 0;
            notVerForEmplPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 1 ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                notVerForEmplPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    notVerForEmplPage += 1;
                if (notVerForEmplPage > 1)
                {
                    guna2Button2.Visible = true;
                    guna2Button1.Visible = true;
                    guna2Button2.Enabled = false;
                }
                else
                {
                    guna2Button2.Visible = false;
                    guna2Button1.Visible = false;
                }
                if (notVerForEmplPage != 0)
                    FillNotVerForEmpl();
                else
                {

                }
            }
        }

        public void LoadTookForEmplOrders()
        {
            tookPage = 0;
            tookPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы WHERE Статус = 3 AND Сотрудник = {Main.id} ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                tookPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    tookPage += 1;
                if (tookPage > 1)
                {
                    to_previous_in_progress_button.Visible = true;
                    to_next_in_progress_button.Visible = true;
                    to_previous_in_progress_button.Enabled = false;
                }
                else
                {
                    to_previous_in_progress_button.Visible = false;
                    to_next_in_progress_button.Visible = false;
                }
                if (tookPage != 0)
                    FillTookOrders();
                else
                {

                }
            }
        }

        public void LoadReadyOrders()
        {
            readyPage = 0;
            readyPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы WHERE Статус = 4 AND Сотрудник = {Main.id} ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                readyPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    readyPage += 1;
                if (readyPage > 1)
                {
                    to_previous_ready_button.Visible = true;
                    to_next_ready_button.Visible = true;
                    to_previous_ready_button.Enabled = false;
                }
                else
                {
                    to_previous_ready_button.Visible = false;
                    to_next_ready_button.Visible = false;
                }
                if (readyPage != 0)
                    FillReadyOrders();
                else
                {

                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            notVerForEmplPageCount += 1;
            if (notVerForEmplPageCount == notVerForEmplPage)
                guna2Button1.Enabled = false;
            guna2Button2.Enabled = true;
            if (notVerForEmplPageCount != 0)
                FillNotVerForEmpl();
            else
            {

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            notVerForEmplPageCount -= 1;
            if (notVerForEmplPageCount == 1)
                guna2Button2.Enabled = false;
            guna2Button1.Enabled = true;

            if (notVerForEmplPageCount != 0)
                FillNotVerForEmpl();
            else
            {

            }
        }

        private void inProgressOrdersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void to_previous_ready_button_Click(object sender, EventArgs e)
        {

        }

        private void to_previous_in_progress_button_Click(object sender, EventArgs e)
        {
            tookPageCount -= 1;
            if (tookPageCount == 1)
                to_previous_in_progress_button.Enabled = false;
            to_next_in_progress_button.Enabled = true;

            if (tookPageCount != 0)
                FillTookOrders();
            else
            {

            }
        }

        private void to_next_in_progress_button_Click(object sender, EventArgs e)
        {
            tookPageCount += 1;
            if (tookPageCount == tookPage)
                to_next_in_progress_button.Enabled = false;
            to_previous_in_progress_button.Enabled = true;
            if (tookPageCount != 0)
                FillTookOrders();
            else
            {

            }
        }

        private void to_next_ready_button_Click(object sender, EventArgs e)
        {
            readyPageCount += 1;
            if (readyPageCount == readyPage)
                to_next_ready_button.Enabled = false;
            to_previous_ready_button.Enabled = true;
            if (readyPageCount != 0)
                FillReadyOrders();
            else
            {

            }
        }

        private void to_previous_ready_button_Click_1(object sender, EventArgs e)
        {
            readyPageCount -= 1;
            if (readyPageCount == 1)
                to_previous_ready_button.Enabled = false;
            to_next_ready_button.Enabled = true;

            if (readyPageCount != 0)
                FillReadyOrders();
            else
            {

            }
        }
    }
}
