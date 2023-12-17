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
    public partial class frmDanhSachQuyDinhGiamGia : Form
    {
        BUS_QuyDinhGiamGia busQuyDinhGiamGia = new BUS_QuyDinhGiamGia();
        void LoadDSachQuyDinhGiamGia()
        {
            dataGridView1.DataSource = busQuyDinhGiamGia.SelectQuyDinhGiamGia();
        }
        public frmDanhSachQuyDinhGiamGia()
        {
            InitializeComponent();
            // dataGridView1.DataSource = busQuyDinhGiamGia.SelectQuyDinhGiamGia();
            LoadDSachQuyDinhGiamGia();
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
    }
}
