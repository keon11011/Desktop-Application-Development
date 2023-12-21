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
    public partial class frmBaoGia : Form
    {
        BUS_BaoGia busBaoGia = new BUS_BaoGia();
        KhoaHoc khoaHoc = new KhoaHoc();
        DTO_Lead newLead = new DTO_Lead();
        DTO_MaGiamGia newMaGiamGia = new DTO_MaGiamGia();
        DTO_BaoGia newBaoGia = new DTO_BaoGia();
        DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia = new DTO_ChiTietKhoaHocThuocBaoGia();
        DataTable dtKhoaHoc = new DataTable();
        DataTable dt1KhoaHoc = new DataTable();
        DataTable sort_qdGiamGia = new DataTable();
        DataTable dtNgheNghepCuaLead = new DataTable();
        DataTable dtMaGiamGiaMoiTao = new DataTable();
        DataTable dtBaoGiaMoiTao = new DataTable();
        int PhanTramGiamGia = 0;
        string maQuyDinhGiamGiaThoa;
        bool qdGiamGiaThoa = false;
        string maBaoGiaMoiTao;
        public frmBaoGia()
        {
            InitializeComponent();
        }
        void LoadcboKhoaHoc()
        {
            DataTable dt = busBaoGia.SelectAllKhoaHoc();
            cboKhoaHoc.DataSource = dt;
            cboKhoaHoc.ValueMember = "MaKhoaHoc";
            cboKhoaHoc.DisplayMember = "TenKhoaHoc";
        }
        private float TinhTongTienTruocGiam()
        {
            float TongTienTrcGiam = 0;
            for(int i = 0; i < dtKhoaHoc.Rows.Count; i++)
            {
                TongTienTrcGiam += Convert.ToSingle(dtKhoaHoc.Rows[i][3]);
            }
            return TongTienTrcGiam;
        }
        private float ThanhTien(float TongTienTrcGiam, float SoTienGiam)
        {
            float ThanhTien = TongTienTrcGiam - SoTienGiam;
            return ThanhTien;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmDSBaoGia = new frmDSBaoGiaCuaLead();
            frmDSBaoGia.Closed += (s, args) => this.Close();
            frmDSBaoGia.Show();
        }

        private void frmBaoGia_Load(object sender, EventArgs e)
        {
            // Báo giá của ai?
            txtBaoGiaCuaLead.Text = "Phan Duy Trọng"; // Fix cứng
            newLead.MaLead = "LEA6"; // Fix cứng

            // CboKhoaHoc
            LoadcboKhoaHoc();

            // Thêm cột cho dtKhoaHoc
            dtKhoaHoc.Columns.Add("Mã khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Tên khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Giảng viên", typeof(string));
            dtKhoaHoc.Columns.Add("Giá tiền", typeof(float));

            // dtgv
            dataGridView1.DataSource = dtKhoaHoc;
            sort_qdGiamGia = busBaoGia.SortQDGiamGia(sort_qdGiamGia);
            //dataGridView2.DataSource = sort_qdGiamGia;

            // Read-Only textbox
            txtBaoGiaCuaLead.Enabled = false;
            txtTongTienTrcGiam.ReadOnly = true;
            txtSoTienGiamGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtKoCoGiam.ReadOnly = true;

            //visible
            lbSoKhoaHocMuaChung.Visible = false;
            txtSoKhoaHocMuaChung.Visible = false;
            lbDoiTuongUuTien.Visible = false;
            txtDoiTuongUuTien.Visible = false;
            lbDipDacBiet.Visible = false;
            txtDipDacBiet.Visible = false;
            lbPhanTramGiamGia.Visible = false;
            numUpDownPhanTramGiamGia.Visible = false;
            txtKoCoGiam.Visible = false;
            btnLuuKhuyenMai.Visible = false;

            // Email báo giá
            btnTaoEmailBaoGia.Visible = false;
            lbTrangThaiEmailBaoGia.Visible = false;
            txtTrangThaiEmailBaoGia.Visible = false;
            btnGuiEmailBaoGia.Visible = false;

        }

        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            string selectedMaKhoaHoc = cboKhoaHoc.SelectedValue.ToString();
            bool existMaKhoaHoc = false;

            foreach(DataRow dr in dtKhoaHoc.Rows)
            {
                if (dr.Field<string>("Mã khóa học") == selectedMaKhoaHoc)
                {
                    existMaKhoaHoc = true;
                    break;
                }
            }
            if (existMaKhoaHoc)
            {
                MessageBox.Show("Khóa học này đã được thêm vào báo giá", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataRow newRow = dtKhoaHoc.NewRow();
                newRow["Mã khóa học"] = selectedMaKhoaHoc;
                newRow["Tên khóa học"] = cboKhoaHoc.Text;

                khoaHoc.MaKhoaHoc = cboKhoaHoc.SelectedValue.ToString();
                dt1KhoaHoc = busBaoGia.Select1KhoaHoc(khoaHoc);
                newRow["Giảng viên"] = dt1KhoaHoc.Rows[0][2].ToString();
                newRow["Giá tiền"] = dt1KhoaHoc.Rows[0][3];

                dtKhoaHoc.Rows.Add(newRow);

                dataGridView1.Refresh();

                float tongTienTrcGiam = TinhTongTienTruocGiam();
                txtTongTienTrcGiam.Text = tongTienTrcGiam.ToString("N0");

                txtSoTienGiamGia.Text = "0";

                float thanhTien = ThanhTien(tongTienTrcGiam, float.Parse(txtSoTienGiamGia.Text));
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
        }

        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)
        {
            string selectedMaKhoaHoc = cboKhoaHoc.SelectedValue.ToString();
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
                float tongTienTrcGiam = TinhTongTienTruocGiam();
                txtTongTienTrcGiam.Text = tongTienTrcGiam.ToString("N0");

                txtSoTienGiamGia.Text = "0";

                float thanhTien = ThanhTien(tongTienTrcGiam, float.Parse(txtSoTienGiamGia.Text));
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            else
            {
                MessageBox.Show("Khóa học chưa được thêm vào báo giá. Không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemKhuyenMai_Click(object sender, EventArgs e)
        {
            // Không được chỉnh sửa DS khóa học nữa
            cboKhoaHoc.Enabled = false;
            btnThemKhoaHoc.Visible = false;
            btnXoaKhoaHoc.Visible = false;
            btnThemKhuyenMai.Visible = false;

            // Control liên quan tới Thêm khuyến mãi hiện lên
            lbSoKhoaHocMuaChung.Visible = true;
            txtSoKhoaHocMuaChung.Visible = true;
            lbDoiTuongUuTien.Visible = true;
            txtDoiTuongUuTien.Visible = true;
            lbDipDacBiet.Visible = true;
            txtDipDacBiet.Visible = true;
            lbPhanTramGiamGia.Visible = true;
            //numUpDownPhanTramGiamGia.Visible = true;
            btnLuuKhuyenMai.Visible = true; 

            // ReadOnly textbox
            txtSoKhoaHocMuaChung.ReadOnly = true;
            txtDoiTuongUuTien.ReadOnly = true;
            txtDipDacBiet.ReadOnly = true;
            numUpDownPhanTramGiamGia.ReadOnly = true;

            // Enable Tạo báo giá
            btnTaoBaoGia.Enabled = false;
            numUpDownPhanTramGiamGia.Enabled = true;

            txtSoKhoaHocMuaChung.Text = dtKhoaHoc.Rows.Count.ToString();
            dtNgheNghepCuaLead = busBaoGia.SelectNgheNghiepCuaLead(newLead);
            txtDoiTuongUuTien.Text = dtNgheNghepCuaLead.Rows[0][3].ToString();

            DataRow qdGiamGiaRow = sort_qdGiamGia.NewRow();
            qdGiamGiaThoa = false;
            foreach(DataRow dr in sort_qdGiamGia.Rows)
            {
                int qdSoLuongKhoaHocDangKy = int.Parse(dr[2].ToString());
                string qdNgheNghiep = dr[3].ToString();
                string strNgayBatDau = dr[4].ToString();
                string strNgayKetThuc = dr[5].ToString();
                DateTime? qdNgayBatDau = null;
                DateTime? qdNgayKetThuc = null;
                DateTime currentDate = DateTime.Now.Date;

                DateTime parsedNgayBatDau;
                DateTime parsedNgayKetThuc;

                if (DateTime.TryParse(strNgayBatDau, out parsedNgayBatDau))
                {
                    qdNgayBatDau = parsedNgayBatDau;
                }

                if (DateTime.TryParse(strNgayKetThuc, out parsedNgayKetThuc))
                {
                    qdNgayKetThuc = parsedNgayKetThuc;
                }

                if ((int.Parse(txtSoKhoaHocMuaChung.Text) >= qdSoLuongKhoaHocDangKy) && (txtDoiTuongUuTien.Text == qdNgheNghiep) && ((qdNgayBatDau == null && qdNgayKetThuc == null) || (currentDate >= qdNgayBatDau && currentDate <= qdNgayKetThuc)))
                {
                    if(qdNgayBatDau == null && qdNgayKetThuc == null)
                    {
                        txtDipDacBiet.Text = "Không";
                    }
                    else
                    {
                        txtDipDacBiet.Text = "Có";
                    }

                    qdGiamGiaRow = dr;
                    qdGiamGiaThoa = true;
                    break;
                }
            }
            if (qdGiamGiaThoa)
            {
                maQuyDinhGiamGiaThoa = qdGiamGiaRow[0].ToString();
                int minPhanTramGiamGia = int.Parse(qdGiamGiaRow[6].ToString());
                int maxPhanTramGiamGia = int.Parse(qdGiamGiaRow[7].ToString());
                numUpDownPhanTramGiamGia.Visible = true;
                txtKoCoGiam.Visible = false;
                numUpDownPhanTramGiamGia.ReadOnly = false;
                numUpDownPhanTramGiamGia.Minimum = minPhanTramGiamGia;
                numUpDownPhanTramGiamGia.Maximum = maxPhanTramGiamGia;
                numUpDownPhanTramGiamGia.Increment = 5;
            }
            else
            {
                numUpDownPhanTramGiamGia.Visible = false;
                txtKoCoGiam.Visible = true;
            }
        }

        private void btnLuuKhuyenMai_Click(object sender, EventArgs e)
        {
            // Tính lại số tiền giảm giá và thành tiền
            if (qdGiamGiaThoa == false)
            {
                float tongTienTrcGiam = TinhTongTienTruocGiam();
                txtTongTienTrcGiam.Text = tongTienTrcGiam.ToString("N0");

                txtSoTienGiamGia.Text = "0";

                float thanhTien = ThanhTien(tongTienTrcGiam, float.Parse(txtSoTienGiamGia.Text));
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            else 
            {
                PhanTramGiamGia = (int)numUpDownPhanTramGiamGia.Value;
                txtSoTienGiamGia.Text = (float.Parse(txtTongTienTrcGiam.Text) * PhanTramGiamGia / 100).ToString("N0");
                float thanhTien = ThanhTien(float.Parse(txtTongTienTrcGiam.Text), float.Parse(txtSoTienGiamGia.Text));
                txtThanhTien.Text = thanhTien.ToString("N0");
            }

            // ẩn các control khuyến mãi
            lbSoKhoaHocMuaChung.Visible = true;
            txtSoKhoaHocMuaChung.Visible = true;
            lbDoiTuongUuTien.Visible = true;
            txtDoiTuongUuTien.Visible = true;
            lbDipDacBiet.Visible = true;
            txtDipDacBiet.Visible = true;
            lbPhanTramGiamGia.Visible = true;
            if (qdGiamGiaThoa)
            {
                numUpDownPhanTramGiamGia.Visible = true;
            }
            else
            {
                txtKoCoGiam.Visible = true;
            }
            btnLuuKhuyenMai.Visible = false;

            txtSoKhoaHocMuaChung.ReadOnly = true;
            txtDoiTuongUuTien.ReadOnly = true;
            txtDipDacBiet.ReadOnly = true;
            if (qdGiamGiaThoa)
            {
                numUpDownPhanTramGiamGia.Enabled = false;
            }
            else
            {
                txtKoCoGiam.ReadOnly = true;
            }

            // hiện các control khóa học và thêm khuyến mãi
            cboKhoaHoc.Enabled = true;
            btnThemKhoaHoc.Visible = true;
            btnXoaKhoaHoc.Visible = true;
            btnThemKhuyenMai.Visible = true;
            btnTaoBaoGia.Enabled = true;
        }

        private void btnTaoBaoGia_Click(object sender, EventArgs e)
        {
            if(txtTenBaoGia.Text == "" || dtKhoaHoc.Rows.Count == 0)
            {
                MessageBox.Show("Thêm thiếu giá trị ở các trường bắt buộc");
            }
            else
            {

                if (qdGiamGiaThoa)
                {
                    //Tạo Mã giảm giá: @MoTaMaGiamGia, @PhamViApDung, @PhanTramGiamGia, @TrangThaiMaGiamGia, @MaQuyDinhGiamGia
                    newMaGiamGia.MaQuyDinhGiamGia = maQuyDinhGiamGiaThoa;
                    newMaGiamGia.MoTaGiamGia = "MaGiamGiaChoCaNhanLead";
                    newMaGiamGia.PhamViApDung = "Cho cá nhân";
                    newMaGiamGia.PhanTramGiamGia = (int)numUpDownPhanTramGiamGia.Value;
                    newMaGiamGia.TrangThaiMaGiamGia = "Khả dụng";

                    switch (busBaoGia.TaoMaGiamGia(newMaGiamGia))
                    {
                        case "Success":
                            MessageBox.Show("Tạo Mã giảm giá mới thành công");
                            break;

                        case "Fail":
                            MessageBox.Show("Tạo Mã giảm giá mới thất bại");
                            break;

                        case "Exception":
                            MessageBox.Show("Lỗi khác!");
                            break;
                    }
                }
                if (qdGiamGiaThoa)
                {
                    dtMaGiamGiaMoiTao = busBaoGia.SelectMaGiamGiaMoiTao();

                    //Tạo Báo giá: @TenBaoGia, @MaLead, @HoTenLead, @TongTienTruocGiam, @MaGiamGia, @PhanTramGiamGia, @TongTien, @TrangThaiBaoGia
                    newBaoGia.TenBaoGia = txtTenBaoGia.Text;
                    newBaoGia.MaLead = "LEA6"; // Fix cứng
                    newBaoGia.HoTenLead = txtBaoGiaCuaLead.Text; // Fix cứng
                    newBaoGia.TongTienTruocGiam = float.Parse(txtTongTienTrcGiam.Text);
                    newBaoGia.MaGiamGia = dtMaGiamGiaMoiTao.Rows[0][0].ToString();
                    newBaoGia.PhanTramGiamGia = int.Parse(dtMaGiamGiaMoiTao.Rows[0][1].ToString());
                    newBaoGia.TongTien = float.Parse(txtThanhTien.Text);
                    newBaoGia.TrangThaiBaoGia = "Chưa thanh toán"; // Fix cứng

                    switch (busBaoGia.TaoBaoGia(newBaoGia))
                    {
                        case "Success":
                            MessageBox.Show("Tạo Báo giá mới thành công");
                            break;

                        case "Fail":
                            MessageBox.Show("Tạo Báo giá mới thất bại");
                            break;

                        case "Exception":
                            MessageBox.Show("Lỗi khác!");
                            break;
                    }
                }
                else
                {
                    //Tạo Báo giá: @TenBaoGia, @MaLead, @HoTenLead, @TongTienTruocGiam, @MaGiamGia, @PhanTramGiamGia, @TongTien, @TrangThaiBaoGia
                    newBaoGia.TenBaoGia = txtTenBaoGia.Text;
                    newBaoGia.MaLead = "LEA6"; // Fix cứng
                    newBaoGia.HoTenLead = txtBaoGiaCuaLead.Text; // Fix cứng
                    newBaoGia.TongTienTruocGiam = float.Parse(txtTongTienTrcGiam.Text);
                    newBaoGia.MaGiamGia = null;
                    newBaoGia.PhanTramGiamGia = null;
                    newBaoGia.TongTien = float.Parse(txtThanhTien.Text);
                    newBaoGia.TrangThaiBaoGia = "Chưa thanh toán"; // Fix cứng

                    switch (busBaoGia.TaoBaoGia(newBaoGia))
                    {
                        case "Success":
                            MessageBox.Show("Tạo Báo giá mới thành công");
                            break;

                        case "Fail":
                            MessageBox.Show("Tạo Báo giá mới thất bại");
                            break;

                        case "Exception":
                            MessageBox.Show("Lỗi khác!");
                            break;
                    }
                }
                //code tiếp
                dtBaoGiaMoiTao = busBaoGia.SelectBaoGiaMoiTao();
                maBaoGiaMoiTao = dtBaoGiaMoiTao.Rows[0][0].ToString();
                // Thêm dô Chi tiết khóa học thuộc báo giá
                foreach (DataRow dr in dtKhoaHoc.Rows)
                {
                    khThuocBaoGia.MaBaoGia = maBaoGiaMoiTao;
                    khThuocBaoGia.MaKhoaHoc = dr[0].ToString();
                    khThuocBaoGia.TenKhoaHoc = dr[1].ToString();
                    khThuocBaoGia.GiangVien = dr[2].ToString();
                    khThuocBaoGia.GiaTien = float.Parse(dr[3].ToString());

                    switch (busBaoGia.ThemChiTietKhoaHocThuocBaoGia(khThuocBaoGia))
                    {
                        case "Success":
                            MessageBox.Show("Thêm chi tiết khóa học thuộc báo giá mới thành công");
                            break;

                        case "Fail":
                            MessageBox.Show("Thêm chi tiết khóa học thuộc báo giá mới thất bại");
                            break;

                        case "Exception":
                            MessageBox.Show("Lỗi khác!");
                            break;
                    }
                }

                // ReadOnly các mọi thứ trừ Email
                txtTenBaoGia.ReadOnly = true;
                dataGridView1.ReadOnly = true;
                cboKhoaHoc.Enabled = false;
                btnThemKhoaHoc.Enabled = false;
                btnXoaKhoaHoc.Enabled = false;
                btnThemKhuyenMai.Enabled = false;
                txtSoKhoaHocMuaChung.Visible = true;
                txtSoKhoaHocMuaChung.ReadOnly = true;
                txtDoiTuongUuTien.Visible = true;
                txtDoiTuongUuTien.ReadOnly = true;
                txtDipDacBiet.Visible = true;
                txtDipDacBiet.ReadOnly = true;
                numUpDownPhanTramGiamGia.Visible = true;
                numUpDownPhanTramGiamGia.Enabled = false;
                btnTaoBaoGia.Enabled = false;

                // Trừ control Email: Visible
                btnTaoEmailBaoGia.Visible = true;
                lbTrangThaiEmailBaoGia.Visible = true;
                txtTrangThaiEmailBaoGia.Visible = true;
                txtTrangThaiEmailBaoGia.ReadOnly = true;
            }
            /*
            // ReadOnly các mọi thứ trừ Email
            txtTenBaoGia.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            cboKhoaHoc.Enabled = false;
            btnThemKhoaHoc.Enabled = false;
            btnXoaKhoaHoc.Enabled = false;
            btnThemKhuyenMai.Enabled = false;
            txtSoKhoaHocMuaChung.Visible = true;
            txtSoKhoaHocMuaChung.ReadOnly = true;
            txtDoiTuongUuTien.Visible = true;
            txtDoiTuongUuTien.ReadOnly = true;
            txtDipDacBiet.Visible = true;
            txtDipDacBiet.ReadOnly = true;
            numUpDownPhanTramGiamGia.Visible = true;
            numUpDownPhanTramGiamGia.Enabled = false;
            btnTaoBaoGia.Enabled = false;

            // Trừ control Email: Visible
            btnTaoEmailBaoGia.Visible = true;
            lbTrangThaiEmailBaoGia.Visible = true;
            txtTrangThaiEmailBaoGia.Visible = true;
            txtTrangThaiEmailBaoGia.ReadOnly = true;
            */
            btnTaoBaoGia.Visible = false;
        }

        private void btnTaoEmailBaoGia_Click(object sender, EventArgs e)
        {
            btnTaoEmailBaoGia.Visible = false;
            MessageBox.Show("Tạo Email báo giá thành công");
            txtTrangThaiEmailBaoGia.Text = "Nháp";
            if(txtTrangThaiEmailBaoGia.Text == "Nháp")
            {
                btnGuiEmailBaoGia.Visible = true;
            }
        }

        private void btnGuiEmailBaoGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gửi Email báo giá thành công");
            txtTrangThaiEmailBaoGia.Text = "Đã gửi";
            btnGuiEmailBaoGia.Visible = false;
            btnTaoEmailBaoGia.Visible = false;

            /*
            if (txtTrangThaiEmailBaoGia.Text == "Đã gửi")
            {
                btnTaoEmailBaoGia.Enabled = false;
            }
            */
        }
    }
}
