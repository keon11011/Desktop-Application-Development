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
using System.Data.SqlClient;


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
        public void LoadNgheNghiep()
        {
            cbNgheNghiep.DataSource = bUS_Lead.SelectNgheNghiep().Tables["NgheNghiep"];
            cbNgheNghiep.DisplayMember = "TenNgheNghiep";
            cbNgheNghiep.ValueMember = "MaNgheNghiep";
        }

        private void frmThongTinLead_Load_1(object sender, EventArgs e)
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnHuyChinhSua.Show();
            btnLuuThayDoi.Show();
            txtHoten.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtPIC.ReadOnly = false;
            cbNgheNghiep.Enabled = true;
            cbNguonLead.Enabled = true;
            txtPIC.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            dataGridViewKhoaHocKHQuanTam.ReadOnly = false;
            LoadNgheNghiep();

        }

        private void cbNgheNghiep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}