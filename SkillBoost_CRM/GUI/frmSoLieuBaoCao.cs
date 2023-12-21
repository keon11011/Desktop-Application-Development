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
        string Chartmuonxem = "";
        public frmSoLieuBaoCao()
        {
            InitializeComponent();
        }

        private void frmSoLieuBaoCao_Load(object sender, EventArgs e)
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
