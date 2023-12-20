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
    public partial class frmTaoHoatDongLead : Form
    {
        BUS_HoatDongLead bUSHoatDongLead = new BUS_HoatDongLead();

        public frmTaoHoatDongLead()
        {
            InitializeComponent();
        }

        private void frmTaoHoatDongLead_Load(object sender, EventArgs e)
        {
            //Đưa data lên DatagridView

            string MaLead = "LEA1";

            DataTable dt = bUSHoatDongLead.SelectHoatDongLead(MaLead);
            dt.Columns[1].ColumnName = "Mã hoạt động";
            dt.Columns[2].ColumnName = "Mã Lead";
            dt.Columns[3].ColumnName = "Tên hoạt động";
            dt.Columns[4].ColumnName = "Loại hoạt động";
            dt.Columns[5].ColumnName = "Được tạo bởi";
            dt.Columns[6].ColumnName = "Mã Nhân viên phụ trách";
            dt.Columns[7].ColumnName = "Tên nhân viên phụ trách";
            dt.Columns[8].ColumnName = "Mã Email đến Lead";
            dt.Columns[9].ColumnName = "Tạo vào lúc";

            dataGridDanhSachHoatDong.DataSource = dt;

            ThietLapHienThiBang();

            //Đưa data lên ComboBox LoaiHDLead

            cbLoaiHoatDong.Items.Add("Yêu cầu");
            cbLoaiHoatDong.Items.Add("Tư vấn");

            txtTenHoatDongLead.Text = "";
            cbLoaiHoatDong.Text = "";
        }
        private void ThietLapHienThiBang()
        {
            //Hide những column không cần hiển thị

            dataGridDanhSachHoatDong.Columns[0].Visible = false;
            dataGridDanhSachHoatDong.Columns[1].Visible = false;
            dataGridDanhSachHoatDong.Columns[2].Visible = false;
            dataGridDanhSachHoatDong.Columns[6].Visible = false;
            dataGridDanhSachHoatDong.Columns[7].Visible = false;
            dataGridDanhSachHoatDong.Columns[8].Visible = false;

            dataGridDanhSachHoatDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Canh text nằm giữa cell, nhưng không áp dụng cho cột đầu tiên

            for (int i = 4; i < dataGridDanhSachHoatDong.Columns.Count; i++)
            {
                dataGridDanhSachHoatDong.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridDanhSachHoatDong.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            HoatDongLead newHDLead = new HoatDongLead();

            string maLead = "LEA1";

            newHDLead.MaLead = maLead;
            newHDLead.TenHDLead = txtTenHoatDongLead.Text;
            newHDLead.LoaiHDLead = cbLoaiHoatDong.Text;
            newHDLead.HDLeadDuocTaoBoi = "PIC";
            newHDLead.MaNVPhuTrachHDLead = "STA1";
            newHDLead.TenNVPhuTrachHDLead = "Nguyễn Phương Thanh";
            newHDLead.MaEmailDenLead = null;


            if (bUSHoatDongLead.ThemHoatDongLead(newHDLead))
            {
                DialogResult result = MessageBox.Show("Tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    frmDSHoatDongLead danhSachHoatDongLead = new frmDSHoatDongLead();
                    danhSachHoatDongLead.Closed += (s, args) => this.Close();
                    danhSachHoatDongLead.Show();
                }
            }
            else
            {
                MessageBox.Show("Tạo thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTaoHoatDongLead taoHoatDongLead = new frmTaoHoatDongLead();

            this.Close();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSYeuCauTuVan();
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

        private void thôngTinKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSKhoaHoc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void quyĐịnhGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
