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
        public void LoadKhoaHoc()
        {
            cbKhoaHoc.DataSource = bUS_Lead.SelectKhoaHoc().Tables["KhoaHoc"];
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }
         public void LoadDanhSachKhoaHoc()
        {
            dataGridViewKhoaHocKHQuanTam.DataSource = bUS_Lead.DanhSachKhoaHoc(dTO_Lead).Tables["KhoaHoc"];
            dataGridViewKhoaHocKHQuanTam.Columns[0].HeaderText = "Mã khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[2].HeaderText = "Mô tả khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[3].HeaderText = "Thời lượng khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[4].HeaderText = "Giảng viên";
            dataGridViewKhoaHocKHQuanTam.Columns[5].HeaderText = "Mức độ khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[6].HeaderText = "Số lượng học viên tối đa";
            dataGridViewKhoaHocKHQuanTam.Columns[7].HeaderText = "Giá tiền";
            dataGridViewKhoaHocKHQuanTam.Columns[8].HeaderText = "Ngày khai giảng";
            dataGridViewKhoaHocKHQuanTam.Columns[9].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[10].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[11].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[12].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[13].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[14].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[15].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[16].Visible = false;

        }


        private void frmThongTinLead_Load_1(object sender, EventArgs e)
        {
            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();
            dTO_Lead.MaLead = "LEA003";
            bUS_Lead.SelectLead(ref dTO_Lead);
            txtLeadID.Text = dTO_Lead.MaLead;
            txtHoten.Text = dTO_Lead.HoTenLead;
            dateTimePickerNgaySinh.Text = dTO_Lead.NgaySinhLead.ToString();
            txtEmail.Text = dTO_Lead.EmailLead;
            txtSoDienThoai.Text = dTO_Lead.SoDienThoaiLead;
            txtPIC.Text = dTO_Lead.TenNVPhuTrachLead;
            cbNgheNghiep.Text = dTO_Lead.TenNgheNghiep;
            cbNguonLead.Text = dTO_Lead.NguonLead;
            txtGhiChu.Text = dTO_Lead.GhiChuLead;
            txtTrangThaiLead.Text = dTO_Lead.TrangThaiLead;
            LoadDanhSachKhoaHoc();
        }
        void LoadcbNguonLead()
        {
            List<string> danhsachDuLieuNguonLead = new List<string>();
            danhsachDuLieuNguonLead.Add("Facebook");
            danhsachDuLieuNguonLead.Add("Website");
            danhsachDuLieuNguonLead.Add("Truyền miệng");
            danhsachDuLieuNguonLead.Add("LinkedIn");
            cbNguonLead.DataSource = danhsachDuLieuNguonLead;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnHuyChinhSua.Show();
            btnLuuThayDoi.Show();
            txtHoten.ReadOnly = false;
            dateTimePickerNgaySinh.Enabled = true;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            cbNgheNghiep.Enabled = true;
            cbNguonLead.Enabled = true;
            txtGhiChu.ReadOnly = false;
            dataGridViewKhoaHocKHQuanTam.ReadOnly = false;
            LoadNgheNghiep();
            LoadcbNguonLead();
            LoadKhoaHoc();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            dTO_Lead.HoTenLead = txtHoten.Text;
            dTO_Lead.NgaySinhLead = dateTimePickerNgaySinh.Value;
            dTO_Lead.EmailLead = txtEmail.Text;
            dTO_Lead.NguonLead = cbNguonLead.Text;
            dTO_Lead.MaNgheNghiep = cbNgheNghiep.SelectedValue.ToString();
            dTO_Lead.TenNgheNghiep = cbNgheNghiep.Text;
            dTO_Lead.GhiChuLead = txtGhiChu.Text;
            dTO_Lead.SoDienThoaiLead = txtSoDienThoai.Text;
            switch (bUS_Lead.SuaThongTinLead(dTO_Lead))
            {
                case "Success":
                    MessageBox.Show("Sửa thông tin Lead thành công");
                    break;

                case "Fail":
                    MessageBox.Show("Sửa thông tin Lead thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác!");
                    break;
            }
        }

        private void btnUnfollow_Click(object sender, EventArgs e)
        {
            switch (bUS_Lead.HuyTheoDoiTuVan(dTO_Lead))
            {
                case "Success":
                    MessageBox.Show("Đã ngừng theo dõi Lead");
                    break;

                case "Fail":
                    MessageBox.Show("Thao tác thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác!");
                    break;
            }
        }
    }
}