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
        void LoadDSachQuyDinhGiamGia()
        {
            dt = busQuyDinhGiamGia.SelectQuyDinhGiamGia();
            dt.Columns[0].ColumnName = "Mã quy định giảm giá";
            dt.Columns[1].ColumnName = "Mô tả";
            dt.Columns[2].ColumnName = "Số lượng khóa học đăng ký";
            dt.Columns[3].ColumnName = "Tên nghề nghiệp";
            dt.Columns[4].ColumnName = "Ngày bắt đầu";
            dt.Columns[5].ColumnName = "Ngày kết thúc";
            dt.Columns[6].ColumnName = "Phần trăm giảm giá mặc định";
            dt.Columns[7].ColumnName = "Phần trăm giảm giá tối đa";
            dt.Columns[8].ColumnName = "Trạng thái";
            dt.Columns[9].ColumnName = "Thời điểm tạo";
            dt.Columns[10].ColumnName = "Người tạo";

            dataGridView1.DataSource = dt;
        }
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
        void LoadForm()
        {
            LoadDSachQuyDinhGiamGia();
            LoadNgheNghiep();
            LoadTrangThai();

            dataGridView1.ReadOnly = true;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

            btnSelectedTao.Visible = false;
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

            btnSelectedTao.Visible = false;
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

                switch (busQuyDinhGiamGia.SuaQuyDinhGiamGia(newQuyDinhGiamGia))
                {
                    case "Success":
                        MessageBox.Show("Sửa Quy định giảm giá thành công");
                        LoadDSachQuyDinhGiamGia();
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

                switch (busQuyDinhGiamGia.SuaQuyDinhGiamGia(newQuyDinhGiamGia))
                {
                    case "Success":
                        MessageBox.Show("Sửa Quy định giảm giá thành công");
                        LoadDSachQuyDinhGiamGia();
                        break;

                    case "Fail":
                        MessageBox.Show("Sửa Quy định giảm giá thất bại");
                        break;

                    case "Exception":
                        MessageBox.Show("Lỗi khác!");
                        break;
                }
            }
            btnSelectedTao.Visible = true;
            btnSelectedSua.Visible = true;
            btnSelectedXoa.Visible = true;

            btnSuaQuyDinhGiamGia.Visible = false;
            btnHuySua.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txtMaQuyDinhGiamGia.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtMoTaLoaiGiamGia.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                numUpDownSoLuongKhoaHocDangKy.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                cboNgheNghiep.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                dateTimePickerNgayBatDau.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                dateTimePickerNgayKetThuc.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                numUpDownPhanTramGiamGiaMacDinh.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                numUpDownPhanTramGiamGiaToiDa.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                cboTrangThai.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();

                idx = dataGridView1.CurrentRow.Index;
            }

            if((dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString() == "") && (dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString() == ""))
            {
                rbtnNoDate.Checked = true;
            }
            else
            {
                rbtnYesDate.Checked = true;
            }
        }

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

        private void btnTaoQuyDinhGiamGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaoQuyDinhGiamGia frmTao = new frmTaoQuyDinhGiamGia();
            frmTao.ShowDialog();
            frmTao = null;
            this.Show();
            LoadDSachQuyDinhGiamGia();
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
            btnSelectedTao.Visible = true;
            btnSelectedSua.Visible = true;
            btnSelectedXoa.Visible = true;

            editStatus = false;

            txtMaQuyDinhGiamGia.Text = dataGridView1[0, idx].Value.ToString();
            txtMoTaLoaiGiamGia.Text = dataGridView1[1, idx].Value.ToString();
            numUpDownSoLuongKhoaHocDangKy.Text = dataGridView1[2, idx].Value.ToString();
            cboNgheNghiep.Text = dataGridView1[3, idx].Value.ToString();
            dateTimePickerNgayBatDau.Text = dataGridView1[4, idx].Value.ToString();
            dateTimePickerNgayKetThuc.Text = dataGridView1[5, idx].Value.ToString();
            numUpDownPhanTramGiamGiaMacDinh.Text = dataGridView1[6, idx].Value.ToString();
            numUpDownPhanTramGiamGiaToiDa.Text = dataGridView1[7, idx].Value.ToString();
            cboTrangThai.Text = dataGridView1[8, idx].Value.ToString();
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
    }
}
