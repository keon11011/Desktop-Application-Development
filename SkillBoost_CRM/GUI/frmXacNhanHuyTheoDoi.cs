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
        frmThongTinLead thongtinLead = new frmThongTinLead();
        public frmXacNhanHuyTheoDoi()
        {
            InitializeComponent();
        }

        private void btnHuyTheoDoi_Click(object sender, EventArgs e)
        {
            dTO_Lead.LyDoTrangThaiLead = txtLyDoHuyTheoDoi.Text;
            dTO_Lead.MaLead = SharedResources.MaLead;
            dTO_Lead.ChinhSuaLanCuoiBoi = SharedResources.MaPIC;

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
            this.Hide();
            var form2 = new frmDSLead();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void frmXacNhanHuyTheoDoi_Load(object sender, EventArgs e)
        {

        }

        // Hàm này để mở frmThongTinLead từ frmXacNhanHuyTheoDoi
        //public void OpenThongTinLeadFromXacNhanHuyTheoDoi()
        //{
        //    isOpenedFormXacNhanHuyTheoDoi = true;
        //    frmThongTinLead thongTinLead = new frmThongTinLead();
        //    thongTinLead.Show();
        //}
    }

}