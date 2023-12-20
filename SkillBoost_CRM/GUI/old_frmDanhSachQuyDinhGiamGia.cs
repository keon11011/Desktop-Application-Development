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
    public partial class old_frmDanhSachQuyDinhGiamGia : Form
    {
        BUS_QuyDinhGiamGia busQuyDinhGiamGia = new BUS_QuyDinhGiamGia();
        DataTable dt = new DataTable();
        void LoadDSachQuyDinhGiamGia()
        {
            dt = busQuyDinhGiamGia.SelectQuyDinhGiamGia();
            dt.Columns[0].ColumnName = "Mã quy định giảm giá";
            dt.Columns[1].ColumnName = "Mô tả";
            dt.Columns[2].ColumnName = "Số lượng khóa học đăng ký";
            dt.Columns[3].ColumnName = "Tên nghề nghiệp";
            dt.Columns[4].ColumnName = "Ngày bắt đầu";
            dt.Columns[5].ColumnName = "Ngày kết thúc";
            dt.Columns[6].ColumnName = "Phần trăm giảm giá mặc định";
            dt.Columns[7].ColumnName = "Phần trăm giảm giá tối đa";
            dt.Columns[8].ColumnName = "Trạng thái";
            dt.Columns[9].ColumnName = "Thời điểm tạo";
            dt.Columns[10].ColumnName = "Người tạo";

            dataGridView1.DataSource = dt;
        }
        public old_frmDanhSachQuyDinhGiamGia()
        {
            InitializeComponent();
            LoadDSachQuyDinhGiamGia();
        }

        private void btnTaoQuyDinhGiamGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaoQuyDinhGiamGia frmTao = new frmTaoQuyDinhGiamGia();
            frmTao.ShowDialog();
            frmTao = null;
            this.Show();
            LoadDSachQuyDinhGiamGia();
        }

        private void btnSuaXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSQuyDinhGiamGia frmSuaXoa = new frmDSQuyDinhGiamGia();
            frmSuaXoa.ShowDialog();
            frmSuaXoa = null;
            this.Show();
            LoadDSachQuyDinhGiamGia();
        }
    }
}
