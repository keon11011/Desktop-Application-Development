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
        BUS_HoatDongLead bUS_HoatDongLead = new BUS_HoatDongLead();
        DTO_ThanhToan tt = new DTO_ThanhToan();
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
            
            tt.MaBaoGia = txtMadonhang.Text;
            tt.TrangThaiBaoGia = "Đã thanh toán";

            if (bUS_ThanhToan.UpdateThanhToan(tt))
            {
                MessageBox.Show("Thanh toán thành công");
                bUS_ThanhToan.UpdateTrangThaiLead(tt);
                HoatDongLead hoatDongLead = new HoatDongLead();

                hoatDongLead.MaLead = tt.MaLead;
                hoatDongLead.TenHDLead = "Thanh toán thành công các khóa học";
                hoatDongLead.LoaiHDLead = "Thanh toán";
                hoatDongLead.HDLeadDuocTaoBoi = "Lead";
                hoatDongLead.MaNVPhuTrachHDLead = 
                bUS_HoatDongLead.ThemHoatDongLead

            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
