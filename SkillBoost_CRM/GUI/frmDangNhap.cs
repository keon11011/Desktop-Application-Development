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
    public partial class frmDangNhap : Form
    {
        public string maPIC;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan bUS_TaiKhoan = new BUS_TaiKhoan();
            DTO_TaiKhoan dTO_TaiKhoan = new DTO_TaiKhoan();
            dTO_TaiKhoan.EmailTK = txtEmail.Text;
            dTO_TaiKhoan.MatKhauTK = txtMatKhau.Text;
            if (bUS_TaiKhoan.DangNhap(dTO_TaiKhoan, ref maPIC))
            {
                MessageBox.Show("Đăng nhập thành công");
                SharedResources.MaPIC = maPIC;
                if (bUS_TaiKhoan.TimChucVu(ref SharedResources.ChucVu, SharedResources.MaPIC))
                {
                    if (bUS_TaiKhoan.TimTenPIC(ref SharedResources.TenPIC, SharedResources.MaPIC))
                    {
                        MessageBox.Show("Chào mừng "+ SharedResources.TenPIC + " đang nhập hệ thống CRM. \n Mã nhân viên: "+ SharedResources.MaPIC + " \n Chức vụ: " + SharedResources.ChucVu);
                        this.Hide();
                        var FRMfrmDanhSacYCTV = new frmDSYeuCauTuVan();
                        FRMfrmDanhSacYCTV.Closed += (s, args) => this.Close();
                        FRMfrmDanhSacYCTV.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi tìm chức vụ");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, hoặc tài khoản đã dừng hoạt động");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
