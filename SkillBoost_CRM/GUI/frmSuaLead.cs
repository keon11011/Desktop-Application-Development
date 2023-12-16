using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Runtime.CompilerServices;

namespace GUI
{
    public partial class frmThongTinLead : Form
    {
        DTO_Lead dTO_Lead = new DTO_Lead();
        BUS_Lead bUS_Lead = new BUS_Lead();
        public frmThongTinLead()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinLead_Load(object sender, EventArgs e)
        {
            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();
            dTO_Lead.MaLead = "LEA001";
            bUS_Lead.SelectLead(ref dTO_Lead);
            txtLeadID.Text = dTO_Lead.MaLead;
            txtHoten.Text = dTO_Lead.HoTenLead;
            txtNgaySinh.Text = dTO_Lead.NgaySinhLead.ToString();
            txtEmail.Text = dTO_Lead.EmailLead;
            txtSoDienThoai.Text = dTO_Lead.SoDienThoaiLead;
            txtPIC.Text = dTO_Lead.TenNVPhuTrachLead;
            cbNgheNghiep.Text = dTO_Lead.TenNgheNghiep;
            cbNguonLead.Text = dTO_Lead.NguonLead;
            txtGhiChu.Text = dTO_Lead.GhiChuLead;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuyChinhSua.Show();
            btnLuuThayDoi.Show();
            txtHoten.ReadOnly = false;
        }
    }

}
