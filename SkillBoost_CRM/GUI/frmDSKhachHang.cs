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

namespace GUI
{
    public partial class frmDSKhachHang : Form
    {
        
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        DTO_KhachHang dTO_KhachHang = new DTO_KhachHang();
        public frmDSKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = bUS_KhachHang.TimKhachHang(txtTimKH.Text,SharedResources.ChucVu, SharedResources.MaPIC);

            ThietLapHienThiBang();
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataCombobox()
        {
            //Đưa data lên ComboBox LoaiHDLead

            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");

            //Đưa data lên ComboBox HDLeadDuocTaoBoi

            cbTrangThai.Items.Add("Đang hoạt động");
            cbTrangThai.Items.Add("Dừng hoạt động");

            cbTrangThai.Text = "";
            cbGioiTinh.Text = "";
        }
        private void ThietLapHienThiBang()
        {
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Canh text nằm giữa cell, nhưng không áp dụng cho cột đầu tiên

            for (int i = 4; i < dtgvKhachHang.Columns.Count; i++)
            {
                dtgvKhachHang.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvKhachHang.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
            LoadDataCombobox();
            ThietLapHienThiBang();
        }
        public void LoadDSKhachHang()
        {
            DataTable dt = bUS_KhachHang.SelectKhachHang(SharedResources.MaPIC,SharedResources.ChucVu);
            dtgvKhachHang.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSYeuCauTuVan();
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

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSQuyDinhGiamGia();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string MaLead = SharedResources.MaLead;

            if (cbTrangThai.SelectedIndex < 0 && cbGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin lọc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                dTO_KhachHang.GioiTinhKH = cbGioiTinh.SelectedItem != null ? cbGioiTinh.Text : "";
                dTO_KhachHang.TrangThaiKH = cbTrangThai.SelectedItem != null ? cbTrangThai.Text : "";
                dtgvKhachHang.DataSource = bUS_KhachHang.LocKhachHang(dTO_KhachHang, SharedResources.ChucVu, SharedResources.MaPIC);
            }

            ThietLapHienThiBang();
            cbGioiTinh.Text = "";
            cbTrangThai.Text = "";
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            LoadDSKhachHang();
        }

        private void leadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSLead();
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

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSoLieuBaoCao();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
