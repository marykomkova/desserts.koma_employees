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
    public partial class IngredientRowControl : UserControl
    {
        SqlDataAdapter ingredientsAdapter;
        DataSet ingredientsDataSet;
        IngredientsControl ingredientsControl;
        string id;
        public IngredientRowControl(string i, IngredientsControl cntrl)
        {
            InitializeComponent();
            ingredientsControl = cntrl;
            id = i;
        }

        private void IngredientRowControl_Load(object sender, EventArgs e)
        {
            if (Main.role == 3)
            {
                editButton.Visible = false;
                deleteButton.Visible = false;
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ingredientsAdapter = new SqlDataAdapter($"SELECT i.Название, i.Количество, i.Стоимость, e.Название as Единица " +
                    $"FROM Ингредиенты i JOIN ЕдиницыИзмерения e ON i.ЕдиницаИзмерения = e.Номер WHERE i.Номер = {id}", connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
            }
            titleLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Название"].ToString();
            countLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Количество"].ToString();
            costLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Стоимость"].ToString();
            amountLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Единица"].ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            titleTextBox.Text = titleLabel.Text;
            titleTextBox.Visible = true;
            countLabel.Visible = false;
            countTextBox.Text = countLabel.Text;
            countTextBox.Visible = true;
            costTextBox.Visible = true;
            costLabel.Visible = false;
            costTextBox.Text = costLabel.Text;
            amountComboBox.Visible = true;
            amountLabel.Visible = false;
            единицыИзмеренияTableAdapter.Fill(dessertsKomaDataSet.ЕдиницыИзмерения);
            amountComboBox.SelectedItem = amountLabel.Text;
            amountComboBox.Text = amountLabel.Text;
            editButton.Visible = false;
            saveButton.Visible = true;
            closeButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter desAdapter;
            DataSet desDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                desAdapter = new SqlDataAdapter($"SELECT * FROM ИнгредиентыВДесерте WHERE Ингредиент = {id}", connection);
                desDataSet = new DataSet();
                desAdapter.Fill(desDataSet);
            }
            for (int i = desDataSet.Tables[0].Rows.Count - 1; i > 0; i--)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"DELETE FROM ИнгредиентыВДесерте WHERE Номер={desDataSet.Tables[0].Rows[i]["Номер"]}", connection);
                    command.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM Ингредиенты WHERE Номер={id}", connection);
                command.ExecuteNonQuery();
            }
            ingredientsControl.LoadIngr();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = true;
            titleTextBox.Visible = false;
            costLabel.Visible = true;
            costTextBox.Visible = false;
            countLabel.Visible = true;
            countTextBox.Visible = false;
            amountLabel.Visible = true;
            amountComboBox.Visible = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            closeButton.Visible = false;
            error_label.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool title = false;
            bool cost = false;
            bool count = false;
            bool amount = false;
            if (titleTextBox.Text != ingredientsDataSet.Tables[0].Rows[0]["Название"].ToString())
            {
                if (titleTextBox.Text == "")
                {
                    error_label.Text = "Вы не ввели название!";
                    error_label.Visible = true;
                    titleTextBox.BorderColor = Color.Red;
                    return;
                }
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
                            error_label.Text = "!Ингредиент с таким названием уже существует";
                            error_label.Visible = true;
                            titleTextBox.BorderColor = Color.Red;
                            return;
                        }
                    }
                    reader.Close();
                }

               title = true;
            }
            if (costTextBox.Text != ingredientsDataSet.Tables[0].Rows[0]["Стоимость"].ToString())
            {
                double number = 0;
                if (!double.TryParse(costTextBox.Text, out number))
                {
                    error_label.Text = "!Необходимо ввести число";
                    costTextBox.BorderColor = Color.Red;
                    error_label.Visible = true;
                    return;
                }
                if (costTextBox.Text.Contains(',') && (costTextBox.Text[costTextBox.Text.Length - 2] != ',' || costTextBox.Text[costTextBox.Text.Length - 3] != ','))
                {
                    
                } else
                {
                    error_label.Text = "!Допускается до двух цифр после запятой";
                    costTextBox.BorderColor = Color.Red;
                    error_label.Visible = true;
                    return;
                }
                cost = true;
            }
            if (countTextBox.Text != ingredientsDataSet.Tables[0].Rows[0]["Количество"].ToString())
            {
                double number = 0;
                if (!double.TryParse(countTextBox.Text, out number))
                {
                    error_label.Text = "!Необходимо ввести число";
                    countTextBox.BorderColor = Color.Red;
                    error_label.Visible = true;
                    return;
                }
                if (countTextBox.Text.Contains(',') && countTextBox.Text[countTextBox.Text.Length - 2] != ',')
                {
                    error_label.Text = "!Допускается одна цифра после запятой";
                    countTextBox.BorderColor = Color.Red;
                    error_label.Visible = true;
                    return;
                } 
                count = true;
            }
            if (amountComboBox.Text != ingredientsDataSet.Tables[0].Rows[0]["Единица"].ToString())
            {
                SqlDataAdapter amountAdapter;
                DataSet amountDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    amountAdapter = new SqlDataAdapter($"SELECT * FROM ЕдиницыИзмерения WHERE Название = '{amountComboBox.Text}'", connection);
                    amountDataSet = new DataSet();
                    amountAdapter.Fill(amountDataSet);
                }
                if (amountDataSet.Tables[0].Rows.Count == 0)
                {
                    error_label.Text = "Такой единицы изм. не существует!";
                    error_label.Visible = true;
                    return;
                }
                amount = true;
            }
            
            if (amount)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Ингредиенты SET ЕдиницаИзмерения={amountComboBox.SelectedValue} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            if (title)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Ингредиенты SET Название='{titleTextBox.Text}' WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            if (cost)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Ингредиенты SET Стоимость={costTextBox.Text.Replace(',', '.')} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            if (count)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    string sqlExpression = $"UPDATE Ингредиенты SET Количество={countTextBox.Text.Replace(',', '.')} WHERE Номер = {id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                ingredientsAdapter = new SqlDataAdapter($"SELECT i.Название, i.Количество, i.Стоимость, e.Название as Единица " +
                    $"FROM Ингредиенты i JOIN ЕдиницыИзмерения e ON i.ЕдиницаИзмерения = e.Номер WHERE i.Номер = {id}", connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
            }
            titleLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Название"].ToString();
            countLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Количество"].ToString();
            costLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Стоимость"].ToString();
            amountLabel.Text = ingredientsDataSet.Tables[0].Rows[0]["Единица"].ToString(); 
            titleLabel.Visible = true;
            titleTextBox.Visible = false;
            costLabel.Visible = true;
            costTextBox.Visible = false;
            countLabel.Visible = true;
            countTextBox.Visible = false;
            amountLabel.Visible = true;
            amountComboBox.Visible = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            closeButton.Visible = false;
            error_label.Visible = false;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void amountComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            error_label.Visible = false;
            titleTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            costTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            countTextBox.BorderColor = Color.FromArgb(213, 218, 223);
        }
    }
}
