using DessertKoma_Employees.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class ChangeIngredientsInNewDessertControl : UserControl
    {
        public bool b;
        public int ingCount;
        public AddNewDessertControl addNewDessertControl;
        public ChangeIngredientsInNewDessertControl(AddNewDessertControl obj)
        {
            InitializeComponent();
            addNewDessertControl = obj;
            b = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (addNewDessertControl.ingredients.Count > 0)
            {
                addNewDessertControl.error_label3.Visible = false;
            }
            addNewDessertControl.FillIngredients();
            Hide();
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            error_label.Visible = false;
            double number = 0;
            bool can = true;
            if (!double.TryParse(countTextBox.Text, out number))
            {
                can = false;
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
            }
            else if (countTextBox.Text.Contains('.') && (countTextBox.Text[countTextBox.Text.Length - 2] != '.' || countTextBox.Text[countTextBox.Text.Length - 3] != '.'))
            {
                can = false;
                error_label.Text = "!Допускается до двух цифр после запятой";
                error_label.Visible = true;
            }
            if (can)
            {
                costAmountLabel.Text = Math.Round((Convert.ToDouble(Main.ingredientsDataSet.Tables[0].Rows[0]["Стоимость"]) / Convert.ToDouble(Main.ingredientsDataSet.Tables[0].Rows[0]["Количество"]) * Convert.ToDouble(countTextBox.Text)), 2).ToString();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            double number = 0;
            if (!double.TryParse(countTextBox.Text, out number))
            {
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
                return;
            }
            else if (countTextBox.Text.Contains('.') && (countTextBox.Text[countTextBox.Text.Length - 2] != '.' || countTextBox.Text[countTextBox.Text.Length - 3] != '.'))
            {
                error_label.Text = "!Допускается до двух цифр после запятой";
                error_label.Visible = true;
                return;
            }
            int c = addNewDessertControl.ingredients.IndexOf(Convert.ToInt32(idLabel.Text));
            addNewDessertControl.counts[c] = Convert.ToDouble(countTextBox.Text);
            addNewDessertControl.costs[c] = Convert.ToDouble(Math.Round(Convert.ToDouble(costAmountLabel.Text.Replace(" руб.", "")), 2));
            savedLabel.Visible = true;
        }

        public void FillIngredient()
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sqlExpression = $"select * from Ингредиенты i where i.Номер = {addNewDessertControl.ingredients[ingCount]}";
                Main.ingredientsAdapter = new SqlDataAdapter(sqlExpression, connection);
                Main.ingredientsDataSet = new DataSet();
                Main.ingredientsAdapter.Fill(Main.ingredientsDataSet);

                sqlExpression = $"select * from ЕдиницыИзмерения e join Ингредиенты i on i.ЕдиницаИзмерения = e.Номер where i.Номер = {Main.ingredientsDataSet.Tables[0].Rows[0]["Номер"]}";
                Main.amountAdapter = new SqlDataAdapter(sqlExpression, connection);
                Main.amountDataSet = new DataSet();
                Main.amountAdapter.Fill(Main.amountDataSet);
            }
            IngredientNameLabel.Text = Main.ingredientsDataSet.Tables[0].Rows[0]["Название"].ToString();
            countTextBox.Text = addNewDessertControl.counts[ingCount].ToString();
            idLabel.Text = addNewDessertControl.ingredients[ingCount].ToString();
            amountLabel.Text = $"({Main.amountDataSet.Tables[0].Rows[0]["Название"]})";
            costAmountLabel.Text = Math.Round((Convert.ToDouble(Main.ingredientsDataSet.Tables[0].Rows[0]["Стоимость"]) / Convert.ToDouble(Main.ingredientsDataSet.Tables[0].Rows[0]["Количество"]) * addNewDessertControl.counts[ingCount]), 2).ToString();

            if (ingCount == 0)
            {
                to_first_button.Enabled = false;
                to_previous_button.Enabled = false;
            }
            else
            {
                to_first_button.Enabled = true;
                to_previous_button.Enabled = true;
            }

            if (ingCount == addNewDessertControl.ingredients.Count - 1)
            {
                last_button.Enabled = false;
                to_next_button.Enabled = false;
            }
            else
            {
                last_button.Enabled = true;
                to_next_button.Enabled = true;
            }

            if (to_first_button.Enabled == false && to_previous_button.Enabled == false &&
                        last_button.Enabled == false && to_next_button.Enabled == false)
                onlyIngredientLabel.Visible = true;
            else
                onlyIngredientLabel.Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int c = addNewDessertControl.ingredients.IndexOf(Convert.ToInt32(idLabel.Text));
            addNewDessertControl.ingredients.RemoveAt(c);
            addNewDessertControl.counts.RemoveAt(c);
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand($"DELETE FROM ИнгредиентыВДесерте WHERE Номер={idLabel.Text}", connection);
                command2.ExecuteNonQuery();
            }
            ingCount = 0;
            if (addNewDessertControl.ingredients.Count == 0)
                noIngredientsPanel.Visible = true;
            else
                FillIngredient();
        }

        private void ChangeIngredientsInNewDessertControl_Load(object sender, EventArgs e)
        {
            ingCount = 0;
            if (addNewDessertControl.ingredients.Count > 0)
                FillIngredient();
            else
                noIngredientsPanel.Visible = true;

            savedLabel.Visible = false;
            b = true;
        }

        private void to_first_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            ingCount = 0;
            FillIngredient();
        }

        private void to_previous_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (ingCount > 0)
                ingCount -= 1;
            else
                ingCount = addNewDessertControl.counts.Count - 1;
            FillIngredient();
        }

        private void to_next_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (ingCount < addNewDessertControl.counts.Count - 1)
                ingCount += 1;
            else
                ingCount = 0;
            FillIngredient();
        }

        private void last_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            ingCount = addNewDessertControl.counts.Count - 1;
            FillIngredient();
        }

        private void add_new_dessert_button_Click(object sender, EventArgs e)
        {
            AddIngredientInNewDessertControl addIngredientInNewDessertControl = new AddIngredientInNewDessertControl(this);
            Controls.Add(addIngredientInNewDessertControl);
            addIngredientInNewDessertControl.Location = new Point(0, 0);
            addIngredientInNewDessertControl.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddIngredientInNewDessertControl addIngredientInNewDessertControl = new AddIngredientInNewDessertControl(this);
            Controls.Add(addIngredientInNewDessertControl);
            addIngredientInNewDessertControl.Location = new Point(0, 0);
            addIngredientInNewDessertControl.BringToFront();
        }
    }
}
