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
    public partial class frmXacNhanXoaLead : Form
    {
        DTO_Lead dTO_Lead = new DTO_Lead();
        BUS_Lead bUS_Lead = new BUS_Lead();
        public frmXacNhanXoaLead()
        {
            InitializeComponent();
        }

        private void btnXoaLead_Click(object sender, EventArgs e)
        {

            dTO_Lead.LyDoTrangThaiLead = txtLyDoXoaLead.Text;
            dTO_Lead.MaLead = SharedResources.MaLead;

            switch (bUS_Lead.XoaMemLead(dTO_Lead))                      //Sao nó không đổi trạng thái lead 
            {
                case "Success":
                    MessageBox.Show("Đã xóa Lead");
                    break;

                case "Fail":
                    MessageBox.Show("Thao tác thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác!");
                    break;
            }
        }
    }
}
