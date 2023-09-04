using DessertKoma_Employees.Forms;
using Guna.UI2.WinForms;
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
    public partial class UsersControl : UserControl
    {
        int page;
        int pageCount;
        int custPage;
        int custPageCount;
        int reqPage;
        int reqPageCount;
        public UsersControl()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dessertsKomaDataSet);

        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            page = 0;
            pageCount = 1;
            custPage = 0;
            custPageCount = 1;
            reqPage = 0;
            reqPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль != 4 and Подтверждение != 0";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                page = dtRecord.Rows.Count / 4;
                if (dtRecord.Rows.Count % 4 > 0)
                    page += 1;
                if (page > 1)
                {
                    to_previous_button.Visible = true;
                    to_next_button.Visible = true;
                    to_previous_button.Enabled = false;
                } else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillEmployees(employeesPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль != 4 and Подтверждение != 0", pageCount);
                else
                {

                }
            }

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                custPage = dtRecord.Rows.Count / 4;
                if (dtRecord.Rows.Count % 4 > 0)
                    custPage += 1;
                if (custPage > 1)
                {
                    to_previous_cust_button.Visible = true;
                    to_next_cust_button.Visible = true;
                    to_previous_cust_button.Enabled = false;
                } else
                {
                    to_previous_cust_button.Visible = false;
                    to_next_cust_button.Visible = false;
                }
                if (custPage != 0)
                    FillEmployees(customersPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0", custPageCount);
                else
                {

                }
            }

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT p.Логин, p.Имя, p.Подтверждение as Подтверждение, p.НомерТелефона " +
                    "FROM Пользователи p WHERE p.Подтверждение = 0";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                reqPage = dtRecord.Rows.Count / 4;
                if (dtRecord.Rows.Count % 4 > 0)
                    reqPage += 1;
                if (reqPage > 1)
                {
                    to_previous_req_button.Visible = true;
                    to_next_req_button.Visible = true;
                    to_previous_req_button.Enabled = false;
                }
                else
                {
                    to_previous_req_button.Visible = false;
                    to_next_req_button.Visible = false;
                }
                if (reqPage != 0)
                    FillRequests(); 
                else
                {

                }
            }
        }

        public void LoadEmplCntrl()
        {
            custPage = 0;
            custPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, p.Подтверждение as Подтверждение, p.НомерТелефона " +
                    "FROM Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                custPage = dtRecord.Rows.Count / 4;
                if (dtRecord.Rows.Count % 4 > 0)
                    custPage += 1;
                if (custPage > 1)
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
                if (custPage != 0)
                    FillEmployees(customersPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0", custPageCount);
                else
                {

                }
            }


            page = 0;
            pageCount = 1;
            using (SqlConnection connection2 = new SqlConnection(Main.connectionString))
            {
                connection2.Open();
                string sql2 = "SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, p.Подтверждение as Подтверждение, p.НомерТелефона " +
                    "FROM Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль != 4 and Подтверждение != 0";
                SqlCommand sqlCmd2 = new SqlCommand
                {
                    Connection = connection2,
                    CommandType = CommandType.Text,
                    CommandText = sql2
                };
                SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd2);

                DataTable dtRecord2 = new DataTable();
                sqlDataAdap2.Fill(dtRecord2);
                page = dtRecord2.Rows.Count / 4;
                if (dtRecord2.Rows.Count % 4 > 0)
                    page += 1;
                if (page > 1)
                {
                    to_previous_button.Visible = true;
                    to_next_button.Visible = true;
                    to_next_button.Enabled = true;
                    to_previous_button.Enabled = false;
                }
                else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillEmployees(employeesPanel, sql2, pageCount); 
                else
                {

                }
            }
        }

        private void FillEmployees(Guna2Panel panel, string request, int pageC)
        {
            panel.Controls.Clear();
            SqlDataAdapter usersAdapter;
            DataSet usersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                usersAdapter = new SqlDataAdapter(request, connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet);
            }

            for (int i = pageC * 4 - 4, j = 0; i < pageC * 4; i++, j++)
            {
                
                UserRowControl userRowControl = new UserRowControl(usersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                panel.Controls.Add(userRowControl);
                userRowControl.Location = new Point(0, j*90);
                userRowControl.BringToFront();

                if (i + 1 == usersDataSet.Tables[0].Rows.Count)
                {
                    return;
                }
            }
        }

        public void LoadReqCntrl()
        {
            reqPage = 0;
            reqPageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT p.Логин, p.Имя, p.Подтверждение as Подтверждение, p.НомерТелефона " +
                    "FROM Пользователи p WHERE p.Подтверждение = 0";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                reqPage = dtRecord.Rows.Count / 4;
                if (dtRecord.Rows.Count % 4 > 0)
                    reqPage += 1;
                if (reqPage > 1)
                {
                    to_previous_req_button.Visible = true;
                    to_next_req_button.Visible = true;
                    to_previous_req_button.Enabled = false;
                }
                else
                {
                    to_previous_req_button.Visible = false;
                    to_next_req_button.Visible = false;
                }
                if (reqPage != 0) 
                    FillRequests();
                else
                {

                }
            }
        }

        private void FillRequests()
        {
            requestsPanel.Controls.Clear();
            SqlDataAdapter usersAdapter;
            DataSet usersDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                usersAdapter = new SqlDataAdapter($"SELECT p.Номер, p.Логин, p.Имя, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p WHERE p.Подтверждение = 0", connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet);
            }

            for (int i = reqPageCount * 4 - 4, j = 0; i < reqPageCount * 4; i++, j++)
            {

                RequestRowControl requestRowControl = new RequestRowControl(usersDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                requestsPanel.Controls.Add(requestRowControl);
                requestRowControl.Location = new Point(0, j * 90);
                requestRowControl.BringToFront();

                if (i + 1 == usersDataSet.Tables[0].Rows.Count)
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
                FillEmployees(employeesPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль != 4 and Подтверждение != 0", pageCount);
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
                FillEmployees(employeesPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль != 4 and Подтверждение != 0", pageCount);
            else
            {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void employeesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void requestsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void to_previous_cust_button_Click(object sender, EventArgs e)
        {
            custPageCount -= 1;
            if (custPageCount == 1)
                to_previous_cust_button.Enabled = false;
            to_next_cust_button.Enabled = true;
            if (custPageCount != 0)
                FillEmployees(customersPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0", custPageCount);
            else
            {

            }
        }

        private void to_next_cust_button_Click(object sender, EventArgs e)
        {
            custPageCount += 1;
            if (custPageCount == custPage)
                to_next_cust_button.Enabled = false;
            to_previous_cust_button.Enabled = true;
            if (custPageCount != 0)
                FillEmployees(customersPanel, $"SELECT p.Номер, p.Логин, p.Имя, r.Название as Роль, " +
                    $"p.Подтверждение as Подтверждение, p.НомерТелефона as [Номер телефона], p.Изображение FROM " +
                    $"Пользователи p JOIN Роли r ON p.Роль = r.Номер WHERE p.Роль = 4 and Подтверждение != 0", custPageCount);
            else
            {

            }
        }

        private void to_previous_req_button_Click(object sender, EventArgs e)
        {
            reqPageCount -= 1;
            if (reqPageCount == 1)
                to_previous_req_button.Enabled = false;
            to_next_req_button.Enabled = true;
            FillRequests();
        }

        private void to_next_req_button_Click(object sender, EventArgs e)
        {
            reqPageCount += 1;
            if (reqPageCount == reqPage)
                to_next_req_button.Enabled = false;
            to_previous_req_button.Enabled = true;
            FillRequests();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddUserControl addUserControl = new AddUserControl(this);
            Controls.Add(addUserControl);
            addUserControl.Location = new Point(100, 50);
            addUserControl.BringToFront();
        }
    }
}
