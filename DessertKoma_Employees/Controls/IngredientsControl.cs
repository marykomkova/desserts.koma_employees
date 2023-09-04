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
    public partial class IngredientsControl : UserControl
    {
        int page;
        int pageCount;
        public IngredientsControl()
        {
            InitializeComponent();
        }

        private void IngredientsControl_Load(object sender, EventArgs e)
        {
            if (Main.role == 3)
            {
                guna2Button3.Visible = false;
            }
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Ингредиенты";
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
                    to_next_button.Enabled = true;
                }
                else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillIngredients();
                else
                {

                }
            }
        }

        public void LoadIngr()
        {
            page = 0;
            pageCount = 1;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM Ингредиенты";
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
                    to_next_button.Enabled = true;
                    to_previous_button.Enabled = false;
                }
                else
                {
                    to_previous_button.Visible = false;
                    to_next_button.Visible = false;
                }
                if (page != 0)
                    FillIngredients();
                else
                {

                }
            }
        }

        private void FillIngredients()
        {
            ingredientsPanel.Controls.Clear();
            SqlDataAdapter ingredientsAdapter;
            DataSet ingredientsDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ingredientsAdapter = new SqlDataAdapter($"SELECT i.Номер, i.Название, i.Количество, i.Стоимость, e.Название as Единица " +
                    $"FROM Ингредиенты i JOIN ЕдиницыИзмерения e ON i.ЕдиницаИзмерения = e.Номер", connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
            }

            for (int i = pageCount * 6 - 6, j = 0; i < pageCount * 6; i++, j++)
            {

                IngredientRowControl ingredientRowControl = new IngredientRowControl(ingredientsDataSet.Tables[0].Rows[i]["Номер"].ToString(), this);
                ingredientsPanel.Controls.Add(ingredientRowControl);
                ingredientRowControl.Location = new Point(0, j * 65);
                ingredientRowControl.BringToFront();

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
                FillIngredients();
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
                FillIngredients();
            else
            {

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddIngredientControl ingredientControl = new AddIngredientControl(this);
            Controls.Add(ingredientControl);
            ingredientControl.Location = new Point(100, 50);
            ingredientControl.BringToFront();
        }

        private void ingredientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
