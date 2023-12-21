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
    public partial class frmDSQuyDinhGiamGia : Form
    {
        DTO_QuyDinhGiamGia newQuyDinhGiamGia = new DTO_QuyDinhGiamGia();
        BUS_QuyDinhGiamGia busQuyDinhGiamGia = new BUS_QuyDinhGiamGia();
        DataTable dt = new DataTable();
        public frmDSQuyDinhGiamGia()
        {
            InitializeComponent();
        }
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

            dtgvQuyDinhGiamGia.DataSource = dt;
        }
        private void frmDSQuyDinhGiamGia_Load(object sender, EventArgs e)
        {
            lb_PIC_Name.Text = SharedResources.TenPIC;
            lb_ChucVuPIC.Text = SharedResources.ChucVu;
            LoadDSachQuyDinhGiamGia();
        }

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhoaHoc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhachHang();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSYeuCauTuVan();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void leadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSLead();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void dtgvQuyDinhGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SharedResources.ChucVu == "Quản lý")
            {
                SharedResources.MaQuyDinhGiamGia = dtgvQuyDinhGiamGia[0, dtgvQuyDinhGiamGia.CurrentRow.Index].Value.ToString();
                this.Hide();
                var form2 = new frmChiTietQuyDinhGiamGia();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được chỉnh sửa quy định giảm giá");
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (SharedResources.ChucVu == "Quản lý")
            {
                this.Hide();
                var form2 = new frmTaoQuyDinhGiamGia();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Chỉ có quản lý mới được thêm quy định giảm giá");
            }
        }

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmTaoQuyDinhGiamGia();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSoLieuBaoCao();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
