using DessertKoma_Employees.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class ChangeIngredientsControl : UserControl
    {
        public int ingCount;
        public ChangeIngredientsControl()
        {
            InitializeComponent();
            ingCount = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (noIngredientsPanel.Visible)
            {
                label1.Visible = true;
                ingCount = 0;
            } else
            {
                Main.dessertControl.FillIngredients();
                SqlDataAdapter dessertsAdapter;
                DataSet dessertsDataSet;
                dessertsAdapter = new SqlDataAdapter("SELECT * FROM Десерты WHERE Номер = " + Main.dessertControl.idLabel.Text, Main.connectionString);
                dessertsDataSet = new DataSet();
                dessertsAdapter.Fill(dessertsDataSet);

                Main.dessertControl.costLabel.Text = dessertsDataSet.Tables[0].Rows[0]["Стоимость"].ToString() + " руб.";
                Hide();
            }
        }

        private void ChangeIngredientsControl_Load(object sender, EventArgs e)
        {
            FillIngredient();
            savedLabel.Visible = false;
        }

        public void FillIngredient()
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                string sqlExpression = $"SELECT * FROM ИнгредиентыВДесерте i JOIN Десерты d ON d.Номер = i.Десерт WHERE d.Номер = {Main.dessertControl.idLabel.Text}";
                Main.dessertControl.setIngredientsInDessertAdapter(new SqlDataAdapter(sqlExpression, connection));
                Main.dessertControl.setIngredientsInDessertDataSet(new DataSet());
                Main.dessertControl.fillIngredientsInDessertAdapter(Main.dessertControl.getIngredientsInDessertDataSet());

                if (DessertsControl.ingredientsInDessertDataSet.Tables[0].Rows.Count != 0)
                {
                    sqlExpression = $"SELECT * FROM Ингредиенты i WHERE i.Номер = {Main.dessertControl.getIngredientsInDessertDataSet().Tables[0].Rows[ingCount]["Ингредиент"]}";
                    Main.dessertControl.setIngredientsAdapter(new SqlDataAdapter(sqlExpression, connection));
                    Main.dessertControl.setIngredientsDataSet(new DataSet());
                    Main.dessertControl.fillIngredientsAdapter(Main.dessertControl.getIngredientsDataSet());

                    SqlDataAdapter amountAdapter;
                    DataSet amountDataSet;

                    sqlExpression = $"SELECT * FROM ЕдиницыИзмерения e JOIN Ингредиенты i ON i.ЕдиницаИзмерения = e.Номер WHERE i.ЕдиницаИзмерения = {Main.dessertControl.getIngredientsDataSet().Tables[0].Rows[0]["ЕдиницаИзмерения"]}";
                    amountAdapter = new SqlDataAdapter(sqlExpression, connection);
                    amountDataSet = new DataSet();
                    amountAdapter.Fill(amountDataSet);

                    IngredientNameLabel.Text = Main.dessertControl.getIngredientsDataSet().Tables[0].Rows[0]["Название"].ToString();
                    countTextBox.Text = Main.dessertControl.getIngredientsInDessertDataSet().Tables[0].Rows[ingCount]["Количество"].ToString();
                    idLabel.Text = Main.dessertControl.getIngredientsInDessertDataSet().Tables[0].Rows[ingCount]["Номер"].ToString();
                    amountLabel.Text = $"({amountDataSet.Tables[0].Rows[0]["Название"]})";
                    costAmountLabel.Text = Math.Round((Convert.ToDouble(Main.dessertControl.getIngredientsDataSet().Tables[0].Rows[0]["Стоимость"]) / Convert.ToDouble(Main.dessertControl.getIngredientsDataSet().Tables[0].Rows[0]["Количество"]) *
                        Convert.ToDouble(Main.dessertControl.getIngredientsInDessertDataSet().Tables[0].Rows[ingCount]["Количество"])),2).ToString();

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

                    if (ingCount == DessertsControl.ingredientsInDessertDataSet.Tables[0].Rows.Count - 1)
                    {
                        to_last_button.Enabled = false;
                        to_next_button.Enabled = false;
                    }
                    else
                    {
                        to_last_button.Enabled = true;
                        to_next_button.Enabled = true;
                    }

                    if (to_first_button.Enabled == false && to_previous_button.Enabled == false && 
                        to_last_button.Enabled == false && to_next_button.Enabled == false)
                        onlyIngredientLabel.Visible = true;
                    else
                        onlyIngredientLabel.Visible = false;
                }
                else
                {
                    noIngredientsPanel.Visible = true;
                    label1.Visible = false;
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            double number = 0;
            bool can = true;
            if (!double.TryParse(countTextBox.Text, out number))
            {
                can = false;
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
            }
            else if (countTextBox.Text.Contains(",") && (countTextBox.Text[countTextBox.Text.Length - 2] != ','))
            {
                can = false;
                error_label.Text = "!Допускается одна цифра после запятой";
                error_label.Visible = true;
            }
            if (can)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"UPDATE ИнгредиентыВДесерте SET Количество={countTextBox.Text.Replace(',', '.')} WHERE Номер={idLabel.Text}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                savedLabel.Visible = true;

                FillIngredient();

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand($"DELETE FROM ИнгредиентыВДесерте WHERE Номер={idLabel.Text}", connection);
                command2.ExecuteNonQuery();
            }
            ingCount = 0;
            FillIngredient();
        }

        public static int getIngredientsCount()
        {
            return DessertsControl.ingredientsInDessertDataSet.Tables[0].Rows.Count;
        }

        private void to_first_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            ingCount = 0;
            FillIngredient();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (ingCount > 0)
                ingCount -= 1;
            else
                ingCount = getIngredientsCount() - 1;
            FillIngredient();
        }

        private void to_next_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (ingCount < getIngredientsCount() - 1)
                ingCount += 1;
            else
                ingCount = 0;
            FillIngredient();
        }

        private void to_last_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            ingCount = getIngredientsCount() - 1;
            FillIngredient();
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
        }

        private void add_new_dessert_button_Click(object sender, EventArgs e)
        {
            AddIngredientInDessertControl addIngredientInDessertControl = new AddIngredientInDessertControl(this);
            this.Controls.Add(addIngredientInDessertControl);
            addIngredientInDessertControl.Location = new Point(0, 0);
            addIngredientInDessertControl.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddIngredientInDessertControl addIngredientInDessertControl = new AddIngredientInDessertControl(this);
            this.Controls.Add(addIngredientInDessertControl);
            addIngredientInDessertControl.Location = new Point(0, 0);
            addIngredientInDessertControl.BringToFront();
        }

        private void noDessertsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
