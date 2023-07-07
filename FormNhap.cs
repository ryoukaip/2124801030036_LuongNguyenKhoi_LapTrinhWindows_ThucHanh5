using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2124801030036_LuongNguyenKhoi_LapTrinhWindows_ThucHanh5
{
    public partial class FormNhap : Form
    {
        private static SQLiteConnection conn;
        public FormNhap()
        {
            InitializeComponent();
            conn = SQLiteHandler.openConnection();
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            // clear all textboxes
            textBox_lineUp.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_specs.Clear();
            textBox_lineUp.Focus();
        }

        private bool checkEmpty()
        {
            if (textBox_lineUp.Text == "" || textBox_name.Text == "" || textBox_price.Text == "" || textBox_specs.Text == "")
            {
                return true;
            }
            return false;
        }

        private void button_writeToSQL_Click(object sender, EventArgs e)
        {
            bool endsWithDot = textBox_price.Text.EndsWith(".");
            if (endsWithDot || checkEmpty()){
                // warning messagebox
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button_clearAll_Click(sender, e);
                return;
            }
            // sql add command
            // table name: Computers
            // columns: Brands, Line Up, Name, Specs, Price
            SQLiteHandler.executeCommand(conn, "INSERT INTO Computers (Brands, \"Line up\", Name, Specs, Price) VALUES ('" + comboBox_brands.Text + "', '" + textBox_lineUp.Text + "', '" + textBox_name.Text + "', '" + textBox_specs.Text + "', '" + textBox_price.Text + "')");
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // Ignore the key press event
                e.Handled = true;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
            // close sql connection
            SQLiteHandler.closeConnection(conn);
        }
    }
}
