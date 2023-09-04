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
    public partial class DessertInOrderRowControl : UserControl
    {
        SqlDataAdapter dessertsAdapter;
        DataSet dessertsDataSet;
        string id;
        DessertsInOrderControl dessertsInOrderControl;
        public DessertInOrderRowControl(string i, DessertsInOrderControl cntrl)
        {
            InitializeComponent();
            id = i;
            dessertsInOrderControl = cntrl;
        }

        private void DessertInOrderRowControl_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                connection.Open();

                dessertsAdapter = new SqlDataAdapter($"SELECT d.Название, dz.Количество " +
                    $"FROM ДесертыВЗаказе dz JOIN Десерты d ON dz.Десерт = d.Номер WHERE dz.Номер = {id}", connection);
                dessertsDataSet = new DataSet();
                dessertsAdapter.Fill(dessertsDataSet);
            }
            var i = dessertsDataSet.Tables[0].Rows.Count;
            dessertLabel.Text = dessertsDataSet.Tables[0].Rows[0]["Название"].ToString();
            countLabel.Text = dessertsDataSet.Tables[0].Rows[0]["Количество"].ToString();
        }
    }
}
