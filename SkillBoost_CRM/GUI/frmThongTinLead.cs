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
        DTO_ChiTietKhoaHocThuocYCTV khThuocYCTV = new DTO_ChiTietKhoaHocThuocYCTV();
        BUS_Lead bUS_Lead = new BUS_Lead();
        DTO_KhoaHoc dTO_KhoaHoc = new DTO_KhoaHoc();

        DataTable dt1KhoaHoc = new DataTable();
        DataTable dtYCTVMoiTao = new DataTable();
        DataTable dtKhoaHoc = new DataTable();

        string maTuVanMoiTao;
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
            dtKhoaHoc = bUS_Lead.DanhSachKhoaHoc(dTO_Lead).Tables["KhoaHoc"];
            dtKhoaHoc.Columns[1].ColumnName = "Mã khóa học";
            dtKhoaHoc.Columns[2].ColumnName = "Tên khóa học";
            dtKhoaHoc.Columns[3].ColumnName = "Mô tả khóa học";
            dtKhoaHoc.Columns[4].ColumnName = "Thời lượng khóa học";
            dtKhoaHoc.Columns[5].ColumnName = "Giảng viên";
            dtKhoaHoc.Columns[6].ColumnName = "Mức độ khóa học";
            dtKhoaHoc.Columns[7].ColumnName = "Số lượng học viên tối đa";
            dtKhoaHoc.Columns[8].ColumnName = "Giá tiền";
            dtKhoaHoc.Columns[9].ColumnName = "Ngày khai giảng";
            dtKhoaHoc.Columns[10].ColumnName = "Ngày bế giảng";
            dtKhoaHoc.Columns[11].ColumnName = "Đánh giá khóa học";
            dtKhoaHoc.Columns[12].ColumnName = "Trạng thái khóa học";
            dtKhoaHoc.Columns[13].ColumnName = "Mã loại khóa học";
            dtKhoaHoc.Columns[14].ColumnName = "Tạo vào lúc";
            dtKhoaHoc.Columns[15].ColumnName = "Tạo bởi";
            dtKhoaHoc.Columns[16].ColumnName = "Chỉnh sửa lần cuối vào lúc";
            dtKhoaHoc.Columns[17].ColumnName = "Chỉnh sửa lần cuối bởi";
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;

            //dataGridViewKhoaHocKHQuanTam.Columns[0].HeaderText = "Mã khóa học";
            //dataGridViewKhoaHocKHQuanTam.Columns[1].HeaderText = "Tên khóa học";
            //dataGridViewKhoaHocKHQuanTam.Columns[2].HeaderText = "Mô tả khóa học";
            //dataGridViewKhoaHocKHQuanTam.Columns[3].HeaderText = "Thời lượng khóa học";
            //dataGridViewKhoaHocKHQuanTam.Columns[4].HeaderText = "Giảng viên";
            //dataGridViewKhoaHocKHQuanTam.Columns[5].HeaderText = "Mức độ khóa học";
            //dataGridViewKhoaHocKHQuanTam.Columns[6].HeaderText = "Số lượng học viên tối đa";
            //dataGridViewKhoaHocKHQuanTam.Columns[7].HeaderText = "Giá tiền";
            //// dataGridViewKhoaHocKHQuanTam.Columns[8].HeaderText = "Ngày khai giảng";
            // dataGridViewKhoaHocKHQuanTam.Columns[9].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[10].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[11].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[12].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[13].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[14].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[15].Visible = false;
            // dataGridViewKhoaHocKHQuanTam.Columns[16].Visible = false;

        }


        private void frmThongTinLead_Load(object sender, EventArgs e)
        {
            // Add cot cho dtKhoaHoc
            //dtKhoaHoc.Columns.Add("Mã khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Tên khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Mô tả khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Thời lượng khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Giảng viên", typeof(string));
            //dtKhoaHoc.Columns.Add("Mức độ khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Số lượng học viên tối đa", typeof(string));
            //dtKhoaHoc.Columns.Add("Giá tiền", typeof(float));


            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();
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
            cbKhoaHoc.Enabled = true;
            btnThemKhoaHoc.Enabled = true;
            btnXoaKhoaHoc.Enabled = true;
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
                    MessageBox.Show("Lỗi thay đổi thông tin Lead!");
                    break;
            }

            //code tiếp

            maTuVanMoiTao = bUS_Lead.SelectTuVanMoiTao();
            khThuocYCTV.MaTuVan = maTuVanMoiTao;
            // Xóa dô Chi tiết khóa học thuộc báo giá
            switch (bUS_Lead.XoaChiTietKhoaHocThuocYCTV(khThuocYCTV))
            {
                case "Success":
                    MessageBox.Show("Xóa chi tiết khóa học thuộc yêu cầu tư vấn mới thành công");
                    break;

                case "Fail":
                    MessageBox.Show("Xóa chi tiết khóa học thuộc yêu cầu tư vấn mới thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi xóa khóa học yêu cầu tư vấn mới!");
                    break;
            }
            // Thêm dô Chi tiết khóa học thuộc báo giá
            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                khThuocYCTV.MaTuVan = maTuVanMoiTao;
                khThuocYCTV.MaKhoaHoc = dr[1].ToString();
                khThuocYCTV.TenKhoaHoc = dr[1].ToString();
                khThuocYCTV.GiangVien = dr[5].ToString();
                khThuocYCTV.GiaTien = float.Parse(dr[8].ToString());

                switch (bUS_Lead.ThemChiTietKhoaHocThuocYeuCauTuVan(khThuocYCTV))
                {
                    case "Success":
                        MessageBox.Show("Thêm chi tiết khóa học thuộc yêu cầu tư vấn mới thành công");
                        break;

                    case "Fail":
                        MessageBox.Show("Thêm chi tiết khóa học thuộc yêu cầu tư vấn mới thất bại");
                        break;

                    case "Exception":
                        MessageBox.Show("Lỗi thêm khóa học yêu cầu tư vấn mới!");
                        break;
                }
            }
        }

        private void btnUnfollow_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmXacNhanHuyTheoDoi();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            //switch (bUS_Lead.HuyTheoDoiTuVan(dTO_Lead))
            //{
            //    case "Success":
            //        MessageBox.Show("Đã ngừng theo dõi Lead");
            //        break;

            //    case "Fail":
            //        MessageBox.Show("Thao tác thất bại");
            //        break;

            //    case "Exception":
            //        MessageBox.Show("Lỗi khác!");
            //        break;
            //}
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            string selectedMaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            bool existMaKhoaHoc = false;

            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                if (dr.Field<string>("Mã khóa học") == selectedMaKhoaHoc)
                {
                    existMaKhoaHoc = true;
                    break;
                }
            }
            if (existMaKhoaHoc)
            {
                MessageBox.Show("Khóa học này đã được thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataRow newRow = dtKhoaHoc.NewRow();
                newRow["Mã khóa học"] = selectedMaKhoaHoc;
                newRow["Tên khóa học"] = cbKhoaHoc.Text;

                dTO_KhoaHoc.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
                //dTO_KhoaHoc.MaKhoaHoc = selectedMaKhoaHoc;
                dt1KhoaHoc = bUS_Lead.Select1KhoaHoc(dTO_KhoaHoc);
                newRow["Mô tả khóa học"] = dt1KhoaHoc.Rows[0][2].ToString();
                newRow["Thời lượng khóa học"] = dt1KhoaHoc.Rows[0][3];
                newRow["Giảng viên"] = dt1KhoaHoc.Rows[0][4];
                newRow["Mức độ khóa học"] = dt1KhoaHoc.Rows[0][5];
                newRow["Số lượng học viên tối đa"] = dt1KhoaHoc.Rows[0][6];
                newRow["Giá tiền"] = dt1KhoaHoc.Rows[0][7];

                dtKhoaHoc.Rows.Add(newRow);

                dataGridViewKhoaHocKHQuanTam.Refresh();
            }
        }

        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)
        {
            string selectedMaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            bool existMaKhoaHoc = false;
            DataRow delRow = dtKhoaHoc.NewRow();

            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                if (dr.Field<string>("Mã khóa học") == selectedMaKhoaHoc)
                {
                    existMaKhoaHoc = true;
                    delRow = dr;
                    break;
                }
            }
            if (existMaKhoaHoc)
            {
                dtKhoaHoc.Rows.Remove(delRow);
            }
            else
            {
                MessageBox.Show("Khóa học chưa được thêm vào. Không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnHuyChinhSua_Click(object sender, EventArgs e)
        {
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();
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
            txtEmail.ReadOnly = true;
            txtHoten.ReadOnly = true;   
            txtGhiChu.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            cbNgheNghiep.Enabled = false;
            cbNguonLead.Enabled = false;
            dateTimePickerNgaySinh.Enabled = false;
            cbKhoaHoc.Enabled = false;
            btnThemKhoaHoc.Enabled = false;
            btnXoaKhoaHoc.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmXacNhanXoaLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSBaoGiaCuaLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSHoatDongLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }
    }
}