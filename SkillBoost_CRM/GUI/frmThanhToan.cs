﻿using DTO;
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
            
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            tt.MaBaoGia = txtMadonhang.Text;
            if (bUS_ThanhToan.TimThongTinThanhToan(ref tt))
            {
                lb_QR.Visible = true;
                pictureBox1.Visible = true;
                txtMadonhang.Text = tt.MaBaoGia;
                txtMagiamgia.Text = tt.MaGiamGia;
                txtNoidungchuyenkhoan.Text = tt.MaBaoGia;
                txtTongtien.Text = tt.TongTien;
                txtSotaikhoan.Text = "099054032178";
                txtTennguoithuhuong.Text = "Nguyễn Thu Việc";
                txtChinhanh.Text = "Vietcombank-TP.HCM";
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

            tt.MaBaoGia = txtMadonhang.Text;
            tt.TrangThaiBaoGia = "Đã thanh toán";

            if (bUS_ThanhToan.UpdateThanhToan(tt))
            {
                MessageBox.Show("Thanh toán thành công");
                bUS_ThanhToan.UpdateTrangThaiLead(tt);
                BUS_Lead bUS_Lead = new BUS_Lead();
                DTO_HoatDongLead hoatDongLead = new DTO_HoatDongLead();

                hoatDongLead.MaLead = tt.MaLead;
                hoatDongLead.TenHDLead = "Thanh toán thành công các khóa học";
                hoatDongLead.LoaiHDLead = "Thanh toán";
                hoatDongLead.HDLeadDuocTaoBoi = "Lead";
                hoatDongLead.MaNVPhuTrachHDLead = bUS_Lead.LayMaPIC(tt.MaLead);
                hoatDongLead.TenNVPhuTrachHDLead = bUS_Lead.LayTenPIC(tt.MaLead);
                hoatDongLead.MaEmailDenLead = null;
                if (bUS_HoatDongLead.ThemHoatDongLead(hoatDongLead))
                {
                    MessageBox.Show("Tạo hoạt động thanh toán thành công");
                }
                else
                {
                    MessageBox.Show("Tạo hoạt động thanh toán thất bại");

                }
                hoatDongLead.MaLead = tt.MaLead;
                hoatDongLead.TenHDLead = "Gửi email xác nhận thanh toán thành công";
                hoatDongLead.LoaiHDLead = "Email";
                hoatDongLead.HDLeadDuocTaoBoi = "Hệ thống";
                hoatDongLead.MaEmailDenLead = null;//sửa null
                if (bUS_HoatDongLead.ThemHoatDongLead(hoatDongLead))
                {
                    MessageBox.Show("Gửi email thành công");
                }
                else
                {
                    MessageBox.Show("Gửi email thất bại");

                }
                if (bUS_ThanhToan.ChuyenLeadSangKH(tt))
                {
                    MessageBox.Show("Chuyển đổi Lead thành Khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Chuyển đổi Lead thành Khách hàng thất bại");
                }

            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
