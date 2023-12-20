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
    public partial class frmYCTVKhachHang : Form
    {
        BUS_YCTVKhachHang bUS_YCTVKhachHang = new BUS_YCTVKhachHang();
        public frmYCTVKhachHang()
        {
            InitializeComponent();
            string[] arr = { "IT Business Analysis", "Product Owner Master Class", "SQL Advanced Class", "Data Analysis", "Business Intelligence", "Excel Advanced Class", "Database Foundation Class", "Desktop Coding Class", "Python Advance Coding Class", "Business Data Engineer " };
            checkedListBox1.Items.AddRange(arr);
        }

        private void frmYCTVKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnGuiYCTV_Click(object sender, EventArgs e)
        {
            DTO_YCTVKhachHang kh = new DTO_YCTVKhachHang();
            kh.TenLeadYeuCau = txtHoten.Text;
            kh.NgaySinhLeadYeuCau = datetimeNgaySinh.Value;
            kh.SdtLeadYeuCau = txtSdt.Text;
            kh.EmailLeadYeuCau = txtEmail.Text;
            kh.GhiChuYCTV = txtGhichu.Text;
            if (bUS_YCTVKhachHang.Insert_YCTVKhachHang(kh))
            {
                MessageBox.Show("Yêu cầu tư vấn thành công");
            
            }
            else
            {
                MessageBox.Show("Yêu cầu tư vấn thất bại");
            }
        }
    }
}
