using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDSQuyDinhGiamGia : Form
    {
        public frmDSQuyDinhGiamGia()
        {
            InitializeComponent();
        }

        private void frmDSQuyDinhGiamGia_Load(object sender, EventArgs e)
        {
            lb_PIC_Name.Text = SharedResources.TenPIC;
            lb_ChucVuPIC.Text = SharedResources.ChucVu;
        }

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhoaHoc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhachHang();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
