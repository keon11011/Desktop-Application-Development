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
    public partial class frmDanhSachKH : Form
    {
        
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        public frmDanhSachKH()
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
            DataTable dt = bUS_KhachHang.SelectKhachHang(SharedResources.MaPIC);
            dtgvKhachHang.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
