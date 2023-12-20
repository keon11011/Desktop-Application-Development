using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmYCTV_KhachHang : Form
    {
        BUS_YeuCauTuVan bUS_YeuCauTuVan = new BUS_YeuCauTuVan();
        BUS_Lead bUS_Lead = new BUS_Lead();
        public frmYCTV_KhachHang()
        {
            InitializeComponent();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SelectKhoaHoc()
        {
            cbKhoaHoc.DataSource = bUS_YeuCauTuVan.SelecKhoaHoc();
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
        }

        private void frmYCTV_KhachHang_Load(object sender, EventArgs e)
        {
            SelectKhoaHoc();
        }

        private void btnGuiYCTV_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (txtHoten.Text == "")
            {
                errorProvider2.SetError(txtHoten, "Bạn chưa nhập tên"); return;

            }

            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 15)
                        {
                errorProvider2.SetError(dtpNgaySinh, "Bạn phải trên 15 tuổi"); return;
                
                        }
            if (txtEmail.Text == "")
            {
                errorProvider2.SetError(txtEmail, "Bạn chưa nhập Email"); return;
                    }
            if (txtSdt.Text == "")
            {
                errorProvider2.SetError(txtSdt, "Bạn chưa nhập Số điện thoại"); return;
                }
            if (txtSdt.ToString().Length < 10 || txtSdt.ToString().Substring(0,0) != "0")
            {
                errorProvider2.SetError(txtSdt, "Số điện thoại bạn nhập không hợp lệ"); return;
            }

            DTO_YeuCauTuVan yctv = new DTO_YeuCauTuVan();
            yctv.TenLeadYeuCau = txtHoten.Text;
            yctv.NgaySinhLeadYeuCau = dtpNgaySinh.Value;
            yctv.EmailLeadYeuCau = txtEmail.Text;
            yctv.SDTLeadYeuCau = txtSdt.Text;
            yctv.GhiChuYCTV = txtGhichu.Text;
            yctv.TrangThaiYCTV = "Chờ tiếp nhận";
            yctv.TaoVaoLuc = DateTime.Now;
            yctv.TaoBoiLead = "";   
            yctv.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();

            HoatDongLead HDLead = new HoatDongLead();

            if (bUS_YeuCauTuVan.InsertLeadcuaYCTV(ref yctv)) //--> Insert YCTV + HDLead
                {
                if (bUS_YeuCauTuVan.InsertChiTietKhoaHoc(yctv))
                {
                    
                    MessageBox.Show($"Gửi Yêu cầu tư vấn thành công!");
                    HDLead.MaLead = yctv.TaoBoiLead;
                    HDLead.TenHDLead = "Yêu cầu tư vấn";
                    HDLead.LoaiHDLead = "Yêu cầu";
                    HDLead.HDLeadDuocTaoBoi = "Lead";
                    HDLead.MaNVPhuTrachHDLead = "STA0";
                    HDLead.TenNVPhuTrachHDLead = "Chưa tiếp nhận";
                    HDLead.MaEmailDenLead = null;
                    BUS_HoatDongLead bUS_HoatDongLead = new BUS_HoatDongLead();
                    
                    if (bUS_HoatDongLead.ThemHoatDongLead(HDLead))
                    {
                        MessageBox.Show("Tạo Hoạt động Lead thành công");
                        txtHoten.Text = "";
                        dtpNgaySinh.Value = DateTime.Now;
                        txtEmail.Text = "";
                        txtGhichu.Text = "";
                        txtSdt.Text = "";
                    }
                    else MessageBox.Show("Tạo Hoạt động Lead thất bại");
                }
                else MessageBox.Show($"Gửi yêu cầu tư vấn thất bại");
            }
            else MessageBox.Show($"Gửi Yêu cầu tư vấn thất bại!");
            
        }
    }
}

