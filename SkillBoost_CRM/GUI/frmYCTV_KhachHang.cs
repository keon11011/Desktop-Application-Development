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
    public partial class frmYCTV_KhachHang : Form
    {
        public frmYCTV_KhachHang()
        {
            InitializeComponent();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmYCTV_KhachHang_Load(object sender, EventArgs e)
        {
            string[] arr = { "IT Business Analysis", "Product Owner Master Class", "SQL Advanced Class", "Data Analysis", "Business Intelligence", "Excel Advanced Class", "Database Foundation Class", "Desktop Coding Class", "Python Advance Coding Class", "Business Data Engineer " };
            checkedListBox1.Items.AddRange(arr);
        }
    }
}
