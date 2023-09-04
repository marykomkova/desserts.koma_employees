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
using LiveCharts;
using LiveCharts.Wpf;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace DessertKoma_Employees.Controls
{
    public partial class StatisticControl : UserControl
    {
        SaveFileDialog textDialog;
        public StatisticControl()
        {
            InitializeComponent();
            textDialog = new SaveFileDialog();
            textDialog.Filter = "Word Files | *.docx";
            textDialog.DefaultExt = "docx";
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void count_of_desserts_by_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Fill_Statistic()
        {
            DateTime now = DateTime.Now;
            guna2DateTimePicker1.Value = new DateTime(now.Year, now.Month, 1);
            guna2DateTimePicker2.Value = now;
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT d.Название as Десерт, t.Название as [Тип], e.Название as [Единица измерения], COUNT(dz.Номер) as [Количество заказов десерта] " +
                    "FROM Десерты d LEFT JOIN ДесертыВЗаказе dz ON d.Номер = dz.Десерт LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип " +
                    "LEFT JOIN ЕдиницыИзмерения e ON t.ЕдиницаИзмерения = e.Номер GROUP BY d.Название, t.Название, e.Название ORDER BY [Количество заказов десерта] ";
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                countOfOrdersEachDessert.DataSource = dtRecord;
                dessertTypeComboBox.Text = "Выберите тип десерта";

                sql = "SELECT t.Название as [Тип], e.Название as [Единица измерения], COUNT(dz.Номер) as [Количество заказов типа] " +
                    "FROM Десерты d LEFT JOIN ДесертыВЗаказе dz ON d.Номер = dz.Десерт LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип " +
                    "LEFT JOIN ЕдиницыИзмерения e ON t.ЕдиницаИзмерения = e.Номер GROUP BY t.Название, e.Название ORDER BY [Количество заказов типа] ";
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecor = new DataTable();
                sqlDataAdap.Fill(dtRecor);
                countOfOrdersEachType.DataSource = dtRecor;


                string sql2 = "SELECT p.Логин, p.Имя, COUNT(z.Номер) as [Количество заказов] FROM Пользователи p LEFT JOIN Заказы z ON p.Номер = z.Пользователь WHERE p.Роль = 4 GROUP BY p.Логин, p.Имя ORDER BY [Количество заказов]";
                SqlCommand sqlCmd2 = new SqlCommand();
                sqlCmd2.Connection = connection;
                sqlCmd2.CommandType = CommandType.Text;
                sqlCmd2.CommandText = sql2;
                SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd2);

                DataTable dtRecord2 = new DataTable();
                sqlDataAdap2.Fill(dtRecord2);
                countOfOrdersEachUser.DataSource = dtRecord2;

                string sql3 = "SELECT p.Логин, p.Имя, COUNT(z.Номер) as [Количество заказов] FROM Пользователи p " +
                    $"LEFT JOIN Заказы z ON p.Номер = z.Сотрудник WHERE p.Роль != 4 AND (z.[Дата заказа] <= '{guna2DateTimePicker2.Value.Year}-{guna2DateTimePicker2.Value.Month}-{guna2DateTimePicker2.Value.Day}' and [Дата заказа] >= '{guna2DateTimePicker1.Value.Year}-{guna2DateTimePicker1.Value.Month}-{guna2DateTimePicker1.Value.Day}') GROUP BY p.Логин, p.Имя ORDER BY [Количество заказов]";
                SqlCommand sqlCmd3 = new SqlCommand();
                sqlCmd3.Connection = connection;
                sqlCmd3.CommandType = CommandType.Text;
                sqlCmd3.CommandText = sql3;
                SqlDataAdapter sqlDataAdap3 = new SqlDataAdapter(sqlCmd3);
                DataTable dtRecord3 = new DataTable();
                sqlDataAdap3.Fill(dtRecord3);
                employeesOrdersForPeriod.DataSource = dtRecord3;
                if (dtRecord3.Rows.Count == 0)
                {
                    label4.Visible = true;
                    robotPic.Visible = true;
                    saveCountOfOrdersEachEmployeeStatistic.Enabled = false;
                } else
                {
                    label4.Visible = false;
                    robotPic.Visible = false;
                    saveCountOfOrdersEachEmployeeStatistic.Enabled = true;
                }

                ChartValues<int> values = new ChartValues<int>();
                List<string> types = new List<string>();
                foreach (var valRow in dtRecord.Rows)
                {
                    values.Add(Convert.ToInt32(((DataRow)valRow)[3]));
                    types.Add(((DataRow)valRow)[0].ToString());
                }

                chart1.Series["s1"].Points.Clear();
                int k = 0;
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i] != 0)
                    {
                        chart1.Series["s1"].Points.AddXY(types[i], values[i].ToString());
                        chart1.Series["s1"].Points[k].ToolTip = types[i];
                        chart1.Series["s1"].Points[k].LabelToolTip = "количество - " + values[i];
                        k++;
                    }
                }


                ChartValues<int> values2 = new ChartValues<int>();
                List<string> types2 = new List<string>();
                foreach (var valRow in dtRecor.Rows)
                {
                    values2.Add(Convert.ToInt32(((DataRow)valRow)[2]));
                    types2.Add(((DataRow)valRow)[0].ToString());
                }

                chart2.Series["s1"].Points.Clear();
                int k2 = 0;
                for (int i = 0; i < values2.Count; i++)
                {
                    if (values2[i] != 0)
                    {
                        chart2.Series["s1"].Points.AddXY(types2[i], values2[i].ToString());
                        chart2.Series["s1"].Points[k2].ToolTip = types2[i];
                        chart2.Series["s1"].Points[k2].LabelToolTip = "количество - " + values2[i];
                        k2++;
                    }
                }


                sql = $"SELECT d.Название as Десерт, d.Стоимость, t.Название as Тип, e.Название as [Единица измерения] FROM Десерты d LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип LEFT JOIN ЕдиницыИзмерения e ON e.Номер = t.ЕдиницаИзмерения JOIN ИнгредиентыВДесерте i ON i.Десерт = d.Номер WHERE i.Ингредиент = {ingredientComboBox.SelectedValue} GROUP BY d.Название, d.Стоимость, t.Название, e.Название";
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                sqlDataAdap = new SqlDataAdapter(sqlCmd);

                dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0)
                {
                    label1.Visible = true;
                    robotPic2.Visible = true;
                    dessertsWhithChosenIngr.Visible = false;
                    saveDessertsWithIngredientStatistic.Enabled = false;
                }
                else
                {
                    label1.Visible = false;
                    robotPic2.Visible = false;
                    dessertsWhithChosenIngr.Visible = true;
                    dessertsWhithChosenIngr.DataSource = dtRecord;
                    saveDessertsWithIngredientStatistic.Enabled = true;
                }

            }
        }

        private void StatisticControl_Load(object sender, EventArgs e)
        {
            типыДесертовTableAdapter.Fill(dessertsKomaDataSet.ТипыДесертов);
            ингредиентыTableAdapter.Fill(dessertsKomaDataSet.Ингредиенты);
            Fill_Statistic();
            ingredientComboBox.Text = "Выберите ингредиент";

            chart1.Titles.Add("Круговая диаграмма");
            chart1.Series["s1"].IsValueShownAsLabel = true;

            chart2.Titles.Add("Круговая диаграмма");
            chart2.Series["s1"].IsValueShownAsLabel = true;
        }

        private void dessertTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT d.Название as Десерт, t.Название as [Тип], e.Название as [Единица измерения], COUNT(dz.Номер) as [Количество заказов десерта] " +
                    "FROM Десерты d LEFT JOIN ДесертыВЗаказе dz ON d.Номер = dz.Десерт LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип " +
                    $"LEFT JOIN ЕдиницыИзмерения e ON t.ЕдиницаИзмерения = e.Номер WHERE t.Номер = {dessertTypeComboBox.SelectedValue} GROUP BY d.Название, t.Название, e.Название ORDER BY [Количество заказов десерта] ";
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                countOfOrdersEachDessert.DataSource = dtRecord;

                ChartValues<int> values = new ChartValues<int>();
                List<string> types = new List<string>();
                foreach (var valRow in dtRecord.Rows)
                {
                    values.Add(Convert.ToInt32(((DataRow)valRow)[3]));
                    types.Add(((DataRow)valRow)[0].ToString());
                }

                chart1.Series["s1"].Points.Clear();
                int k = 0;
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i] != 0)
                    {
                        chart1.Series["s1"].Points.AddXY(types[i], values[i].ToString());
                        chart1.Series["s1"].Points[k].ToolTip = types[i];
                        chart1.Series["s1"].Points[k].LabelToolTip = "количество - " + values[i];
                        k++;
                    }
                }
            }
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void guna2DateTimePicker2_TextChanged(object sender, EventArgs e)
        {
                
            }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                string sql3 = "SELECT p.Логин, p.Имя, COUNT(z.Номер) as [Количество заказов] FROM Пользователи p " +
                    $"LEFT JOIN Заказы z ON p.Номер = z.Сотрудник WHERE (z.[Дата заказа] <= '{guna2DateTimePicker2.Value.Year}-{guna2DateTimePicker2.Value.Month}-{guna2DateTimePicker2.Value.Day}' and [Дата заказа] >= '{guna2DateTimePicker1.Value.Year}-{guna2DateTimePicker1.Value.Month}-{guna2DateTimePicker1.Value.Day}') GROUP BY p.Логин, p.Имя ORDER BY [Количество заказов] "; 
                SqlCommand sqlCmd3 = new SqlCommand();
                sqlCmd3.Connection = connection;
                sqlCmd3.CommandType = CommandType.Text;
                sqlCmd3.CommandText = sql3;
                SqlDataAdapter sqlDataAdap3 = new SqlDataAdapter(sqlCmd3);

                DataTable dtRecord3 = new DataTable();
                sqlDataAdap3.Fill(dtRecord3);

                if (dtRecord3.Rows.Count == 0)
                {
                    label4.Visible = true;
                    robotPic.Visible = true;
                    employeesOrdersForPeriod.Visible = false;
                    saveCountOfOrdersEachEmployeeStatistic.Enabled = false;
                }
                else
                {
                    label4.Visible = false;
                    robotPic.Visible = false;
                    employeesOrdersForPeriod.Visible = true;
                    employeesOrdersForPeriod.DataSource = dtRecord3;
                    saveCountOfOrdersEachEmployeeStatistic.Enabled = true;
                }
                

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT d.Название as Десерт, d.Стоимость, t.Название as Тип, e.Название as [Единица измерения] FROM Десерты d LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип LEFT JOIN ЕдиницыИзмерения e ON e.Номер = t.ЕдиницаИзмерения JOIN ИнгредиентыВДесерте i ON i.Десерт = d.Номер WHERE i.Ингредиент = {ingredientComboBox.SelectedValue} GROUP BY d.Название, d.Стоимость, t.Название, e.Название";
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0)
                {
                    robotPic2.Visible = true;
                    label1.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    robotPic2.Visible = false;
                    dessertsWhithChosenIngr.DataSource = dtRecord;
                }
                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql2 = $"SELECT p.Логин, p.Имя, COUNT(z.Номер) as [Количество заказов] FROM Пользователи p LEFT JOIN Заказы z ON p.Номер = z.Пользователь WHERE p.Роль = 4 GROUP BY p.Логин, p.Имя HAVING COUNT(z.Номер) > {guna2NumericUpDown1.Value}";
                SqlCommand sqlCmd2 = new SqlCommand();
                sqlCmd2.Connection = connection;
                sqlCmd2.CommandType = CommandType.Text;
                sqlCmd2.CommandText = sql2;
                SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd2);

                DataTable dtRecord2 = new DataTable();
                sqlDataAdap2.Fill(dtRecord2);

                if (dtRecord2.Rows.Count == 0)
                {
                    no_users.Visible = true;
                    robotPic3.Visible = true;
                    countOfOrdersEachUser.Visible = false;
                    saveCountOfOrdersEachUserStatistic.Enabled = false;
                } else
                {
                    no_users.Visible = false;
                    robotPic3.Visible = false;
                    countOfOrdersEachUser.Visible = true;
                    countOfOrdersEachUser.DataSource = dtRecord2;
                    saveCountOfOrdersEachUserStatistic.Enabled = true;
                }

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = "SELECT d.Название as Десерт, t.Название as [Тип], e.Название as [Единица измерения], COUNT(dz.Номер) as [Количество заказов десерта] " +
                    "FROM Десерты d LEFT JOIN ДесертыВЗаказе dz ON d.Номер = dz.Десерт LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип " +
                    "LEFT JOIN ЕдиницыИзмерения e ON t.ЕдиницаИзмерения = e.Номер GROUP BY d.Название, t.Название, e.Название ORDER BY [Количество заказов десерта] ";
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                countOfOrdersEachDessert.DataSource = dtRecord;
                dessertTypeComboBox.Text = "Выберите тип десерта";

                ChartValues<int> values = new ChartValues<int>();
                List<string> types = new List<string>();
                foreach (var valRow in dtRecord.Rows)
                {
                    values.Add(Convert.ToInt32(((DataRow)valRow)[3]));
                    types.Add(((DataRow)valRow)[0].ToString());
                }

                chart1.Series["s1"].Points.Clear();
                int k = 0;
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i] != 0)
                    {
                        chart1.Series["s1"].Points.AddXY(types[i], values[i].ToString());
                        chart1.Series["s1"].Points[k].ToolTip = types[i];
                        chart1.Series["s1"].Points[k].LabelToolTip = "количество - " + values[i];
                        k++;
                    }
                }
            }
        }

        private void f_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ingredientComboBox.Text = "Выберите ингредиент";
        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();
                string sql = $"SELECT d.Название as Десерт, d.Стоимость, t.Название as Тип, e.Название as [Единица измерения] FROM Десерты d LEFT JOIN ТипыДесертов t ON t.Номер = d.Тип LEFT JOIN ЕдиницыИзмерения e ON e.Номер = t.ЕдиницаИзмерения JOIN ИнгредиентыВДесерте i ON i.Десерт = d.Номер WHERE i.Ингредиент = {ingredientComboBox.SelectedValue} GROUP BY d.Название, d.Стоимость, t.Название, e.Название";
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sql;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0)
                {
                    label1.Visible = true;
                    robotPic2.Visible = true;
                    dessertsWhithChosenIngr.Visible = false;
                    saveDessertsWithIngredientStatistic.Enabled = false;
                }
                else
                {
                    label1.Visible = false;
                    robotPic2.Visible = false;
                    dessertsWhithChosenIngr.Visible = true;
                    dessertsWhithChosenIngr.DataSource = dtRecord;
                    saveDessertsWithIngredientStatistic.Enabled = true;
                }

            }
        }

        private void f_Selected(object sender, TabControlEventArgs e)
        {
            ingredientComboBox.Text = "Выберите ингредиент";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void employeesOrdersForPeriod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void robotPic2_Click(object sender, EventArgs e)
        {

        }

        private void countOfOrdersEachDessert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void diagramm_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (diagramm_checkbox.Checked)
                chart1.Visible = true;
            else
                chart1.Visible = false;
        }

        private void diaagramm_types_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (diaagramm_types_checkbox.Checked)
            {
                countOfOrdersEachType.Visible = false;
                chart2.Visible = true;
            }
            else
            {
                countOfOrdersEachType.Visible = true;
                chart2.Visible = false;
            }
        }

        private void saveCountOfEachDessertStatistic_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Статистика_КоличествоЗаказовДесертов_{DateTime.Now.ToShortDateString()}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Статистика_КоличествоЗаказовДесертов.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                Word.Table tab = wordDocument.Tables[1];
                ReplaceWordStub("{Date}", DateTime.Now.ToString(), wordDocument);

                SqlDataAdapter userAdapter;
                DataSet userDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    userAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин FROM Пользователи p WHERE p.Номер = {Main.id}", connection);
                    userDataSet = new DataSet();
                    userAdapter.Fill(userDataSet);
                }

                ReplaceWordStub("{Employee}", userDataSet.Tables[0].Rows[0]["Логин"].ToString(), wordDocument);
                for (int i = 0, count = 2; i < countOfOrdersEachDessert.Rows.Count; i++, count++)
                {
                    tab.Cell(count, 1).Range.Text = (i + 1).ToString();
                    tab.Cell(count, 2).Range.Text = countOfOrdersEachDessert.Rows[i].Cells[0].Value.ToString();
                    tab.Cell(count, 3).Range.Text = countOfOrdersEachDessert.Rows[i].Cells[1].Value.ToString();
                    tab.Cell(count, 4).Range.Text = countOfOrdersEachDessert.Rows[i].Cells[2].Value.ToString();
                    tab.Cell(count, 5).Range.Text = countOfOrdersEachDessert.Rows[i].Cells[3].Value.ToString();

                    if (count < countOfOrdersEachDessert.Rows.Count + 1)
                        tab.Rows.Add();
                }

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Статистика_КоличествоЗаказовТипов_{DateTime.Now.ToShortDateString()}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Статистика_КоличествоЗаказовТипов.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                Word.Table tab = wordDocument.Tables[1];
                ReplaceWordStub("{Date}", DateTime.Now.ToString(), wordDocument);

                SqlDataAdapter userAdapter;
                DataSet userDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    userAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин FROM Пользователи p WHERE p.Номер = {Main.id}", connection);
                    userDataSet = new DataSet();
                    userAdapter.Fill(userDataSet);
                }

                ReplaceWordStub("{Employee}", userDataSet.Tables[0].Rows[0]["Логин"].ToString(), wordDocument);
                for (int i = 0, count = 2; i < countOfOrdersEachType.Rows.Count; i++, count++)
                {
                    tab.Cell(count, 1).Range.Text = (i + 1).ToString();
                    tab.Cell(count, 2).Range.Text = countOfOrdersEachType.Rows[i].Cells[0].Value.ToString();
                    tab.Cell(count, 3).Range.Text = countOfOrdersEachType.Rows[i].Cells[1].Value.ToString();
                    tab.Cell(count, 4).Range.Text = countOfOrdersEachType.Rows[i].Cells[2].Value.ToString();

                    if (count < countOfOrdersEachType.Rows.Count + 1)
                        tab.Rows.Add();
                }

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

        private void saveCountOfOrdersEachEmployeeStatistic_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Статистика_КоличествоЗаказовКаждогоСотрудника_{DateTime.Now.ToShortDateString()}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Статистика_КоличествоЗаказовКаждогоСотрудника.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                Word.Table tab = wordDocument.Tables[1];
                ReplaceWordStub("{Date}", DateTime.Now.ToString(), wordDocument);
                ReplaceWordStub("{Date1}", guna2DateTimePicker1.Value.ToShortDateString(), wordDocument);
                ReplaceWordStub("{Date2}", guna2DateTimePicker2.Value.ToString(), wordDocument);

                SqlDataAdapter userAdapter;
                DataSet userDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    userAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин FROM Пользователи p WHERE p.Номер = {Main.id}", connection);
                    userDataSet = new DataSet();
                    userAdapter.Fill(userDataSet);
                }

                ReplaceWordStub("{Employee}", userDataSet.Tables[0].Rows[0]["Логин"].ToString(), wordDocument);
                for (int i = 0, count = 2; i < employeesOrdersForPeriod.Rows.Count; i++, count++)
                {
                    tab.Cell(count, 1).Range.Text = (i + 1).ToString();
                    tab.Cell(count, 2).Range.Text = employeesOrdersForPeriod.Rows[i].Cells[0].Value.ToString();
                    tab.Cell(count, 3).Range.Text = employeesOrdersForPeriod.Rows[i].Cells[1].Value.ToString();
                    tab.Cell(count, 4).Range.Text = employeesOrdersForPeriod.Rows[i].Cells[2].Value.ToString();

                    if (count < employeesOrdersForPeriod.Rows.Count + 1)
                        tab.Rows.Add();
                }

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

        private void saveDessertsWithIngredientStatistic_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Статистика_Десерты_{ingredientComboBox.Text}_{DateTime.Now.ToShortDateString()}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Статистика_ДесертыСВыбраннымИнгредиентом.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                Word.Table tab = wordDocument.Tables[1];
                ReplaceWordStub("{Date}", DateTime.Now.ToString(), wordDocument);
                ReplaceWordStub("{Ingredient}", ingredientComboBox.Text.ToString(), wordDocument);

                SqlDataAdapter userAdapter;
                DataSet userDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    userAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин FROM Пользователи p WHERE p.Номер = {Main.id}", connection);
                    userDataSet = new DataSet();
                    userAdapter.Fill(userDataSet);
                }

                ReplaceWordStub("{Employee}", userDataSet.Tables[0].Rows[0]["Логин"].ToString(), wordDocument);
                for (int i = 0, count = 2; i < dessertsWhithChosenIngr.Rows.Count; i++, count++)
                {
                    tab.Cell(count, 1).Range.Text = (i + 1).ToString();
                    tab.Cell(count, 2).Range.Text = dessertsWhithChosenIngr.Rows[i].Cells[0].Value.ToString();
                    tab.Cell(count, 3).Range.Text = dessertsWhithChosenIngr.Rows[i].Cells[1].Value.ToString();
                    tab.Cell(count, 4).Range.Text = dessertsWhithChosenIngr.Rows[i].Cells[2].Value.ToString();
                    tab.Cell(count, 5).Range.Text = dessertsWhithChosenIngr.Rows[i].Cells[3].Value.ToString();

                    if (count < dessertsWhithChosenIngr.Rows.Count + 1)
                        tab.Rows.Add();
                }

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

        private void saveCountOfOrdersEachUserStatistic_Click(object sender, EventArgs e)
        {
            textDialog.FileName = $"Статистика_КоличествоЗаказовКаждогоПользователя_{DateTime.Now.ToShortDateString()}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.docx";
            if (textDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = textDialog.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var path1 = Path.Combine(Environment.CurrentDirectory, @"Статистика_КоличествоЗаказовКаждогоПользователя.docx");
            var wordDocument = wordApp.Documents.Open(path1);
            try
            {
                Word.Table tab = wordDocument.Tables[1];
                ReplaceWordStub("{Date}", DateTime.Now.ToString(), wordDocument);

                SqlDataAdapter userAdapter;
                DataSet userDataSet;
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    userAdapter = new SqlDataAdapter($"SELECT p.Имя, p.Логин FROM Пользователи p WHERE p.Номер = {Main.id}", connection);
                    userDataSet = new DataSet();
                    userAdapter.Fill(userDataSet);
                }

                ReplaceWordStub("{Employee}", userDataSet.Tables[0].Rows[0]["Логин"].ToString(), wordDocument);
                for (int i = 0, count = 2; i < countOfOrdersEachUser.Rows.Count; i++, count++)
                {
                    tab.Cell(count, 1).Range.Text = (i + 1).ToString();
                    tab.Cell(count, 2).Range.Text = countOfOrdersEachUser.Rows[i].Cells[0].Value.ToString();
                    tab.Cell(count, 3).Range.Text = countOfOrdersEachUser.Rows[i].Cells[1].Value.ToString();
                    tab.Cell(count, 4).Range.Text = countOfOrdersEachUser.Rows[i].Cells[2].Value.ToString();

                    if (count < countOfOrdersEachUser.Rows.Count + 1)
                        tab.Rows.Add();
                }

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
