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

namespace GUI
{
    public partial class frmDSKhoaHoc : Form
    {
        BUS_KhoaHoc bUSKhoaHoc = new BUS_KhoaHoc();

        public frmDSKhoaHoc()
        {
            InitializeComponent();
        }
        private void LoadDataKhoaHoc()
        {
            DataTable dt = bUSKhoaHoc.SelectKhoaHoc();
            dt.Columns[1].ColumnName = "Mã khóa học";
            dt.Columns[2].ColumnName = "Tên khóa học";
            dt.Columns[3].ColumnName = "Mô tả";
            dt.Columns[4].ColumnName = "Thời lượng";
            dt.Columns[5].ColumnName = "Giảng viên";
            dt.Columns[6].ColumnName = "Mức độ";
            dt.Columns[7].ColumnName = "Số lượng tối đa";
            dt.Columns[8].ColumnName = "Giá tiên";
            dt.Columns[9].ColumnName = "Ngày khai giảng";
            dt.Columns[10].ColumnName = "Ngày bế giảng";
            dt.Columns[11].ColumnName = "Đánh giá";
            dt.Columns[12].ColumnName = "Trạng thái";
            dt.Columns[13].ColumnName = "Mã loại khóa học";
            dt.Columns[14].ColumnName = "Tạo vào lúc";
            dt.Columns[15].ColumnName = "Tạo bởi";
            dt.Columns[16].ColumnName = "Chỉnh sửa lần cuối vào lúc";
            dt.Columns[17].ColumnName = "Chỉnh sửa lần cuối bởi";

            dataGridDanhSachKhoaHoc.DataSource = dt;
            dataGridDanhSachKhoaHoc.Rows[0].Frozen = true;

            ThietLapHienThiBang();
        }

        private void LoadCombobox()
        {
            //Đưa data lên ComboBox GiangVien

            cbGiangVien.DataSource = bUSKhoaHoc.SelectKhoaHoc();
            cbGiangVien.DisplayMember = "GiangVien";
            cbGiangVien.ValueMember = "MaKhoaHoc";

            //Đưa data lên ComboBox TrangThai

            cbTrangThai.Items.Add("Đang vận hành");
            cbTrangThai.Items.Add("Đang chiêu sinh");
            cbTrangThai.Items.Add("Vô hiệu hóa");

            cbGiangVien.Text = "";
            cbTrangThai.Text = "";
        }
        private void ThietLapHienThiBang()
        {
            //Hide những column không cần hiển thị

            dataGridDanhSachKhoaHoc.Columns[0].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[3].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[4].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[6].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[7].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[10].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[11].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[13].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[14].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[15].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[16].Visible = false;
            dataGridDanhSachKhoaHoc.Columns[17].Visible = false;

            dataGridDanhSachKhoaHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Canh text nằm giữa cell, nhưng không áp dụng cho cột đầu tiên

            for (int i = 3; i < dataGridDanhSachKhoaHoc.Columns.Count; i++)
            {
                dataGridDanhSachKhoaHoc.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridDanhSachKhoaHoc.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < dataGridDanhSachKhoaHoc.Columns.Count; i++)
            {
                if (i < 2)
                {
                    dataGridDanhSachKhoaHoc.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void frmDanhSachKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadDataKhoaHoc();

            LoadCombobox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridDanhSachKhoaHoc.DataSource = bUSKhoaHoc.TimKhoaHoc(txtThanhTimKiem.Text);

            ThietLapHienThiBang();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cbGiangVien.SelectedIndex < 0 && cbTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin lọc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridDanhSachKhoaHoc.DataSource = bUSKhoaHoc.LocKhoaHoc(cbGiangVien.SelectedItem != null ? cbGiangVien.Text : "",
                                                                        cbTrangThai.SelectedItem != null ? cbTrangThai.Text : "");

            ThietLapHienThiBang();
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            LoadDataKhoaHoc();
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
