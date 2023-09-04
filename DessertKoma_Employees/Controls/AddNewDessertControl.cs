using DessertKoma_Employees.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class AddNewDessertControl : UserControl
    {
        public bool ph;
        public List<int> ingredients;
        public List<double> counts;
        public List<double> costs;
        ChangePhotoControl changePhotoControl;
        ChangeIngredientsInNewDessertControl changeIngredientsInNewDessertControl;
        public AddNewDessertControl()
        {
            InitializeComponent();
            ph = false; 
            changeIngredientsInNewDessertControl = new ChangeIngredientsInNewDessertControl(this);
            ingredients = new List<int>();
            counts = new List<double>();
            costs = new List<double>();
            changePhotoControl = new ChangePhotoControl("newDessert", this);
            Controls.Add(changePhotoControl);
            changePhotoControl.Hide();
            changePhotoControl.Location = new Point(350, 200);
            changePhotoControl.BringToFront();
        }

        private void desPic_MouseHover(object sender, EventArgs e)
        {
            if (!changePhotoControl.getB())
            {
                error_label3.Visible = false;
                changePhotoControl.Show();
                changePhotoControl.setB(true);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void FillIngredients()
        {
            ingredientsListBox.Items.Clear();
            for (int i = 0; i < ingredients.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"SELECT * FROM Ингредиенты WHERE Номер={ingredients[i]}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ingredientsListBox.Items.Add(reader.GetString(1));
                        }
                    }
                    reader.Close();
                }
            }

            double cost = 0;
            for (int i = 0; i < costs.Count; i++)
            {
                cost += costs[i];
            }

            if (cost != 0)
            {
                double otherCost = cost * 50 / 100;
                double m = (cost + otherCost) * 60 / 100;
                double result = Math.Round(cost + otherCost + m, 0);

                if (result % 10 < 5)
                {
                    if (result % 5 < 3)
                    {
                        if (result > 100)
                            result = Math.Round(result, -1);
                        else
                            result = Math.Round(result);
                    }
                    else
                    {
                        result = (int)(result / 10) * 10 + 5;
                    }
                }
                else
                {
                    if (result % 5 > 2)
                    {
                        if (result > 100)
                            result = Math.Round(result, -1);
                        else
                            result = Math.Round(result);
                    }
                    else
                    {
                        result = (int)(result / 10) * 10 + 5;
                    }
                }

                costLabelValue.Text = result.ToString() + " руб.";
            }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
            error_label3.Visible = false;

            int number = 0;
            if (!int.TryParse(amountTextBox.Text, out number))
            {
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
            }
            else if (amountTextBox.Text.Contains(".") || amountTextBox.Text.Contains(","))
            {
                error_label.Text = "!Число должно быть целым";
                error_label.Visible = true;
            } else if (Convert.ToInt32(amountTextBox.Text) <= 0)
            {
                error_label.Text = "!Число должно быть > 0";
                error_label.Visible = true;
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (!changeIngredientsInNewDessertControl.b)
            {
                Controls.Add(changeIngredientsInNewDessertControl);
                changeIngredientsInNewDessertControl.Location = new Point(0, 0);
                changeIngredientsInNewDessertControl.BringToFront();
            } else
            {
                changeIngredientsInNewDessertControl.Show();
            }
            
            if (ingredients.Count == 0)
                changeIngredientsInNewDessertControl.noIngredientsPanel.Visible = true;
            else
                changeIngredientsInNewDessertControl.noIngredientsPanel.Visible = false;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label3.Visible = false;
        }

        private void add_new_dessert_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            double number = 0;
            if (titleTextBox.Text.Length == 0 || amountTextBox.Text.Length == 0)
            {
                error_label3.Text = "!Не все поля заполнены";
                error_label3.Visible = true;
                return;
            }
            else if (!ph)
            {
                error_label3.Text = "!Изображение не добавлено";
                error_label3.Visible = true;
                return;
            }
            else if (!double.TryParse(amountTextBox.Text, out number))
            {
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
                return;
            }
            else if (amountTextBox.Text.Contains(".") || amountTextBox.Text.Contains(","))
            {
                error_label.Text = "!Число должно быть целым";
                error_label.Visible = true;
                return;
            }
            else if (ingredients.Count == 0)
            {
                error_label3.Text = "!Вы не добавили ингредиенты";
                error_label3.Visible = true;
                return;
            }
            long t = 0;
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sqlExpr = $"SELECT * FROM ТипыДесертов WHERE Название='{Main.dessertType}'";
                SqlCommand command = new SqlCommand(sqlExpr, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        t = reader.GetInt64(0);
                    }
                }
                reader.Close();
            }

            int img = Main.AddImage(changePhotoControl.getNewFileName());
            string sqlExpression = "sp_InsertDessert";

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@Название",
                    Value = titleTextBox.Text
                };
                command.Parameters.Add(titleParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@Тип",
                    Value = t
                };
                command.Parameters.Add(typeParam);
                SqlParameter imageParam = new SqlParameter
                {
                    ParameterName = "@Изображение",
                    Value = img
                };
                command.Parameters.Add(imageParam);
                SqlParameter countParam = new SqlParameter
                {
                    ParameterName = "@Количество",
                    Value = Convert.ToInt32(amountTextBox.Text)
                };
                command.Parameters.Add(countParam);
                id = Convert.ToInt32(command.ExecuteScalar());
            }

            for (int i = 0; i < ingredients.Count; i++)
            {
                sqlExpression = "sp_InsertIngredientInDessert";
                int ingr = i;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter dessertParam = new SqlParameter
                    {
                        ParameterName = "@Десерт",
                        Value = id
                    };
                    command.Parameters.Add(dessertParam);
                    SqlParameter ingredientParam = new SqlParameter
                    {
                        ParameterName = "@Ингредиент",
                        Value = ingredients[ingr]
                    };
                    command.Parameters.Add(ingredientParam);
                    SqlParameter countParam = new SqlParameter
                    {
                        ParameterName = "@Количество",
                        Value = counts[ingr]
                    };
                    command.Parameters.Add(countParam);
                    command.ExecuteScalar();
                }
                changeIngredientsInNewDessertControl.ingCount = 0; Main.dessertCount = 0;
            }
            Main.FillType();
            Main.FillDessert();
            Hide();
        }

        private void desPic_Click(object sender, EventArgs e)
        {
            if (changePhotoControl.getB())
                changePhotoControl.Hide();
            changePhotoControl.setB(false);
        }

        private void AddNewDessertControl_Load(object sender, EventArgs e)
        {

        }
    }
}
