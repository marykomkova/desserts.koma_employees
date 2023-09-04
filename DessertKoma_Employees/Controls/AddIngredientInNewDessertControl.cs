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
    public partial class AddIngredientInNewDessertControl : UserControl
    {
        long amount;
        double count;
        double cost;
        ChangeIngredientsInNewDessertControl changeIngredientsInNewDessertControl;
        public AddIngredientInNewDessertControl(ChangeIngredientsInNewDessertControl obj)
        {
            InitializeComponent();
            changeIngredientsInNewDessertControl = obj;
        }

        private void AddIngredientInNewDessertControl_Load(object sender, EventArgs e)
        {
            error_label.Visible = false;
            countTextBox.Enabled = false;
            amountLabel.Visible = false;
            ингредиентыTableAdapter.Fill(dessertsKomaDataSet.Ингредиенты);
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sqlExpression = $"SELECT * FROM Ингредиенты WHERE Номер={titleComboBox.SelectedValue}";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = reader.GetDouble(2);
                        cost = reader.GetDouble(4);
                        amount = reader.GetInt64(3);
                    }
                }
                reader.Close();

                sqlExpression = $"SELECT * FROM ЕдиницыИзмерения WHERE Номер={amount}";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        amountLabel.Text = $"({reader.GetString(1)})";
                    }
                }
                reader.Close();
            }

            countTextBox.Enabled = true;
            amountLabel.Visible = true;
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;

            bool can = true;
            double number = 0;
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
                costAmountLabel.Text = Math.Round(((cost / count) * Convert.ToDouble(countTextBox.Text)), 2).ToString();
        }

        private void titleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sqlExpression = $"SELECT * FROM Ингредиенты WHERE Номер={titleComboBox.SelectedValue}";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = reader.GetDouble(2);
                        cost = reader.GetDouble(4);
                        amount = reader.GetInt64(3);
                    }
                }
                reader.Close();

                sqlExpression = $"SELECT * FROM ЕдиницыИзмерения WHERE Номер={amount}";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        amountLabel.Text = $"({reader.GetString(1)})";
                    }
                }
                reader.Close();
            }

            countTextBox.Enabled = true;
            amountLabel.Visible = true;
        }

        private void add_new_dessert_button_Click(object sender, EventArgs e)
        {
            if (!error_label.Visible)
            {
                if (countTextBox.Text == "")
                {
                    error_label.Text = "Вы не ввели количество!";
                    error_label.Visible = true;
                    return;
                }

                if (changeIngredientsInNewDessertControl.addNewDessertControl.ingredients.Contains(Convert.ToInt32(titleComboBox.SelectedValue)))
                {
                    int i = changeIngredientsInNewDessertControl.addNewDessertControl.ingredients.IndexOf(Convert.ToInt32(titleComboBox.SelectedValue));
                    changeIngredientsInNewDessertControl.addNewDessertControl.counts[i] =
                        changeIngredientsInNewDessertControl.addNewDessertControl.counts[i] + Math.Round(Convert.ToDouble(countTextBox.Text), 2);
                    changeIngredientsInNewDessertControl.addNewDessertControl.costs[i] =
                        changeIngredientsInNewDessertControl.addNewDessertControl.costs[i] + Math.Round(Convert.ToDouble(costAmountLabel.Text.Replace(" руб.", "")), 2);
                }
                else
                {
                    changeIngredientsInNewDessertControl.addNewDessertControl.ingredients.Add(Convert.ToInt32(titleComboBox.SelectedValue));
                    changeIngredientsInNewDessertControl.addNewDessertControl.counts.Add(Math.Round(Convert.ToDouble(countTextBox.Text), 2));
                    changeIngredientsInNewDessertControl.addNewDessertControl.costs.Add(Math.Round(Convert.ToDouble(costAmountLabel.Text.Replace(" руб.", "")), 2));
                }
                changeIngredientsInNewDessertControl.ingCount = 0;
                changeIngredientsInNewDessertControl.noIngredientsPanel.Visible = false;
                changeIngredientsInNewDessertControl.FillIngredient();
                Hide();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
