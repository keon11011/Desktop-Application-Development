using DTO;
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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmThanhToan : Form
    {
        BUS_ThanhToan bUS_ThanhToan = new BUS_ThanhToan();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            txtSotaikhoan.Text = "099054032178";
            txtTennguoithuhuong.Text = "Nguyễn Thu Việc";
            txtChinhanh.Text = "Vietcombank-TP.HCM";
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DTO_ThanhToan tt = new DTO_ThanhToan();
            tt.MaBaoGia = txtMadonhang.Text;
            if (bUS_ThanhToan.TimThongTinThanhToan(ref tt))
            {
                txtMadonhang.Text= tt.MaBaoGia;
                txtMagiamgia.Text = tt.MaGiamGia;
                txtNoidungchuyenkhoan.Text = tt.MaBaoGia;
                txtTongtien.Text = tt.TongTien;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin thanh toán");
            }

        }

        

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DTO_ThanhToan t = new DTO_ThanhToan();
            t.MaBaoGia = txtMadonhang.Text;
            t.TrangThaiBaoGia = "Đã thanh toán";

            if (bUS_ThanhToan.UpdateThanhToan(t))
            {
                MessageBox.Show("Thanh toán thành công");
                bUS_ThanhToan.UpdateTrangThaiLead(t);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
