using DessertKoma_Employees.Controls;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Image = DessertsKoma_Employees.Classes.Image;
using Image2 = System.Drawing.Image;
using Word = Microsoft.Office.Interop.Word;

namespace DessertKoma_Employees.Forms
{
    public partial class Main : Form
    {
        SaveFileDialog textDialog;
        public static string connectionString = @"Data Source = MARUSYA\SQLEXPRESS; Initial Catalog = DessertsKoma; Integrated Security = True";
        static Main _obj;
        public static long id;
        public static long role;
        public static int dessertCount;
        public static string dessertType;
        public static int dessertTypeId;
        public static string dessertAmount;

        public static DessertsControl dessertControl;
        public static Guna2PictureBox userPic;

        public DessertsKomaDataSetTableAdapters.ТипыДесертовTableAdapter dessertTypeTableAdapter =
            new DessertsKomaDataSetTableAdapters.ТипыДесертовTableAdapter() { ClearBeforeFill = true };
        public static SqlDataAdapter dessertTypesAdapter;
        public static DataSet dessertTypesDataSet;
        public static SqlDataAdapter dessertsAdapter;
        public static DataSet dessertsDataSet;
        public static SqlDataAdapter amountAdapter;
        public static DataSet amountDataSet;
        public static SqlDataAdapter imageAdapter;
        public static DataSet imageDataSet;
        public static SqlDataAdapter ingredientsAdapter;
        public static DataSet ingredientsDataSet;
        public static SqlDataAdapter usersAdapter;
        public static DataSet usersDataSet; 

        public Main(long i, long r)
        {
            InitializeComponent();
            _obj = this;
            userPic = userIcon;
            id = i;
            role = r;
            dessertCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dessertTypesAdapter = new SqlDataAdapter("SELECT * FROM ТипыДесертов", connection);
                dessertTypesDataSet = new DataSet();
                dessertTypesAdapter.Fill(dessertTypesDataSet);
                dessertControl = new DessertsControl(_obj);
            }
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                usersAdapter = new SqlDataAdapter($"SELECT p.Изображение FROM Пользователи p WHERE p.Номер = {id}", connection);
                usersDataSet = new DataSet();
                usersAdapter.Fill(usersDataSet);
                if (usersDataSet.Tables[0].Rows[0]["Изображение"].ToString() != "")
                {
                    imageAdapter = new SqlDataAdapter($"SELECT i.Номер, i.ИмяФайла, i.Название, i.Данные FROM Пользователи p JOIN Изображения i ON p.Изображение = i.Номер WHERE p.Номер = {id}", connection);
                    imageDataSet = new DataSet();
                    imageAdapter.Fill(imageDataSet);

                    int id2 = Convert.ToInt32(imageDataSet.Tables[0].Rows[0]["Номер"]);
                    string filename = imageDataSet.Tables[0].Rows[0]["ИмяФайла"].ToString();
                    string title = imageDataSet.Tables[0].Rows[0]["Название"].ToString();
                    byte[] data = (byte[])imageDataSet.Tables[0].Rows[0]["Данные"];
                    Image image = new Image(id2, filename, title, data);
                    string path = "";
                    if (Environment.CurrentDirectory.Contains("Debug"))
                    {
                        path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{image.FileName}");
                    } else
                    {
                        path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 12, 12), $@"Images\{image.FileName}");
                    }
                    if (!File.Exists(path))
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.OpenOrCreate))
                        {
                            fs.Write(image.Data, 0, image.Data.Length);
                        }
                    }

                    userIcon.Image = Image2.FromFile(path);
                }
                textDialog = new SaveFileDialog();
                textDialog.Filter = "Word Files | *.docx";
                textDialog.DefaultExt = "docx";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (role == 3)
            {
                usersBtn.Visible = false;
            }
            int i = dessertsPanel.Location.Y;
            int j = dessertsPanel.Location.X;

            int k = 0;

            foreach (DataRow row in dessertTypesDataSet.Tables[0].Rows)
            {
                Guna2Button btn = new Guna2Button();
                btn.BackColor = Color.LavenderBlush;
                btn.FillColor = Color.LavenderBlush;
                btn.ForeColor = Color.Black;
                btn.BorderColor = Color.Gray;
                btn.BorderThickness = 1;
                btn.BorderRadius = 5;
                btn.Cursor = Cursors.Hand;
                btn.DialogResult = DialogResult.None;
                //btn.Dock = DockStyle.
                btn.BringToFront();
                btn.FocusedColor = Color.Empty;
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                if (Environment.CurrentDirectory.Contains("Debug"))
                    btn.Image = Image2.FromFile(Path.Combine(Environment.CurrentDirectory.
                        Remove(Environment.CurrentDirectory.Length - 10, 10), @"Images\dessert.png"));
                else
                    btn.Image = Image2.FromFile(Path.Combine(Environment.CurrentDirectory.
                        Remove(Environment.CurrentDirectory.Length - 12, 12), @"Images\dessert.png"));
                btn.ImageAlign = HorizontalAlignment.Left;
                btn.ImageOffset = new Point(5, 0);
                btn.ImageSize = new Size(22, 22);
                btn.Location = new Point(5, k);
                btn.Name = $"{row[0]}Btn";
                btn.HoverState.FillColor = Color.Pink;
                btn.HoverState.FillColor = Color.Pink;
                btn.HoverState.ForeColor = Color.Black;
                btn.PressedColor = Color.Purple;
                btn.Size = new Size(140, 35);
                btn.Text = row[1].ToString();
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(3, 0);
                btn.Click += new System.EventHandler(this.btn_Click);
                dessertsPanel.Controls.Add(btn);
                k += (btn.Size.Height + 3);
            }

            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            MainControl mainControl = new MainControl();
            infoPanel.Controls.Add(mainControl);
            mainControl.Dock = DockStyle.Fill;
            mainControl.BringToFront();
            dessertCount = 0;
        }

        public static void FillType()
        {
            dessertControl.dessertTypeLabel.Text = dessertType;
            SqlDataAdapter typeAdapter;
            DataSet typesDataSet;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                typeAdapter = new SqlDataAdapter($"SELECT * FROM ТипыДесертов WHERE Название = '{dessertType}'", connection);
                typesDataSet = new DataSet();
                typeAdapter.Fill(typesDataSet);

                string description = typesDataSet.Tables[0].Rows[0]["Описание"].ToString();
                string newDescription = "";
                if (description.Length > 61)
                {
                    int count = 0;
                    for (int i = 0; i < description.Length; i++)
                    {
                        newDescription += description[i];
                        if ((i + 1) % 55 == 0 && i != description.Length - 1 && count == 0)
                        {
                            if (description[i + 1] == ' ')
                            {
                                newDescription += "\n";
                                count = 0;
                            } else
                            {
                                ++count;
                            }
                            
                        }
                        if (count > 0)
                        {
                            if (i != description.Length - 1 && description[i + 1] == ' ')
                            {
                                newDescription += "\n";
                                count = 0;
                            }
                            else
                                ++count;
                        }
                    }
                } else
                    newDescription = description;
                dessertControl.dessertDescriptionLabel.Text = newDescription;

                string sqlExpression = $"select * from ЕдиницыИзмерения e join ТипыДесертов t on t.ЕдиницаИзмерения = e.Номер where t.ЕдиницаИзмерения = '{typesDataSet.Tables[0].Rows[0]["ЕдиницаИзмерения"]}'";
                amountAdapter = new SqlDataAdapter(sqlExpression, connection);
                amountDataSet = new DataSet();
                amountAdapter.Fill(amountDataSet);
                dessertAmount = amountDataSet.Tables[0].Rows[0]["Название"].ToString();
                dessertControl.amountLabel.Text = $"({amountDataSet.Tables[0].Rows[0]["Название"]})";

                sqlExpression = $"SELECT * FROM Изображения WHERE Номер={typesDataSet.Tables[0].Rows[0]["Изображение"]}"; 
                imageAdapter = new SqlDataAdapter(sqlExpression, connection);
                imageDataSet = new DataSet();
                imageAdapter.Fill(imageDataSet);
                int id = Convert.ToInt32(imageDataSet.Tables[0].Rows[0]["Номер"]);
                string filename = imageDataSet.Tables[0].Rows[0]["ИмяФайла"].ToString();
                string title = imageDataSet.Tables[0].Rows[0]["Название"].ToString();
                byte[] data = (byte[])imageDataSet.Tables[0].Rows[0]["Данные"];
                Image image = new Image(id, filename, title, data);
                string path = "";
                if (Environment.CurrentDirectory.Contains("Debug"))
                    path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{image.FileName}");
                else
                    path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 12, 12), $@"Images\{image.FileName}");
                if (!File.Exists(path))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.OpenOrCreate))
                    {
                        fs.Write(image.Data, 0, image.Data.Length);
                    }
                }

                dessertControl.dessertTypeIcon.Image = Image2.FromFile(path);
            }
        }

        public void UpgradeType(Main obj)
        {
            obj.dessertsPanel.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dessertTypesAdapter = new SqlDataAdapter("SELECT * FROM ТипыДесертов", connection);
                dessertTypesDataSet = new DataSet();
                dessertTypesAdapter.Fill(dessertTypesDataSet);
            }
            int i = obj.dessertsPanel.Location.Y;
            int j = obj.dessertsPanel.Location.X;

            int k = 0;

            foreach (DataRow row in dessertTypesDataSet.Tables[0].Rows)
            {
                Guna2Button btn = new Guna2Button();
                btn.BackColor = Color.LavenderBlush;
                btn.FillColor = Color.LavenderBlush;
                btn.ForeColor = Color.Black;
                btn.BorderColor = Color.Gray;
                btn.BorderThickness = 1;
                btn.BorderRadius = 5;
                btn.Cursor = Cursors.Hand;
                btn.DialogResult = DialogResult.None;
                //btn.Dock = DockStyle.
                btn.BringToFront();
                btn.FocusedColor = Color.Empty;
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                if (Environment.CurrentDirectory.Contains("Debug"))
                    btn.Image = Image2.FromFile(Path.Combine(Environment.CurrentDirectory.
                        Remove(Environment.CurrentDirectory.Length - 10, 10), @"Images\dessert.png"));
                else
                    btn.Image = Image2.FromFile(Path.Combine(Environment.CurrentDirectory.
                        Remove(Environment.CurrentDirectory.Length - 12, 12), @"Images\dessert.png"));
                btn.ImageAlign = HorizontalAlignment.Left;
                btn.ImageOffset = new Point(5, 0);
                btn.ImageSize = new Size(22, 22);
                btn.Location = new Point(5, k);
                btn.Name = $"{row[0]}Btn";
                btn.HoverState.FillColor = Color.Pink;
                btn.HoverState.FillColor = Color.Pink;
                btn.HoverState.ForeColor = Color.Black;
                btn.PressedColor = Color.Purple;
                btn.Size = new Size(140, 35);
                btn.Text = row[1].ToString();
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(3, 0);
                btn.Click += new System.EventHandler(_obj.btn_Click);
                obj.dessertsPanel.Controls.Add(btn);
                k += (btn.Size.Height + 3);
            }


            SqlDataAdapter typeAdapter;
            DataSet typesDataSet;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                typeAdapter = new SqlDataAdapter($"SELECT * FROM ТипыДесертов WHERE Название = '{dessertType}'", connection);
                typesDataSet = new DataSet();
                typeAdapter.Fill(typesDataSet);
                dessertTypeId = Convert.ToInt32(typesDataSet.Tables[0].Rows[0]["Номер"]);
            }

            FillType();
            dessertCount = 0;
            FillDessert();
        }

        public static void FillDessert()
        {
            if (role == 3)
            {
                dessertControl.titleTextBox.Enabled = false;
                dessertControl.countTextBox.Enabled = false;
                dessertControl.edit_button.Visible = false;
                dessertControl.save_button.Visible = false;
                dessertControl.delete_button.Visible = false;
                dessertControl.guna2Button1.Visible = false;
                dessertControl.imagePictureBox.Enabled = false;
                dessertControl.changeDessertTypeButton.Visible = false;
                dessertControl.guna2Button3.Visible = false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dessertsAdapter = new SqlDataAdapter("SELECT * FROM Десерты WHERE Тип = " + dessertTypeId, connection);
                dessertsDataSet = new DataSet();
                dessertsAdapter.Fill(dessertsDataSet);
            }
            if (dessertsDataSet.Tables[0].Rows.Count == 0)
            {
                dessertControl.noDessertsPanel.Visible = true;
                return;
            } else
            {
                dessertControl.noDessertsPanel.Visible = false;
            }
            if (dessertCount == 0)
            {
                dessertControl.to_first_button.Enabled = false;
                dessertControl.to_previous_button.Enabled = false;
            }
            else
            {
                dessertControl.to_first_button.Enabled = true;
                dessertControl.to_previous_button.Enabled = true;
            }

            if (dessertCount == dessertsDataSet.Tables[0].Rows.Count-1)
            {
                dessertControl.to_last_button.Enabled = false;
                dessertControl.to_next_button.Enabled = false;
            }
            else
            {
                dessertControl.to_last_button.Enabled = true;
                dessertControl.to_next_button.Enabled = true;
            }

            if (dessertControl.to_first_button.Enabled == false && dessertControl.to_previous_button.Enabled == false &&
                dessertControl.to_last_button.Enabled == false && dessertControl.to_next_button.Enabled == false)
                dessertControl.onlyDessertLabel.Visible = true;
            else
                dessertControl.onlyDessertLabel.Visible = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dessertControl.idLabel.Text = dessertsDataSet.Tables[0].Rows[dessertCount]["Номер"].ToString();
                dessertControl.titleTextBox.Text = dessertsDataSet.Tables[0].Rows[dessertCount]["Название"].ToString();
                dessertControl.countTextBox.Text = dessertsDataSet.Tables[0].Rows[dessertCount]["Количество"].ToString();
                dessertControl.costLabel.Text = dessertsDataSet.Tables[0].Rows[dessertCount]["Стоимость"].ToString() + " руб.";

                string sqlExpression = $"SELECT * FROM Ингредиенты i JOIN ИнгредиентыВДесерте id on id.Ингредиент = i.Номер " +
                    $"JOIN Десерты d on d.Номер = id.Десерт WHERE d.Номер = {dessertsDataSet.Tables[0].Rows[dessertCount]["Номер"]}";
                ingredientsAdapter = new SqlDataAdapter(sqlExpression, connection);
                ingredientsDataSet = new DataSet();
                ingredientsAdapter.Fill(ingredientsDataSet);
                dessertControl.ingredientListBox.Items.Clear();
                foreach (DataRow row in ingredientsDataSet.Tables[0].Rows)
                {
                    dessertControl.ingredientListBox.Items.Add(row[1]);
                }

                SqlDataAdapter imageAdapter;
                DataSet imageDataSet;
                sqlExpression = $"SELECT * FROM Изображения WHERE Номер={dessertsDataSet.Tables[0].Rows[dessertCount]["Изображение"]}";
                imageAdapter = new SqlDataAdapter(sqlExpression, connection);
                imageDataSet = new DataSet();
                imageAdapter.Fill(imageDataSet);

                int id = Convert.ToInt32(imageDataSet.Tables[0].Rows[0]["Номер"]);
                string filename = imageDataSet.Tables[0].Rows[0]["ИмяФайла"].ToString();
                string title = imageDataSet.Tables[0].Rows[0]["Название"].ToString();
                byte[] data = (byte[])imageDataSet.Tables[0].Rows[0]["Данные"];

                Image image = new Image(id, filename, title, data);
                string path = "";
                if (Environment.CurrentDirectory.Contains("Debug"))
                    path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{image.FileName}");
                else
                    path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 12, 12), $@"Images\{image.FileName}");
                if (!File.Exists(path))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.Create))
                    {
                        fs.Write(image.Data, 0, image.Data.Length);
                    }
                }

                dessertControl.imagePictureBox.Image = Image2.FromFile(path);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dessertCount = 0;
            dessertControl.noDessertsPanel.Visible = false;
            dessertType = (sender as Control).Text;
            SqlDataAdapter typeAdapter;
            DataSet typesDataSet;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                typeAdapter = new SqlDataAdapter($"SELECT * FROM ТипыДесертов WHERE Название = '{dessertType}'", connection);
                typesDataSet = new DataSet();
                typeAdapter.Fill(typesDataSet);
                dessertTypeId = Convert.ToInt32(typesDataSet.Tables[0].Rows[0]["Номер"]);

                dessertsAdapter = new SqlDataAdapter("SELECT * FROM Десерты WHERE Тип = " + dessertTypeId, connection);
                dessertsDataSet = new DataSet();
                dessertsAdapter.Fill(dessertsDataSet);
            }

            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            infoPanel.Controls.Add(dessertControl);
            dessertControl.Dock = DockStyle.Fill;
            dessertControl.BringToFront();
            FillType();

            int l = dessertsDataSet.Tables[0].Rows.Count;
            if (dessertsDataSet.Tables[0].Rows.Count < 1)
                dessertControl.noDessertsPanel.Visible = true;
            else
                FillDessert();
        }

        public static Main Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Main(id, role);
                }
                return _obj;
            }
        }

        public static int AddImage(string name)
        {
            string newname = "";
            string path = "";
            if (Environment.CurrentDirectory.Contains("Debug"))
                path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10), $@"Images\{name.Substring(name.LastIndexOf('\\') + 1)}");
            else
                path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 12, 12), $@"Images\{name.Substring(name.LastIndexOf('\\') + 1)}");
            if (File.Exists(path))
            {
                string r = name.Substring(name.LastIndexOf('.') + 1);
                newname = name.Remove(name.Length - 4, 4) + "1." + r;
            }
            else
                newname = name;
            string shortFileName = newname.Substring(newname.LastIndexOf('\\') + 1);
                                                                               
            string title = shortFileName.Remove(shortFileName.Length - 4, 4);

            byte[] imageData;
            using (System.IO.FileStream fs = new System.IO.FileStream(name, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }
            string sqlExpression = "sp_InsertImage";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@ИмяФайла",
                    Value = shortFileName
                };
                command.Parameters.Add(nameParam);
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@Название",
                    Value = title
                };
                command.Parameters.Add(titleParam);
                SqlParameter dataParam = new SqlParameter
                {
                    ParameterName = "@Данные",
                    Value = imageData
                };
                command.Parameters.Add(dataParam);
                int i = Convert.ToInt32(command.ExecuteScalar());
                return i;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddImage("C:\\Users\\maryk\\OneDrive\\Изображения\\Десерты\\IMG_8603 (2).JPG");
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            UserAccountControl userAccountControl = new UserAccountControl(id);
            infoPanel.Controls.Add(userAccountControl);
            userAccountControl.Dock = DockStyle.Fill;
            userAccountControl.BringToFront();
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            StatisticControl statisticControl = new StatisticControl();
            infoPanel.Controls.Add(statisticControl);
            statisticControl.Dock = DockStyle.Fill;
            statisticControl.BringToFront();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(15, 10);
            infoPanel.Controls.RemoveAt(0);
            backIcon.Visible = false;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            MainControl mainControl = new MainControl();
            infoPanel.Controls.Add(mainControl);
            mainControl.Dock = DockStyle.Fill;
            mainControl.BringToFront();
        }

        private void info_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userIcon_Click_1(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            UserAccountControl userAccountControl = new UserAccountControl(id);
            infoPanel.Controls.Add(userAccountControl);
            userAccountControl.Dock = DockStyle.Fill;
            userAccountControl.BringToFront();
        }

        public static void Exit()
        {
            SignIn signIn = new SignIn();
            Instance.Hide();
            signIn.ShowDialog();
            Instance.Close();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            UsersControl usersControl = new UsersControl();
            infoPanel.Controls.Add(usersControl);
            usersControl.Dock = DockStyle.Fill;
            usersControl.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);
            IngredientsControl ingControl = new IngredientsControl();
            infoPanel.Controls.Add(ingControl);
            ingControl.Dock = DockStyle.Fill;
            ingControl.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userIcon.Location = new Point(50, 10);
            backIcon.Visible = true;
            if (infoPanel.Controls.Count > 0)
                infoPanel.Controls.RemoveAt(0);

            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                string sqlExpression = $"UPDATE Заказы SET Статус = 6 WHERE [Дата выдачи] < GETDATE() AND Статус < 5";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }

            if (role == 3)
            {
                OrdersForEmplControl ordersControl = new OrdersForEmplControl();
                infoPanel.Controls.Add(ordersControl);
                ordersControl.Dock = DockStyle.Fill;
                ordersControl.BringToFront();
            } else
            {
                OrdersControl ordersControl = new OrdersControl();
                infoPanel.Controls.Add(ordersControl);
                ordersControl.Dock = DockStyle.Fill;
                ordersControl.BringToFront();
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Справка_Desserts.koma.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Справка_Desserts.koma.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                wordDocument.SaveAs2(filename);
                MessageBox.Show($"Документ создан {filename}");
            }
            catch (Exception mes)
            {
                MessageBox.Show($"Документ не создан. Возникло исключение {mes.Message}");
            }
            finally
            {
                wordDocument.Close();
            }
        }
    }
}
