using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmDSYeuCauTuVan : Form
    {
        BUS_YeuCauTuVan bUS_YeuCauTuVan = new BUS_YeuCauTuVan();
        public frmDSYeuCauTuVan()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_YeuCauTuVan.TimYCTV(txtTimYCTV.Text);
        }

        private void frmYeuCauTuVan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_YeuCauTuVan.SelectYCTV();
        }

        private void rbtnDaTiepNhan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_YeuCauTuVan.LocYCTV("Đã Tiếp Nhận");
        }

        private void rdnChuaTiepNhan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_YeuCauTuVan.LocYCTV("Chưa Tiếp Nhận");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmThongTinLead frm = new frmThongTinLead();
            //frm.Show();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbXoaLoc_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_YeuCauTuVan.SelectYCTV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhachHang();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhoaHoc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Hide();
            var form2 = new frmDSQuyDinhGiamGia();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
