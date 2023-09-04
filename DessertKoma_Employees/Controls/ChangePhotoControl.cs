using DessertKoma_Employees.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DessertKoma_Employees.Controls
{
    public partial class ChangePhotoControl : UserControl
    {
        public bool b;
        public bool d;
        OpenFileDialog textDialogIMG;
        public static string fileName;
        public static string fileName2;
        public static string fileName3;
        public static string fileName4;
        public static string fileName5;
        string control;
        AddNewDessertControl addNewDessertControl;
        UserAccountControl userControl;
        AddUserControl addUserControl;

        public void setB(bool s)
        {
            b = s;
        }

        public bool getB()
        {
            return b;
        }

        public void setD(bool s)
        {
            d = s;
        }

        public bool getD()
        {
            return d;
        }

        public ChangePhotoControl(string c)
        {
            InitializeComponent();
            textDialogIMG = new OpenFileDialog();
            textDialogIMG.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            control = c;
            b = false;
            d = false;
        }

        public ChangePhotoControl(string c, AddNewDessertControl obj)
        {
            InitializeComponent();
            textDialogIMG = new OpenFileDialog();
            textDialogIMG.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            control = c;
            addNewDessertControl = obj;
            b = false;
            d = false;
        }

        public ChangePhotoControl(string c, UserAccountControl obj)
        {
            InitializeComponent();
            textDialogIMG = new OpenFileDialog();
            textDialogIMG.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            control = c;
            userControl = obj;
            b = false;
            d = false;
        }

        public ChangePhotoControl(string c, AddUserControl obj)
        {
            InitializeComponent();
            textDialogIMG = new OpenFileDialog();
            textDialogIMG.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            control = c;
            addUserControl = obj;
            b = false;
            d = false;
        }

        public string getFileName()
        {
            return fileName;
        }

        public string getNewFileName()
        {
            return fileName3;
        }

        public string getAddUserFileName()
        {
            return fileName5;
        }

        private void change_photo_button_Click(object sender, EventArgs e)
        {
            if (textDialogIMG.ShowDialog() == DialogResult.Cancel)
            {
                Hide();
                return;
            }
            if (control == "dessert")
            {
                fileName = textDialogIMG.FileName;
                Main.dessertControl.image_error_label.Visible = true;
                Main.dessertControl.setImg(true);
            }
            else if (control == "newDessert")
            {
                fileName3 = textDialogIMG.FileName; Stream myStream;
                using (myStream = File.Open(fileName3, FileMode.Open, FileAccess.Read))
                {
                    addNewDessertControl.desPic.Image = Image.FromStream(myStream);
                }
                addNewDessertControl.ph = true;
                b = false;
            }
            else if (control == "type")
            {
                fileName2 = textDialogIMG.FileName;
                Stream myStream;
                using (myStream = File.Open(fileName2, FileMode.Open, FileAccess.Read))
                {
                    Main.dessertControl.dessertTypeIcon.Image = Image.FromStream(myStream);
                }
                int i = Main.AddImage(fileName2);
                SqlDataAdapter typeDesAdapter;
                DataSet typeDesDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    typeDesAdapter = new SqlDataAdapter($"SELECT * FROM ТипыДесертов WHERE Название = '{Main.dessertControl.dessertTypeLabel.Text}'", connection);
                    typeDesDataSet = new DataSet();
                    typeDesAdapter.Fill(typeDesDataSet);

                    string sqlExpression = $"UPDATE ТипыДесертов SET Изображение={i} WHERE Название = '{Main.dessertControl.dessertTypeLabel.Text}'";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();

                    if (typeDesDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                    {
                        command = new SqlCommand($"DELETE FROM Изображения WHERE Номер={typeDesDataSet.Tables[0].Rows[0]["Изображение"]}", connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (control == "user")
            {
                fileName4 = textDialogIMG.FileName;
                Stream myStream;
                using (myStream = File.Open(fileName4, FileMode.Open, FileAccess.Read))
                {
                    userControl.userIcon.Image = Image.FromStream(myStream); 
                    Main.userPic.Image = Image.FromStream(myStream);
                }
                int i = Main.AddImage(fileName4);
                SqlDataAdapter usersAdapter;
                DataSet usersDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();

                    usersAdapter = new SqlDataAdapter($"SELECT * FROM Пользователи WHERE Номер = {userControl.id}", connection);
                    usersDataSet = new DataSet();
                    usersAdapter.Fill(usersDataSet);

                    string sqlExpression = $"UPDATE Пользователи SET Изображение={i} WHERE Номер = {userControl.id}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();

                    if (usersDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                    {
                        command = new SqlCommand($"DELETE FROM Изображения WHERE Номер={usersDataSet.Tables[0].Rows[0]["Изображение"]}", connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (control == "newUser")
            {
                fileName5 = textDialogIMG.FileName; 
                Stream myStream;
                using (myStream = File.Open(fileName5, FileMode.Open, FileAccess.Read))
                {
                    addUserControl.userPic.Image = Image.FromStream(myStream);
                }
                addUserControl.ph = true;
                d = false;
            }
            Hide();
        }

        private void ChangePhotoControl_Load(object sender, EventArgs e)
        {}
    }
}
