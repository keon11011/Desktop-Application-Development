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
    public partial class frmChiTietQuyDinhGiamGia : Form
    {
        BUS_QuyDinhGiamGia busQuyDinhGiamGia = new BUS_QuyDinhGiamGia();
        DTO_QuyDinhGiamGia newQuyDinhGiamGia = new DTO_QuyDinhGiamGia();
        DataTable dt = new DataTable();
        bool editStatus = false;
        int idx;
        public frmChiTietQuyDinhGiamGia()
        {
            InitializeComponent();
        }
        //void LoadDSachQuyDinhGiamGia()
        //{
        //    dt = busQuyDinhGiamGia.SelectQuyDinhGiamGia();
        //    dt.Columns[0].ColumnName = "Mã quy định giảm giá";
        //    dt.Columns[1].ColumnName = "Mô tả";
        //    dt.Columns[2].ColumnName = "Số lượng khóa học đăng ký";
        //    dt.Columns[3].ColumnName = "Tên nghề nghiệp";
        //    dt.Columns[4].ColumnName = "Ngày bắt đầu";
        //    dt.Columns[5].ColumnName = "Ngày kết thúc";
        //    dt.Columns[6].ColumnName = "Phần trăm giảm giá mặc định";
        //    dt.Columns[7].ColumnName = "Phần trăm giảm giá tối đa";
        //    dt.Columns[8].ColumnName = "Trạng thái";
        //    dt.Columns[9].ColumnName = "Thời điểm tạo";
        //    dt.Columns[10].ColumnName = "Người tạo";

        //    dataGridView1.DataSource = dt;
        //}
        void LoadNgheNghiep()
        {
            DataTable dt = busQuyDinhGiamGia.SelectNgheNghiep();
            cboNgheNghiep.DataSource = dt;
            cboNgheNghiep.ValueMember = "MaNgheNghiep";
            cboNgheNghiep.DisplayMember = "TenNgheNghiep";
        }
        void LoadTrangThai()
        {
            cboTrangThai.Items.Add("Đang hoạt động");
            cboTrangThai.Items.Add("Vô hiệu hóa");
        }
        void LoadTextbox()
        {
            if (busQuyDinhGiamGia.SelectQuyDinhGiamGiaAfterClick(ref newQuyDinhGiamGia))
            {
                txtMaQuyDinhGiamGia.Text = newQuyDinhGiamGia.MaQuyDinhGiamGia;
                txtMoTaLoaiGiamGia.Text = newQuyDinhGiamGia.MoTaLoaiGiamGia;
                numUpDownSoLuongKhoaHocDangKy.Text = newQuyDinhGiamGia.SoLuongKhoaHocDangKy.ToString();
                cboNgheNghiep.Text = newQuyDinhGiamGia.TenNgheNghiep;
                dateTimePickerNgayBatDau.Text = newQuyDinhGiamGia.NgayBatDau.ToString();
                dateTimePickerNgayKetThuc.Text = newQuyDinhGiamGia.NgayKetThuc.ToString();
                numUpDownPhanTramGiamGiaMacDinh.Text = newQuyDinhGiamGia.PhanTramGiamGiaMacDinh.ToString();
                numUpDownPhanTramGiamGiaToiDa.Text = newQuyDinhGiamGia.PhanTramGiamGiaToiDa.ToString();
                cboTrangThai.Text = newQuyDinhGiamGia.TrangThaiQuyDinhGiamGia;
                txtMaQuyDinhGiamGia.Enabled = false;
                txtMoTaLoaiGiamGia.Enabled = false;
                numUpDownSoLuongKhoaHocDangKy.Enabled = false;
                cboNgheNghiep.Enabled = false;
                numUpDownPhanTramGiamGiaMacDinh.Enabled = false;
                numUpDownPhanTramGiamGiaToiDa.Enabled = false;
                dateTimePickerNgayBatDau.Enabled = false;
                dateTimePickerNgayKetThuc.Enabled = false;
                cboTrangThai.Enabled = false;

                btnSuaQuyDinhGiamGia.Visible = false;
                btnHuySua.Visible = false;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu quy định giảm giá");
            }
            if (newQuyDinhGiamGia.NgayBatDau.HasValue)
            {
                rbtnYesDate.Checked = true;
            }
            else
            {
                rbtnNoDate.Checked = true;
            }
        }
        void LoadForm()
        {
            //LoadDSachQuyDinhGiamGia();
            LoadNgheNghiep();
            LoadTrangThai();

            newQuyDinhGiamGia.MaQuyDinhGiamGia = SharedResources.MaQuyDinhGiamGia;

            LoadTextbox();

           
        }

        // Đã đổi tên thành frmDSQuyDinhGiamGia
        // Form SuaXoaQuyDinhGiamGia chỉ được thao tác trên các dòng chưa bị xóa mềm (TrangThaiQuyDinhGiamGia != N'Xóa mềm')
        private void frmSuaXoaQuyDinhGiamGia_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSelectedSua_Click(object sender, EventArgs e)
        {
            btnSuaQuyDinhGiamGia.Visible = true;
            btnHuySua.Visible = true;

            txtMoTaLoaiGiamGia.Enabled = true;
            numUpDownSoLuongKhoaHocDangKy.Enabled = true;
            cboNgheNghiep.Enabled = true;
            numUpDownPhanTramGiamGiaMacDinh.Enabled = true;
            numUpDownPhanTramGiamGiaToiDa.Enabled = true;
            /*
            dateTimePickerNgayBatDau.Enabled = true;
            dateTimePickerNgayKetThuc.Enabled = true;
            */
            cboTrangThai.Enabled = true;

            btnSelectedSua.Visible = false;
            btnSelectedXoa.Visible = false;

            editStatus = true;
            if(rbtnYesDate.Checked)
            {
                dateTimePickerNgayBatDau.Enabled = true;
                dateTimePickerNgayKetThuc.Enabled = true;
            }
        }

        private void btnSelectedXoa_Click(object sender, EventArgs e)
        {
            btnSuaQuyDinhGiamGia.Visible = false;
            btnHuySua.Visible = false;

            txtMoTaLoaiGiamGia.Enabled = false;
            numUpDownSoLuongKhoaHocDangKy.Enabled = false;
            cboNgheNghiep.Enabled = false;
            numUpDownPhanTramGiamGiaMacDinh.Enabled = false;
            numUpDownPhanTramGiamGiaToiDa.Enabled = false;
            dateTimePickerNgayBatDau.Enabled = false;
            dateTimePickerNgayKetThuc.Enabled = false;
            cboTrangThai.Enabled = false;

            btnSelectedSua.Visible = false;
            btnSelectedXoa.Visible = false;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Quy định giảm giá?", "Xác nhận xóa", MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        newQuyDinhGiamGia.MaQuyDinhGiamGia = txtMaQuyDinhGiamGia.Text;
                        newQuyDinhGiamGia.TrangThaiQuyDinhGiamGia = "Xóa mềm";

                        switch (busQuyDinhGiamGia.XoaQuyDinhGiamGia(newQuyDinhGiamGia, SharedResources.MaPIC))
                        {
                            case "Success":
                                MessageBox.Show("Xóa Quy định giảm giá thành công");

                                this.Hide();
                                var form2 = new frmDSQuyDinhGiamGia();
                                form2.Closed += (s, args) => this.Close();
                                form2.Show();

                                break;

                            case "Fail":
                                MessageBox.Show("Xóa Quy định giảm giá thất bại");
                                LoadTextbox();
                                break;

                            case "Exception":
                                MessageBox.Show("Lỗi khác!");
                                break;
                        }
                    }
                    break;

                case DialogResult.Cancel:
                    this.TopMost = true;
                    break;
            }
            btnSelectedSua.Visible = true;
            btnSelectedXoa.Visible = true;
        }

        private void btnSuaQuyDinhGiamGia_Click(object sender, EventArgs e)
        {
            if (txtMoTaLoaiGiamGia.Text == "")
            {
                MessageBox.Show("Không được xóa giá trị ở các cột bắt buộc");
            }
            else if (rbtnNoDate.Checked)
            {
                newQuyDinhGiamGia.MaQuyDinhGiamGia = txtMaQuyDinhGiamGia.Text;
                newQuyDinhGiamGia.MoTaLoaiGiamGia = txtMoTaLoaiGiamGia.Text;
                newQuyDinhGiamGia.SoLuongKhoaHocDangKy = int.Parse(numUpDownSoLuongKhoaHocDangKy.Value.ToString());
                newQuyDinhGiamGia.MaNgheNghiep = (string)cboNgheNghiep.SelectedValue;
                newQuyDinhGiamGia.TenNgheNghiep = cboNgheNghiep.Text;
                newQuyDinhGiamGia.NgayBatDau = null;
                newQuyDinhGiamGia.NgayKetThuc = null;
                newQuyDinhGiamGia.PhanTramGiamGiaMacDinh = int.Parse(numUpDownPhanTramGiamGiaMacDinh.Value.ToString());
                newQuyDinhGiamGia.PhanTramGiamGiaToiDa = int.Parse(numUpDownPhanTramGiamGiaToiDa.Value.ToString());
                newQuyDinhGiamGia.TrangThaiQuyDinhGiamGia = cboTrangThai.Text;

                switch (busQuyDinhGiamGia.SuaQuyDinhGiamGia(newQuyDinhGiamGia,SharedResources.MaPIC))
                {
                    case "Success":
                        MessageBox.Show("Sửa Quy định giảm giá thành công");
                        LoadTextbox();
                        btnSelectedSua.Visible = true;
                        btnSelectedXoa.Visible = true;

                        btnSuaQuyDinhGiamGia.Visible = false;
                        btnHuySua.Visible = false;
                        break;

                    case "Fail":
                        MessageBox.Show("Sửa Quy định giảm giá thất bại");
                        break;

                    case "Exception":
                        MessageBox.Show("Lỗi khác!");
                        break;
                }
            }
            else
            {
                newQuyDinhGiamGia.MaQuyDinhGiamGia = txtMaQuyDinhGiamGia.Text;
                newQuyDinhGiamGia.MoTaLoaiGiamGia = txtMoTaLoaiGiamGia.Text;
                newQuyDinhGiamGia.SoLuongKhoaHocDangKy = int.Parse(numUpDownSoLuongKhoaHocDangKy.Value.ToString());
                newQuyDinhGiamGia.MaNgheNghiep = (string)cboNgheNghiep.SelectedValue;
                newQuyDinhGiamGia.TenNgheNghiep = cboNgheNghiep.Text;
                newQuyDinhGiamGia.NgayBatDau = dateTimePickerNgayBatDau.Value;
                newQuyDinhGiamGia.NgayKetThuc = dateTimePickerNgayKetThuc.Value;
                newQuyDinhGiamGia.PhanTramGiamGiaMacDinh = int.Parse(numUpDownPhanTramGiamGiaMacDinh.Value.ToString());
                newQuyDinhGiamGia.PhanTramGiamGiaToiDa = int.Parse(numUpDownPhanTramGiamGiaToiDa.Value.ToString());
                newQuyDinhGiamGia.TrangThaiQuyDinhGiamGia = (string)cboTrangThai.Text;

                switch (busQuyDinhGiamGia.SuaQuyDinhGiamGia(newQuyDinhGiamGia,SharedResources.MaPIC))
                {
                    case "Success":
                        MessageBox.Show("Sửa Quy định giảm giá thành công");
                        LoadTextbox();
                        btnSelectedSua.Visible = true;
                        btnSelectedXoa.Visible = true;

                        btnSuaQuyDinhGiamGia.Visible = false;
                        btnHuySua.Visible = false;
                        break;

                    case "Fail":
                        MessageBox.Show("Sửa Quy định giảm giá thất bại");
                        break;

                    case "Exception":
                        MessageBox.Show("Lỗi khác!");
                        break;
                }
            }
            
            if (newQuyDinhGiamGia.NgayBatDau.HasValue)
            {
                rbtnYesDate.Checked = true;
            }
            else
            {
                rbtnNoDate.Checked = true;
            }
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.RowCount > 0)
        //    {
        //        txtMaQuyDinhGiamGia.Text = dataGridView1[0, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        txtMoTaLoaiGiamGia.Text = dataGridView1[1, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        numUpDownSoLuongKhoaHocDangKy.Text = dataGridView1[2, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        cboNgheNghiep.Text = dataGridView1[3, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        dateTimePickerNgayBatDau.Text = dataGridView1[4, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        dateTimePickerNgayKetThuc.Text = dataGridView1[5, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        numUpDownPhanTramGiamGiaMacDinh.Text = dataGridView1[6, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        numUpDownPhanTramGiamGiaToiDa.Text = dataGridView1[7, SharedResources.MaQuyDinhGiamGia].Value.ToString();
        //        cboTrangThai.Text = dataGridView1[8, SharedResources.MaQuyDinhGiamGia].Value.ToString();

        //        idx = dataGridView1.CurrentRow.Index;
        //    }

        //    if((dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString() == "") && (dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString() == ""))
        //    {
        //        rbtnNoDate.Checked = true;
        //    }
        //    else
        //    {
        //        rbtnYesDate.Checked = true;
        //    }
        //}

        private void btnXoaQuyDinhGiamGIa_Click(object sender, EventArgs e)
        {
            /*
            rbtnYesDate.Enabled = false;
            rbtnNoDate.Enabled = false;
            groupBox1.Enabled = false;
            */
            /*
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Quy định giảm giá?", "Xác nhận xóa", MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        newQuyDinhGiamGia.MaQuyDinhGiamGia = txtMaQuyDinhGiamGia.Text;
                        newQuyDinhGiamGia.TrangThaiQuyDinhGiamGia = "Xóa mềm";

                        switch (busQuyDinhGiamGia.XoaQuyDinhGiamGia(newQuyDinhGiamGia))
                        {
                            case "Success":
                                MessageBox.Show("Xóa Quy định giảm giá thành công");
                                LoadDSachQuyDinhGiamGia();
                                break;

                            case "Fail":
                                MessageBox.Show("Xóa Quy định giảm giá thất bại");
                                LoadDSachQuyDinhGiamGia();
                                break;

                            case "Exception":
                                MessageBox.Show("Lỗi khác!");
                                break;
                        }
                    }
                    break;

                case DialogResult.Cancel:
                    this.TopMost = true;
                    break;
            }
            btnSelectedTao.Visible = true;
            btnSelectedSua.Visible = true;
            btnSelectedXoa.Visible = true;
            */
        }

        private void rbtnYesDate_CheckedChanged(object sender, EventArgs e)
        {
            if(editStatus)
            {
                dateTimePickerNgayBatDau.Enabled = true;
                dateTimePickerNgayKetThuc.Enabled = true;
            }
            /*
            newQuyDinhGiamGia.NgayBatDau = null;
            newQuyDinhGiamGia.NgayKetThuc = null;
            */
        }

        private void rbtnNoDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayBatDau.Enabled = false;
            dateTimePickerNgayKetThuc.Enabled = false;

            /*
            newQuyDinhGiamGia.NgayBatDau = dateTimePickerNgayBatDau.Value;
            newQuyDinhGiamGia.NgayKetThuc = dateTimePickerNgayKetThuc.Value;
            */
        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            LoadForm();
            btnSelectedSua.Visible = true;
            btnSelectedXoa.Visible = true;

            editStatus = false;

            LoadTextbox();
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

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSQuyDinhGiamGia();
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

        private void lbPhanTramGiamGiaToiDa_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numUpDownPhanTramGiamGiaToiDa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSQuyDinhGiamGia();
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
    }
}
