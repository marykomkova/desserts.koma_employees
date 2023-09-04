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
    public partial class OrdersControl : UserControl
    {
        int page;
        int pageCount;
        int notVerPage;
        int notVerPageCount;
        int inPrPage;
        int inPrPageCount;
        int readyPage;
        int readyPageCount;
        public OrdersControl()
        {
            InitializeComponent();
        }

        private void ordersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersControl_Load(object sender, EventArgs e)
        {
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                
                page = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    page += 1;
                if (page > 1)
                {
                    to_previous_button.Visible = true;
                    to_next_button.Visible = true;
                    to_previous_button.Enabled = false;
                }
                else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillOrders();
                else
                {

                }
            }

            notVerPage = 0;
            notVerPageCount = 1;
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
                notVerPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    notVerPage += 1;
                if (notVerPage > 1)
                {
                    to_previous_cust_button.Visible = true;
                    to_next_cust_button.Visible = true;
                    to_previous_cust_button.Enabled = false;
                }
                else
                {
                    to_previous_cust_button.Visible = false;
                    to_next_cust_button.Visible = false;
                }
                if (notVerPage != 0)
                    FillNotVerOrders();
                else
                {

                }
            }

            inPrPage = 0;
            inPrPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 3 ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                inPrPage = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    inPrPage += 1;
                if (inPrPage > 1)
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
                if (inPrPage != 0)
                    FillInProgressOrders();
                else
                {

                }
            }

            readyPage = 0;
            readyPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 4 ORDER BY Номер DESC";
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

        private void FillOrders()
        {
            ordersPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = pageCount * 5 - 5, j = 0; i < pageCount * 5; i++, j++)
            {

                OrderRowControl orderRowControl = new OrderRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                ordersPanel.Controls.Add(orderRowControl);
                orderRowControl.Location = new Point(0, j * 75);
                orderRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        private void FillNotVerOrders()
        {
            notVerifiedOrdersPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы z WHERE z.Статус = 1 ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = notVerPageCount * 6 - 6, j = 0; i < notVerPageCount * 6; i++, j++)
            {

                NotVerifiedOrderRowControl notVerifiedOrderRowControl = new NotVerifiedOrderRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                notVerifiedOrdersPanel.Controls.Add(notVerifiedOrderRowControl);
                notVerifiedOrderRowControl.Location = new Point(0, j * 57);
                notVerifiedOrderRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        private void FillInProgressOrders()
        {
            inProgressOrdersPanel.Controls.Clear();
            SqlDataAdapter ordersAdapter;
            DataSet ordersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы z WHERE z.Статус = 3 ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = inPrPageCount * 6 - 6, j = 0; i < inPrPageCount * 6; i++, j++)
            {

                InProgressOrdersRowControl inProgressOrdersRowControl = new InProgressOrdersRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                inProgressOrdersPanel.Controls.Add(inProgressOrdersRowControl);
                inProgressOrdersRowControl.Location = new Point(0, j * 57);
                inProgressOrdersRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
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

                ordersAdapter = new SqlDataAdapter($"SELECT * FROM Заказы z WHERE z.Статус = 4 ORDER BY Номер DESC", connection);
                ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet);
            }

            for (int i = readyPageCount * 6 - 6, j = 0; i < readyPageCount * 6; i++, j++)
            {

                ReadyOrderRowControl readyOrderRowControl = new ReadyOrderRowControl(ordersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                readyOrdersPanel.Controls.Add(readyOrderRowControl);
                readyOrderRowControl.Location = new Point(0, j * 57);
                readyOrderRowControl.BringToFront();

                if (i + 1 == ordersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        private void to_next_button_Click(object sender, EventArgs e)
        {
            pageCount += 1;
            if (pageCount == page)
                to_next_button.Enabled = false;
            to_previous_button.Enabled = true;
            if (pageCount != 0)
                FillOrders();
            else
            {

            }
        }

        private void to_previous_button_Click(object sender, EventArgs e)
        {
            pageCount -= 1;
            if (pageCount == 1)
                to_previous_button.Enabled = false;
            to_next_button.Enabled = true;

            if (pageCount != 0)
                FillOrders();
            else
            {

            }
        }

        public void LoadOrders()
        {
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                page = dtRecord.Rows.Count / 5;
                if (dtRecord.Rows.Count % 5 > 0)
                    page += 1;
                if (page > 1)
                {
                    to_previous_button.Visible = true;
                    to_next_button.Visible = true;
                    to_previous_button.Enabled = false;
                }
                else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillOrders();
                else
                {

                }
            }
        }

        public void LoadNotVerOrders()
        {
            notVerPage = 0;
            notVerPageCount = 1;
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
                notVerPage = dtRecord.Rows.Count / 6;
                if (dtRecord.Rows.Count % 6 > 0)
                    notVerPage += 1;
                if (notVerPage > 1)
                {
                    to_previous_cust_button.Visible = true;
                    to_next_cust_button.Visible = true;
                    to_previous_cust_button.Enabled = false;
                }
                else
                {
                    to_previous_cust_button.Visible = false;
                    to_next_cust_button.Visible = false;
                }
                if (notVerPage != 0)
                    FillNotVerOrders();
                else
                    notVerifiedOrdersPanel.Controls.Clear();
            }
        }

        public void LoadInPrOrders()
        {
            inPrPage = 0;
            inPrPageCount = 1;
            inProgressOrdersPanel.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 3 ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                inPrPage = dtRecord.Rows.Count / 6;
                if (dtRecord.Rows.Count % 6 > 0)
                    inPrPage += 1;
                if (inPrPage > 1)
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
                if (inPrPage != 0)
                    FillInProgressOrders();
                else
                    inProgressOrdersPanel.Controls.Clear();
            }
        }

        public void LoadReadyOrders()
        {
            readyPage = 0;
            readyPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Заказы z WHERE z.Статус = 4 ORDER BY Номер DESC";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                readyPage = dtRecord.Rows.Count / 6;
                if (dtRecord.Rows.Count % 6 > 0)
                    readyPage += 1;
                if (readyPage > 1)
                {
                    to_previous_ready_button.Visible = true;
                    to_next_ready_button.Visible = true;
                    to_next_ready_button.Enabled = true;
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
                    readyOrdersPanel.Controls.Clear();
            }
        }

        private void to_next_cust_button_Click(object sender, EventArgs e)
        {
            notVerPageCount += 1;
            if (notVerPageCount == notVerPage)
                to_next_cust_button.Enabled = false;
            to_previous_cust_button.Enabled = true;
            if (notVerPageCount != 0)
                FillNotVerOrders();
            else
            {

            }
        }

        private void to_previous_cust_button_Click(object sender, EventArgs e)
        {
            notVerPageCount -= 1;
            if (notVerPageCount == 1)
                to_previous_cust_button.Enabled = false;
            to_next_cust_button.Enabled = true;

            if (notVerPageCount != 0)
                FillNotVerOrders();
            else
            {

            }
        }

        private void to_previous_in_progress_button_Click(object sender, EventArgs e)
        {
            inPrPageCount -= 1;
            if (inPrPageCount == 1)
                to_previous_in_progress_button.Enabled = false;
            to_next_in_progress_button.Enabled = true;

            if (inPrPageCount != 0)
                FillInProgressOrders();
            else
            {

            }
        }

        private void to_next_in_progress_button_Click(object sender, EventArgs e)
        {
            inPrPageCount += 1;
            if (inPrPageCount == inPrPage)
                to_next_in_progress_button.Enabled = false;
            to_previous_in_progress_button.Enabled = true;
            if (inPrPageCount != 0)
                FillInProgressOrders();
            else
            {

            }
        }

        private void to_previous_ready_button_Click(object sender, EventArgs e)
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

        private void notVerifiedOrdersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allOrdersTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
