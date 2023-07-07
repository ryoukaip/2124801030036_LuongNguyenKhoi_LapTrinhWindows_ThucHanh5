using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2124801030036_LuongNguyenKhoi_LapTrinhWindows_ThucHanh5
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nhậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhap formNhap = new FormNhap();
            formNhap.MdiParent = this;
            formNhap.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuu traCuu = new TraCuu();
            traCuu.MdiParent = this;
            traCuu.Show();
        }
    }
}
