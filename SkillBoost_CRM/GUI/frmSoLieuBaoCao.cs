using BUS;
using DTO;
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
    public partial class frmSoLieuBaoCao : Form
    {
        BUS_SoLieu bUS_SoLieu = new BUS_SoLieu();
        string Chartmuonxem ="";
        public frmSoLieuBaoCao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSoLieuBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
         
            DTO_SoLieu Solieu = new DTO_SoLieu();
            
            Solieu.NgayBatDau = dtpNgayBatDau.Value;
            Solieu.NgayKetThuc = dtpNgayKetThuc.Value;
            if (bUS_SoLieu.TaoSoLieu(ref Solieu))
            {
                txtSoLuongLead.Text = Solieu.SoLuongLead.ToString();
                txtSoLuongKhoaHoc.Text = Solieu.SoLuongKhoaHocBanRa.ToString();
                txtSoLuongKhachHang.Text = Solieu.SoLuongKhachHang.ToString();
                txtDoanhThu.Text = Solieu.DoanhThu.ToString();
                txtTiLeLead.Text = Solieu.TiLeChuyenDoi.ToString();
                txtKhoaHocBanChay.Text = Solieu.KhoaHocBanChay;
                txtMaGiamGiaNhieu.Text = Solieu.MaGiamGiaNhieu;
                txtNhanVienTuVanNhieu.Text = Solieu.NhanVienTuVanNhieu;
            }
            else MessageBox.Show("Không có dữ liệu phù hợp trong ngày bạn chọn!");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dTOSoLieuBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaGiamGiaNhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
