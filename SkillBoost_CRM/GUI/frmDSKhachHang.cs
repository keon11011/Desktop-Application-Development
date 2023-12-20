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
        public frmDSKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
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
    }
}
