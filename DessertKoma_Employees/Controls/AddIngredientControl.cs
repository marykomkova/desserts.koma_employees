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
    public partial class AddIngredientControl : UserControl
    {
        IngredientsControl ingredientsControl;
        public AddIngredientControl(IngredientsControl control)
        {
            InitializeComponent();
            ingredientsControl = control;
        }

        private static int AddIngredient(string title, double count, double cost, int amount)
        {
            string sqlExpression = "sp_InsertIngredient";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@Название",
                    Value = title
                };
                command.Parameters.Add(titleParam);
                SqlParameter countParam = new SqlParameter
                {
                    ParameterName = "@Количество",
                    Value = count
                };
                command.Parameters.Add(countParam);
                SqlParameter amountParam = new SqlParameter
                {
                    ParameterName = "@ЕдиницаИзмерения",
                    Value = amount
                };
                command.Parameters.Add(amountParam);
                SqlParameter costParam = new SqlParameter
                {
                    ParameterName = "@Стоимость",
                    Value = cost
                };
                command.Parameters.Add(costParam);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void amountComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void AddIngredientControl_Load(object sender, EventArgs e)
        {
            единицыИзмеренияTableAdapter.Fill(dessertsKomaDataSet.ЕдиницыИзмерения);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            if (titleTextBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели название";
                errorLabel.Visible = true;
                titleTextBox.BorderColor = Color.Red;
                return;
            }
            else if (costTextBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели стоимость";
                errorLabel.Visible = true;
                costTextBox.BorderColor = Color.Red;
                return;
            }
            else if (countTextBox.Text.Length == 0)
            {
                errorLabel.Text = "!Вы не ввели количество";
                errorLabel.Visible = true;
                countTextBox.BorderColor = Color.Red;
                return;
            }
            else
            {
                SqlDataAdapter desAdapter;
                DataSet desDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    desAdapter = new SqlDataAdapter($"SELECT * FROM ЕдиницыИзмерения WHERE Название = '{amountComboBox.Text}'", connection);
                    desDataSet = new DataSet();
                    desAdapter.Fill(desDataSet);
                }

                if (desDataSet.Tables[0].Rows.Count == 0)
                {
                    errorLabel.Text = "!Вы не выбрали единицу измерения либо такой не существует";
                    errorLabel.Visible = true;
                    return;
                }

                double number = 0;
                if (!double.TryParse(costTextBox.Text, out number))
                {
                    errorLabel.Text = "!Необходимо ввести число";
                    costTextBox.BorderColor = Color.Red;
                    errorLabel.Visible = true;
                    return;
                }
                if (costTextBox.Text.Contains(',') && (costTextBox.Text[costTextBox.Text.Length - 2] != ',' && costTextBox.Text[costTextBox.Text.Length - 3] != ','))
                {
                    errorLabel.Text = "!Допускается до двух цифр после запятой";
                    costTextBox.BorderColor = Color.Red;
                    errorLabel.Visible = true;
                    return;
                } 

                double number2 = 0;
                if (!double.TryParse(countTextBox.Text, out number2))
                {
                    errorLabel.Text = "!Необходимо ввести число";
                    countTextBox.BorderColor = Color.Red;
                    errorLabel.Visible = true;
                    return;
                }
                if (countTextBox.Text.Contains(',') && countTextBox.Text[countTextBox.Text.Length - 2] != ',')
                {
                    errorLabel.Text = "!Допускается одна цифра после запятой";
                    countTextBox.BorderColor = Color.Red;
                    errorLabel.Visible = true;
                    return;
                } 

                bool can = true;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    string sqlExpression = $"SELECT * FROM Ингредиенты WHERE Название='{titleTextBox.Text}'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            can = false;
                        }
                    }
                    reader.Close();
                    if (!can)
                    {
                        errorLabel.Text = "!Ингредиент с таким названием уже существует";
                        errorLabel.Visible = true;
                        titleTextBox.BorderColor = Color.Red;
                        return;
                    }

                    AddIngredient(titleTextBox.Text, Convert.ToDouble(countTextBox.Text), Convert.ToDouble(costTextBox.Text), Convert.ToInt32(amountComboBox.SelectedValue));
                    ingredientsControl.LoadIngr();
                    Hide();
                }
            }
        }
    }
}
