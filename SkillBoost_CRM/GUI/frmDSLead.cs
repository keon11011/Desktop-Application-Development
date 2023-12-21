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
using DTO;

namespace GUI
{
    public partial class frmDSLead : Form
    {
        BUS_Lead bUS_Lead = new BUS_Lead();
        DTO_Lead dTO_Lead = new DTO_Lead();
        public frmDSLead()
        {
            InitializeComponent();
        }
        public void LoadDanhSachLead()
        {
            dataGridViewDSLead.DataSource = bUS_Lead.DanhSachLead(dTO_Lead);
        }

        private void frmDSLead_Load(object sender, EventArgs e)
        {
            LoadDanhSachLead();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaoLead taoLead = new frmTaoLead();
            taoLead.Closed += (s, args) => this.Close();
            taoLead.Show();
        }

        private void dataGridViewDSLead_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDSLead.RowCount > 0)
            {
                SharedResources.MaLead = dataGridViewDSLead[1, dataGridViewDSLead.CurrentRow.Index].Value.ToString();
                this.Hide();
                var frm1 = new frmThongTinLead();
                frm1.Closed += (s, args) => this.Close();
                frm1.Show();
            }
            
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSYeuCauTuVan();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSKhachHang();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSQuyDinhGiamGia();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSKhoaHoc();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmSoLieuBaoCao();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }
    }
}
