using DessertKoma_Employees.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class DessertsControl : UserControl
    {
        public Main obj;
        public static SqlDataAdapter ingredientsInDessertAdapter;
        public static DataSet ingredientsInDessertDataSet;
        public static SqlDataAdapter ingredientsAdapter;
        public static DataSet ingredientsDataSet;
        ChangePhotoControl changePhotoControl;
        ChangePhotoControl changePhotoControl2;

        public static bool img;
        public DessertsControl(Main _obj)
        {
            InitializeComponent(); 
            img = false;
            obj = _obj;
        }

        public SqlDataAdapter getIngredientsInDessertAdapter()
        {
            return ingredientsInDessertAdapter;
        }

        public void fillIngredientsInDessertAdapter(DataSet d)
        {
            ingredientsInDessertAdapter.Fill(d);
        }

        public void fillIngredientsAdapter(DataSet d)
        {
            ingredientsAdapter.Fill(d);
        }

        public SqlDataAdapter getIngredientsAdapter()
        {
            return ingredientsAdapter;
        }

        public void setIngredientsInDessertAdapter(SqlDataAdapter d)
        {
            ingredientsInDessertAdapter = d;
        }

        public void setIngredientsAdapter(SqlDataAdapter d)
        {
            ingredientsAdapter = d;
        }

        public DataSet getIngredientsInDessertDataSet()
        {
            return ingredientsInDessertDataSet;
        }

        public DataSet getIngredientsDataSet()
        {
            return ingredientsDataSet;
        }

        public void setIngredientsInDessertDataSet(DataSet d)
        {
            ingredientsInDessertDataSet = d;
        }

        public void setIngredientsDataSet(DataSet d)
        {
            ingredientsDataSet = d;
        }

        private void changeDessertTypeButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter typeAdapter;
            DataSet typeDataSet;
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            ChangeDessertTypeControl changeDessertsTypeControl = new ChangeDessertTypeControl(obj);
            this.Controls.Add(changeDessertsTypeControl);
            changeDessertsTypeControl.Location = new Point(100, 50);
            changeDessertsTypeControl.BringToFront();
            changeDessertsTypeControl.dessertTypeTextBox.Text = Main.dessertType;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                typeAdapter = new SqlDataAdapter($"SELECT * FROM ТипыДесертов WHERE Номер = {Main.dessertTypeId}", connection);
                typeDataSet = new DataSet();
                typeAdapter.Fill(typeDataSet);

                changeDessertsTypeControl.dessertDescriptionTextBox.Text = typeDataSet.Tables[0].Rows[0]["Описание"].ToString();
            }
        }

        public void FillIngredients()
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                string sqlExpression = $"SELECT * FROM Ингредиенты i JOIN ИнгредиентыВДесерте id on id.Ингредиент = i.Номер " +
                    $"JOIN Десерты d on d.Номер = id.Десерт WHERE d.Номер = {Main.dessertsDataSet.Tables[0].Rows[Main.dessertCount]["Номер"]}";
                ingredientsAdapter = new SqlDataAdapter(sqlExpression, connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
            }
            ingredientListBox.Items.Clear();
            foreach (DataRow row in ingredientsDataSet.Tables[0].Rows)
            {
                ingredientListBox.Items.Add(row[1]);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            ChangeIngredientsControl changeIngredientsControl = new ChangeIngredientsControl();
            Controls.Add(changeIngredientsControl);
            changeIngredientsControl.Location = new Point(100, 50);
            changeIngredientsControl.BringToFront();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            error_label.Visible = false;
            titleTextBox.BorderColor = Color.DarkGray;
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            error_label.Visible = false;
            countTextBox.BorderColor = Color.DarkGray;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter desAdapter;
            DataSet desDataSet;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                desAdapter = new SqlDataAdapter($"SELECT * FROM ИнгредиентыВДесерте WHERE Десерт = {idLabel.Text}", connection);
                desDataSet = new DataSet();
                desAdapter.Fill(desDataSet);
            }
            for (int i = desDataSet.Tables[0].Rows.Count - 1; i > 0; i--)
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"DELETE FROM ИнгредиентыВДесерте WHERE Ингредиент={desDataSet.Tables[0].Rows[i]["Ингредиент"]} and Десерт = {idLabel.Text}", connection);
                    command.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"DELETE FROM Десерты WHERE Номер={idLabel.Text}", connection);
                command.ExecuteNonQuery();
            }
            Main.dessertCount = 0;
            Main.FillDessert();
        }

        private void imagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        public void setImg(bool b)
        {
            Stream myStream;
            using (myStream = File.Open(changePhotoControl.getFileName(), FileMode.Open, FileAccess.Read))
            {
                imagePictureBox.Image = Image.FromStream(myStream);
            }
            img = b;
        }

        private void imagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (img)
            {
                int i = Main.AddImage(changePhotoControl.getFileName());
                SqlDataAdapter desAdapter;
                DataSet desDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    desAdapter = new SqlDataAdapter($"SELECT * FROM Десерты WHERE Номер = {idLabel.Text}", connection);
                    desDataSet = new DataSet();
                    desAdapter.Fill(desDataSet);

                    string sqlExpression = $"UPDATE Десерты SET Изображение={i} WHERE Номер = {idLabel.Text}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand($"DELETE FROM Изображения WHERE Номер={desDataSet.Tables[0].Rows[0]["Изображение"]}", connection);
                    command.ExecuteNonQuery();
                }
                img = false;
                image_error_label.Visible = false;
            }
            error_label.Visible = false;

            double number = 0;
            if (!double.TryParse(countTextBox.Text, out number))
            {
                error_label.Text = "!Необходимо ввести число";
                error_label.Visible = true;
                countTextBox.BorderColor = Color.Red;
                return;
            }
            else if ((countTextBox.Text.Contains(".") && countTextBox.Text.Length - 2 != '.') || (countTextBox.Text.Contains(",") && countTextBox.Text.Length - 2 != ','))
            {
                error_label.Text = "!Число должно быть целым";
                error_label.Visible = true;
                countTextBox.BorderColor = Color.Red;
                return;
            }
            else if (titleTextBox.Text.Length == 0)
            {
                error_label.Text = "!Вы не ввели название";
                error_label.Visible = true;
                titleTextBox.BorderColor = Color.Red;
                return;
            } 

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                string title = titleTextBox.Text;
                double count = Convert.ToInt32(countTextBox.Text);
                int desId = Convert.ToInt32(idLabel.Text);
                connection.Open();
                string sqlExpression;
                sqlExpression = $"UPDATE Десерты SET Название='{title}', Количество={count} WHERE Номер={idLabel.Text}";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            savedLabel.Visible = true;
            countTextBox.BorderColor = Color.DarkGray;
            titleTextBox.BorderColor = Color.DarkGray;
            error_label.Visible = false;
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void imagePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Controls.RemoveAt(0);
        }

        private void imagePictureBox_MouseHover(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            changePhotoControl = new ChangePhotoControl("dessert");
            Controls.Add(changePhotoControl);
            changePhotoControl.Location = new Point(500, 230);
            changePhotoControl.BringToFront();
        }

        private void dessertTypeIcon_MouseHover(object sender, EventArgs e)
        {
            changePhotoControl2 = new ChangePhotoControl("type");
            Controls.Add(changePhotoControl2);
            changePhotoControl2.Location = new Point(40, 110);
            changePhotoControl2.BringToFront();
        }

        private void dessertTypeIcon_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            AddNewDessertControl addNewDessertControl = new AddNewDessertControl();
            Controls.Add(addNewDessertControl);
            addNewDessertControl.Location = new Point(100, 50);
            addNewDessertControl.BringToFront();
            addNewDessertControl.dessertTypeLabel.Text = Main.dessertType;
            addNewDessertControl.amountLabel.Text = $"({Main.dessertAmount})";
        }

        private void to_next_button_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            Main.dessertCount += 1;
            Main.FillDessert();
        }

        private void to_previous_button_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            Main.dessertCount -= 1;
            Main.FillDessert();
        }

        private void to_first_button_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            Main.dessertCount = 0;
            Main.FillDessert();
        }

        private void to_last_button_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            Main.dessertCount = Main.dessertsDataSet.Tables[0].Rows.Count - 1; 
            Main.FillDessert();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (Controls.Count > 25)
                Controls.RemoveAt(0);
            AddNewDessertControl addNewDessertControl = new AddNewDessertControl();
            Controls.Add(addNewDessertControl);
            addNewDessertControl.Location = new Point(100, 50);
            addNewDessertControl.BringToFront();
            addNewDessertControl.dessertTypeLabel.Text = Main.dessertType;
            addNewDessertControl.amountLabel.Text = $"({Main.dessertAmount})";
        }

        private void DessertsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
