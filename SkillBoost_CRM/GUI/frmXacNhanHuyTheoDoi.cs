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
    public partial class frmXacNhanHuyTheoDoi : Form
    {
        DTO_Lead dTO_Lead = new DTO_Lead();
        BUS_Lead bUS_Lead = new BUS_Lead();
        public frmXacNhanHuyTheoDoi()
        {
            InitializeComponent();
        }

        private void btnHuyTheoDoi_Click(object sender, EventArgs e)
        {
            dTO_Lead.LyDoTrangThaiLead = txtLyDoHuyTheoDoi.Text;
            dTO_Lead.MaLead = SharedResources.MaLead;

            switch (bUS_Lead.HuyTheoDoiTuVan(dTO_Lead))
            {
                case "Success":
                    MessageBox.Show("Đã ngừng theo dõi Lead");
                    break;

                case "Fail":
                    MessageBox.Show("Thao tác thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác!");
                    break;
            }
        }

        private void frmXacNhanHuyTheoDoi_Load(object sender, EventArgs e)
        {

        }
        // private bool isOpenedFormXacNhanHuyTheoDoi = false;
        //private void frmXacNhanHuyTheoDoi_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Hide();
        //    frmThongTinLead thongTinLead = new frmThongTinLead();                // Sao nó show rồi tự động mất??
        //    thongTinLead.Closed += (s, arg) => this.Close();

        //    thongTinLead.Show();
        //}

        // Hàm này để mở frmThongTinLead từ frmXacNhanHuyTheoDoi
        //public void OpenThongTinLeadFromXacNhanHuyTheoDoi()
        //{
        //    isOpenedFormXacNhanHuyTheoDoi = true;
        //    frmThongTinLead thongTinLead = new frmThongTinLead();
        //    thongTinLead.Show();
        //}
    }

}