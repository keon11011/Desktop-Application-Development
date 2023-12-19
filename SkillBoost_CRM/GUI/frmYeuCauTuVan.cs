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
    public partial class frmYeuCauTuVan : Form
    {
        BUS_YeuCauTuVan bUS_YeuCauTuVan = new BUS_YeuCauTuVan();
        public frmYeuCauTuVan()
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
            frmThongTinLead frm = new frmThongTinLead();
            frm.Show();
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
    }
}
