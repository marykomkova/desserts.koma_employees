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
    public partial class DessertsInOrderControl : UserControl
    {
        int page;
        int pageCount;
        string id;
        public DessertsInOrderControl(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void DessertsInOrderControl_Load(object sender, EventArgs e)
        {
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM ДесертыВЗаказе d WHERE d.Заказ = {id}";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                page = dtRecord.Rows.Count / 6;
                if (dtRecord.Rows.Count % 6 > 0)
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
                    FillDesserts();
                else
                {

                }
            }
        }

        private void FillDesserts()
        {
            ordersPanel.Controls.Clear();
            SqlDataAdapter ingredientsAdapter;
            DataSet ingredientsDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ingredientsAdapter = new SqlDataAdapter($"SELECT * FROM ДесертыВЗаказе d WHERE d.Заказ = {id}", connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
            }

            for (int i = pageCount * 6 - 6, j = 0; i < pageCount * 6; i++, j++)
            {

                DessertInOrderRowControl dessertInOrderRowControl = new DessertInOrderRowControl(ingredientsDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                ordersPanel.Controls.Add(dessertInOrderRowControl);
                dessertInOrderRowControl.Location = new Point(0, j * 42);
                dessertInOrderRowControl.BringToFront();

                if (i + 1 == ingredientsDataSet.Tables[0].Rows.Count)
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
                FillDesserts();
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
                FillDesserts();
            else
            {

            }
        }

        public void LoadDesserts()
        {
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM ДесертыВЗаказе d WHERE d.Заказ = {id}";
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                page = dtRecord.Rows.Count / 6;
                if (dtRecord.Rows.Count % 6 > 0)
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
                    FillDesserts();
                else
                {

                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
