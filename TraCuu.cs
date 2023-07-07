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
    public partial class TraCuu : Form
    {
        public static SQLiteConnection conn;
        public static DataTable dt;
        public static List<string> brandList;
        public static List<string> lineUpList;
        public TraCuu()
        {
            InitializeComponent();
            conn = SQLiteHandler.openConnection();
            dt = SQLiteHandler.toDataTable(conn, "SELECT * FROM Computers");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Width = 330;
            label_value.Text = dt.Rows.Count.ToString();
            brandList = SQLiteHandler.OneColumnToList(conn, "SELECT DISTINCT Brands FROM Computers");
            // add brands to combobox
            foreach (string brand in brandList)
            {
                comboBox1.Items.Add(brand);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tất cả")
            {
                dt = SQLiteHandler.toDataTable(conn, "SELECT * FROM Computers");
                dataGridView1.DataSource = dt;
                label_value.Text = dt.Rows.Count.ToString();
                comboBox2.Items.Clear();
            }
            else
            {
                dt = SQLiteHandler.toDataTable(conn, "SELECT * FROM Computers WHERE Brands = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = dt;
                comboBox2.Items.Clear();
                lineUpList = SQLiteHandler.OneColumnToList(conn, "SELECT DISTINCT \"Line up\" FROM Computers WHERE Brands = '" + comboBox1.Text + "'");
                // add line up to combobox
                foreach (string lineUp in lineUpList)
                {
                    comboBox2.Items.Add(lineUp);
                }
                label_value.Text = dt.Rows.Count.ToString();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = SQLiteHandler.toDataTable(conn, "SELECT * FROM Computers WHERE Brands = '" + comboBox1.Text + "' AND \"Line up\" = '" + comboBox2.Text + "'");
            dataGridView1.DataSource = dt;
            label_value.Text = dt.Rows.Count.ToString();
        }

        private void TraCuu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close connection
            SQLiteHandler.closeConnection(conn);
        }
    }
}
