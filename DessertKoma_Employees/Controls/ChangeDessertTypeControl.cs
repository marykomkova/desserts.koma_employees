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
    public partial class ChangeDessertTypeControl : UserControl
    {
        public Main obj;
        public ChangeDessertTypeControl(Main _obj)
        {
            InitializeComponent();
            obj = _obj;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (dessertTypeTextBox.Text.Length == 0 || dessertDescriptionTextBox.Text.Length == 0)
            {
                error_label.Visible = true;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"UPDATE ТипыДесертов SET Название='{dessertTypeTextBox.Text}', Описание='{dessertDescriptionTextBox.Text}' WHERE Номер={Main.dessertTypeId}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                Main.dessertType = dessertTypeTextBox.Text;
                obj.UpgradeType(obj);
                Hide();
            }
        }

        private void dessertTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void dessertDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
