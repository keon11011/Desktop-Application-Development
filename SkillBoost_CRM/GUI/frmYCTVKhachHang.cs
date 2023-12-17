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
        public frmYCTVKhachHang()
        {
            InitializeComponent();
            string[] arr = { "IT Business Analysis", "Product Owner Master Class", "SQL Advanced Class", "Data Analysis", "Business Intelligence", "Excel Advanced Class", "Database Foundation Class", "Desktop Coding Class", "Python Advance Coding Class", "Business Data Engineer " };
            checkedListBox1.Items.AddRange(arr);
        }

        private void frmYCTVKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
