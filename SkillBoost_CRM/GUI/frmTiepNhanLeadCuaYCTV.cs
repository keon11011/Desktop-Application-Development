using BUS;
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

namespace GUI
{
    public partial class frmTiepNhanLeadCuaYCTV : Form
    {
        DataTable dtKhoaHoc = new DataTable();
        BUS_HoatDongLead bUS_HoatDongLead = new BUS_HoatDongLead();
        DTO_HoatDongLead dTO_HoatDongLead = new DTO_HoatDongLead();
        BUS_YeuCauTuVan bUS_YeuCauTuVan = new BUS_YeuCauTuVan();
        DTO_Lead dTO_Lead = new DTO_Lead();
        BUS_Lead bUS_Lead = new BUS_Lead();
        public frmTiepNhanLeadCuaYCTV()
        {
            InitializeComponent();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            SharedResources.MaLead = txtLeadID.Text;
            dTO_Lead.MaLead = txtLeadID.Text;
            dTO_Lead.TrangThaiLead = "Đang tư vấn";
            dTO_Lead.MaNVPhuTrachLead = SharedResources.MaPIC;
            dTO_Lead.TenNVPhuTrachLead = SharedResources.TenPIC;
            switch (bUS_YeuCauTuVan.TiepNhanYCTV(SharedResources.MaTuVan))
            {
                case "Success":
                    MessageBox.Show("Đổi trạng thái yêu cầu tư vấn thành công");
                    LoadLaiThongTinLead();
                    switch (bUS_Lead.TiepNhanLead(dTO_Lead))
                    {
                        case "Success":
                            MessageBox.Show("Tiếp nhận Lead thành công");
                            bUS_Lead.TiepNhanLead(dTO_Lead);
                            dTO_HoatDongLead.MaLead = SharedResources.MaLead;
                            dTO_HoatDongLead.TenHDLead = "Tiếp nhận yêu cầu tư vấn";
                            dTO_HoatDongLead.LoaiHDLead = "Điều chỉnh trạng thái";
                            dTO_HoatDongLead.HDLeadDuocTaoBoi = "PIC";
                            dTO_HoatDongLead.MaNVPhuTrachHDLead = SharedResources.MaPIC;
                            dTO_HoatDongLead.TenNVPhuTrachHDLead = SharedResources.TenPIC;
                            dTO_HoatDongLead.MaEmailDenLead = null;
                            if (bUS_HoatDongLead.ThemHoatDongLead(dTO_HoatDongLead))
                            {
                                MessageBox.Show("Ghi nhận hoạt động tiếp nhận Lead thành công");
                                dTO_HoatDongLead.TenHDLead = "Gửi email xác nhận tư vấn";
                                dTO_HoatDongLead.LoaiHDLead = "Email";
                                dTO_HoatDongLead.HDLeadDuocTaoBoi = "Hệ thống";
                                dTO_HoatDongLead.MaEmailDenLead = null;
                                if (bUS_HoatDongLead.ThemHoatDongLead(dTO_HoatDongLead))
                                {
                                    MessageBox.Show("Ghi nhận hoạt động gửi email xác nhận yêu cầu tư vấn thành công");
                                }
                                else
                                {
                                    MessageBox.Show("Ghi nhận hoạt động gửi email xác nhận yêu cầu tư vấn thất bại");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ghi nhận hoạt động tiếp nhận Lead thất bại");
                            }
                            this.Hide();
                            var xoaLead = new frmThongTinLead();
                            xoaLead.Closed += (s, arg) => this.Close();
                            xoaLead.Show();
                            break;

                        case "Fail":
                            MessageBox.Show("Tiếp nhận Lead thất bại");
                            break;

                        case "Exception":
                            MessageBox.Show("Lỗi khác khi tiếp nhận Lead!");
                            break;
                    }
                    break;
                case "Fail":
                    MessageBox.Show("Đổi trạng thái yêu cầu tư vấn thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác khi đổi trạng thái yêu cầu tư vấn!");
                    break;
            }
          
        }

        private void btnQuayLaiDSYCTV_Click(object sender, EventArgs e)
        {
            this.Hide();
            var xoaLead = new frmDSYeuCauTuVan();
            xoaLead.Closed += (s, arg) => this.Close();
            xoaLead.Show();
        }

        private void frmTiepNhanLeadCuaYCTV_Load(object sender, EventArgs e)
        {
            LoadLaiThongTinLead();
        }
        private void LoadLaiThongTinLead()
        {
            //txtHoten.ReadOnly = true;
            //dateTimePickerNgaySinh.Enabled = false;
            //txtEmail.ReadOnly = true;
            //txtSoDienThoai.ReadOnly = true;
            //cbNgheNghiep.Enabled = false;
            //cbNguonLead.Enabled = false;
            //txtGhiChu.ReadOnly = true;
            //dataGridViewKhoaHocKHQuanTam.ReadOnly = true;
            dTO_Lead.MaLead = SharedResources.MaLead;
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
        public void LoadDanhSachKhoaHoc()
        {
            dtKhoaHoc = bUS_Lead.DanhSachKhoaHoc(dTO_Lead).Tables["KhoaHoc"];
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
            dataGridViewKhoaHocKHQuanTam.Columns[0].HeaderText = "Mã khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[1].HeaderText = "Tên khóa học";
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

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSoLieuBaoCao();
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

        private void leadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
