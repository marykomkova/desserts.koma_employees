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
    public partial class AddIngredientInDessertControl : UserControl
    {
        long amount;
        double count;
        double cost;
        ChangeIngredientsControl obj;
        public AddIngredientInDessertControl(ChangeIngredientsControl obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddIngredientInDessertControl_Load(object sender, EventArgs e)
        {
            error_label.Visible = false;
            countTextBox.Enabled = false;
            amountLabel.Visible = false;
            this.ингредиентыTableAdapter.Fill(this.dessertsKomaDataSet.Ингредиенты);
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
            else if (countTextBox.Text.Contains(',') && countTextBox.Text[countTextBox.Text.Length - 2] != ',')
            {
                can = false;
                error_label.Text = "!Допускается одна цифра после запятой";
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
                SqlDataAdapter ingAdapter;
                DataSet ingDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    ingAdapter = new SqlDataAdapter($"SELECT * FROM ИнгредиентыВДесерте WHERE (Ингредиент = {Convert.ToInt64(titleComboBox.SelectedValue)} and Десерт = {Convert.ToInt64(Main.dessertControl.idLabel.Text)})", connection);
                    ingDataSet = new DataSet();
                    ingAdapter.Fill(ingDataSet);
                }
                if (ingDataSet.Tables[0].Rows.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        connection.Open();

                        string sqlExpression = $"UPDATE ИнгредиентыВДесерте SET Количество={(Convert.ToDouble(ingDataSet.Tables[0].Rows[0]["Количество"]) + Convert.ToDouble(countTextBox.Text)).ToString().Replace(',', '.')} WHERE (Ингредиент = {Convert.ToInt64(titleComboBox.SelectedValue)} and Десерт = {Convert.ToInt64(Main.dessertControl.idLabel.Text)})";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                    }
                } else
                {
                    string sqlExpression = "sp_InsertIngredientInDessert";

                    using (SqlConnection connection = new SqlConnection(Main.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.CommandType = CommandType.StoredProcedure;
                        SqlParameter dessertParam = new SqlParameter
                        {
                            ParameterName = "@Десерт",
                            Value = Convert.ToInt32(Main.dessertControl.idLabel.Text)
                        };
                        command.Parameters.Add(dessertParam);
                        SqlParameter ingredientParam = new SqlParameter
                        {
                            ParameterName = "@Ингредиент",
                            Value = Convert.ToInt32(titleComboBox.SelectedValue)
                        };
                        command.Parameters.Add(ingredientParam);
                        SqlParameter countParam = new SqlParameter
                        {
                            ParameterName = "@Количество",
                            Value = countTextBox.Text.Replace(',', '.')
                        };
                        command.Parameters.Add(countParam);
                        command.ExecuteScalar();
                        obj.ingCount = 0;
                    }
                }

                obj.noIngredientsPanel.Visible = false;
                if (ChangeIngredientsControl.getIngredientsCount() < 2)
                    obj.ingCount = 0;
                else
                    obj.ingCount = ChangeIngredientsControl.getIngredientsCount() - 1;
                obj.FillIngredient();
                Hide();
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ингредиентыTableAdapter.Fill(this.dessertsKomaDataSet.Ингредиенты);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
