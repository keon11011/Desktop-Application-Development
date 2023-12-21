using BUS;
using DTO;
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
    public partial class frmTaoHoatDongLead : Form
    {
        BUS_HoatDongLead bUSHoatDongLead = new BUS_HoatDongLead();

        public frmTaoHoatDongLead()
        {
            InitializeComponent();
        }

        private void frmTaoHoatDongLead_Load(object sender, EventArgs e)
        {
            //Đưa data lên ComboBox LoaiHDLead
            lb_LeadName.Text = SharedResources.TenLead;

            cbLoaiHoatDong.Items.Add("Yêu cầu");
            cbLoaiHoatDong.Items.Add("Tư vấn");

            txtTenHoatDongLead.Text = "";
            cbLoaiHoatDong.Text = "";
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            DTO_HoatDongLead newHDLead = new DTO_HoatDongLead();

            newHDLead.MaLead = SharedResources.MaLead;
            newHDLead.TenHDLead = txtTenHoatDongLead.Text;
            newHDLead.LoaiHDLead = cbLoaiHoatDong.Text;
            newHDLead.HDLeadDuocTaoBoi = "PIC";
            newHDLead.MaNVPhuTrachHDLead = SharedResources.MaPIC;
            newHDLead.TenNVPhuTrachHDLead = SharedResources.TenPIC;
            newHDLead.MaEmailDenLead = null;


            if (bUSHoatDongLead.ThemHoatDongLead(newHDLead))
            {
                DialogResult result = MessageBox.Show("Tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    frmDSHoatDongLead danhSachHoatDongLead = new frmDSHoatDongLead();
                    danhSachHoatDongLead.Closed += (s, args) => this.Close();
                    danhSachHoatDongLead.Show();
                }
            }
            else
            {
                MessageBox.Show("Tạo thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSYeuCauTuVan();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSYeuCauTuVan();
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

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhoaHoc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
