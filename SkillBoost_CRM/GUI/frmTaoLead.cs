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
    public partial class frmTaoLead : Form
    {
        DTO_Lead dTO_Lead = new DTO_Lead();
        DTO_YeuCauTuVan dTO_YeuCauTuVan = new DTO_YeuCauTuVan();
        DTO_ChiTietKhoaHocThuocYCTV khThuocYCTV = new DTO_ChiTietKhoaHocThuocYCTV();
        DTO_KhoaHoc dTO_KhoaHoc = new DTO_KhoaHoc();

        BUS_Lead bUS_Lead = new BUS_Lead();


        DataTable dtKhoaHoc = new DataTable();
        DataTable dt1KhoaHoc = new DataTable();

        string maTuVanMoiTao;

        void LoadcbNguonLead()
        {
            List<string> danhsachDuLieuNguonLead = new List<string>();
            danhsachDuLieuNguonLead.Add("Facebook");
            danhsachDuLieuNguonLead.Add("Website");
            danhsachDuLieuNguonLead.Add("Truyền miệng");
            danhsachDuLieuNguonLead.Add("LinkedIn");
            cbNguonLead.DataSource = danhsachDuLieuNguonLead;
        }
        void LoadcbGioiTinh()
        {
            List<string> danhsachGioiTinh = new List<string>();
            danhsachGioiTinh.Add("Nam");
            danhsachGioiTinh.Add("Nữ");
            cbGioiTinh.DataSource = danhsachGioiTinh;
        }
        public void LoadDanhSachKhoaHoc()
        {
            //dtKhoaHoc.Columns[1].ColumnName = "Mã khóa học";
            //dtKhoaHoc.Columns[2].ColumnName = "Tên khóa học";
            //dtKhoaHoc.Columns[3].ColumnName = "Mô tả khóa học";
            //dtKhoaHoc.Columns[4].ColumnName = "Thời lượng khóa học";
            //dtKhoaHoc.Columns[5].ColumnName = "Giảng viên";
            //dtKhoaHoc.Columns[6].ColumnName = "Mức độ khóa học";
            //dtKhoaHoc.Columns[7].ColumnName = "Số lượng học viên tối đa";
            //dtKhoaHoc.Columns[8].ColumnName = "Giá tiền";
            //dtKhoaHoc.Columns[9].ColumnName = "Ngày khai giảng";
            //dtKhoaHoc.Columns[10].ColumnName = "Ngày bế giảng";
            //dtKhoaHoc.Columns[11].ColumnName = "Đánh giá khóa học";
            //dtKhoaHoc.Columns[12].ColumnName = "Trạng thái khóa học";
            //dtKhoaHoc.Columns[13].ColumnName = "Mã loại khóa học";
            //dtKhoaHoc.Columns[14].ColumnName = "Tạo vào lúc";
            //dtKhoaHoc.Columns[15].ColumnName = "Tạo bởi";
            //dtKhoaHoc.Columns[16].ColumnName = "Chỉnh sửa lần cuối vào lúc";
            //dtKhoaHoc.Columns[17].ColumnName = "Chỉnh sửa lần cuối bởi";
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
            dtKhoaHoc.Columns.Add("Mã khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Tên khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Mô tả khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Thời lượng khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Giảng viên", typeof(string));
            dtKhoaHoc.Columns.Add("Mức độ khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Số lượng học viên tối đa", typeof(string));
            dtKhoaHoc.Columns.Add("Giá tiền", typeof(float));

            //dataGridViewKhoaHocKHQuanTam.Columns[9].HeaderText = "Ngày khai giảng";
            //dataGridViewKhoaHocKHQuanTam.Columns[10].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[11].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[12].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[13].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[14].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[15].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[16].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[17].Visible = false;

        }

        private void frmTaoLead_Load(object sender, EventArgs e)
        {
            //// Add cot cho dtKhoaHoc
            //dtKhoaHoc.Columns.Add("Mã khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Tên khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Mô tả khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Thời lượng khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Giảng viên", typeof(string));
            //dtKhoaHoc.Columns.Add("Mức độ khóa học", typeof(string));
            //dtKhoaHoc.Columns.Add("Số lượng học viên tối đa", typeof(string));
            //dtKhoaHoc.Columns.Add("Giá tiền", typeof(float));

            LoadNgheNghiep();
            LoadcbNguonLead();
            LoadKhoaHoc();
            LoadcbGioiTinh();
            LoadDanhSachKhoaHoc();
        }
        public void LoadKhoaHoc()
        {
            cbKhoaHoc.DataSource = bUS_Lead.SelectKhoaHoc().Tables["KhoaHoc"];
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }
        public frmTaoLead()
        {
            InitializeComponent();
        }
        public void LoadNgheNghiep()
        {
            cbNgheNghiep.DataSource = bUS_Lead.SelectNgheNghiep().Tables["NgheNghiep"];
            cbNgheNghiep.DisplayMember = "TenNgheNghiep";
            cbNgheNghiep.ValueMember = "MaNgheNghiep";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            SharedResources.MaPIC = "STA3";
            SharedResources.TenPIC = "Võ Anh Thư";
            DTO_Lead newLead = new DTO_Lead();

            newLead.HoTenLead = txtHoten.Text;
            newLead.GioiTinhLead = cbGioiTinh.Text;
            newLead.EmailLead = txtEmail.Text;
            newLead.NguonLead = cbNguonLead.Text;
            newLead.MaNgheNghiep = cbNgheNghiep.SelectedValue.ToString();
            newLead.TenNgheNghiep = cbNgheNghiep.Text;
            newLead.TrangThaiLead = "Đang tư vấn";
            newLead.LyDoTrangThaiLead = "Tạo trực tiếp";
            newLead.LeadTuKHCu = null;
            newLead.NgaySinhLead = (DateTime)dateTimePickerNgaySinh.Value;
            newLead.SoDienThoaiLead = txtSoDienThoai.Text;
            newLead.TenNVPhuTrachLead = SharedResources.TenPIC;
            newLead.GhiChuLead = txtGhiChu.Text;
            newLead.MaNVPhuTrachLead = SharedResources.MaPIC;
            newLead.ChinhSuaLanCuoiBoi = SharedResources.MaPIC;
            newLead.TaoBoi = "Hệ thống";
            newLead.TaoVaoLuc = DateTime.Now;
            newLead.ChinhSuaLanCuoiVaoLuc = DateTime.Now;
            switch (bUS_Lead.ThemLead(newLead))
            {
                case "Success":
                    MessageBox.Show("Tạo Lead mới thành công");
                    break;

                case "Fail":
                    MessageBox.Show("Tạo Lead mới thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi tạo Lead!");
                    break;
            }


            string MaLeadMoi = bUS_Lead.SelectLead();
            dTO_YeuCauTuVan.TenLeadYeuCau = txtHoten.Text;
            dTO_YeuCauTuVan.NgaySinhLeadYeuCau = (DateTime)dateTimePickerNgaySinh.Value;
            dTO_YeuCauTuVan.EmailLeadYeuCau = txtEmail.Text;
            dTO_YeuCauTuVan.SDTLeadYeuCau = txtSoDienThoai.Text;
            dTO_YeuCauTuVan.GhiChuYCTV = txtGhiChu.Text;
            dTO_YeuCauTuVan.TrangThaiYCTV = "Đang tư vấn";
            dTO_YeuCauTuVan.TaoVaoLuc = DateTime.Now;
            dTO_YeuCauTuVan.TaoBoiLead = MaLeadMoi;
            switch (bUS_Lead.TaoTuVanMoi(dTO_YeuCauTuVan))
            {
                case "Success":
                    MessageBox.Show("Tạo yêu cầu tư vấn mới thành công");
                    break;

                case "Fail":
                    MessageBox.Show("Tạo yêu cầu tư vấn mới thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi tạo yêu cầu tư vấn!");
                    break;
            }

            string maTuVanMoiTao = bUS_Lead.SelectTuVanMoiTao();
            // Thêm dô Chi tiết khóa học thuộc báo giá
            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                khThuocYCTV.MaTuVan = maTuVanMoiTao;
                khThuocYCTV.MaKhoaHoc = dr["Mã khóa học"].ToString();
                khThuocYCTV.TenKhoaHoc = dr["Tên khóa học"].ToString();
                khThuocYCTV.GiangVien = dr["Giảng viên"].ToString();
                khThuocYCTV.GiaTien = float.Parse(dr["Giá tiền"].ToString());

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
            this.Hide();
            var form2 = new frmDSLead();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDSLead dsLead = new frmDSLead();
            dsLead.Closed += (s, args) => this.Close();
            dsLead.Show();

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnXoaKhoaHoc_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Khóa học chưa được thêm vào danh sách. Không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSLead();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
