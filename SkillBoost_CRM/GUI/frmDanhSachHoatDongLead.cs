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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace GUI
{
    public partial class frmDanhSachHoatDongLead : Form
    {

        BUS_HoatDongLead bUSHoatDongLead = new BUS_HoatDongLead();
        public frmDanhSachHoatDongLead()
        {
            InitializeComponent();
        }

        private void LoadDataHoatDongLead()
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
            dataGridDanhSachHoatDong.Rows[0].Frozen = true;

            ThietLapHienThiBang();
        }

        private void LoadDataCombobox()
        {
            //Đưa data lên ComboBox LoaiHDLead

            cbLoaiHoatDong.Items.Add("Yêu cầu");
            cbLoaiHoatDong.Items.Add("Tư vấn");
            cbLoaiHoatDong.Items.Add("Điều chỉnh trạng thái");
            cbLoaiHoatDong.Items.Add("Email");
            cbLoaiHoatDong.Items.Add("Báo giá");
            cbLoaiHoatDong.Items.Add("Mã giảm giá");
            cbLoaiHoatDong.Items.Add("Thông tin Lead");
            cbLoaiHoatDong.Items.Add("Thanh toán");

            //Đưa data lên ComboBox HDLeadDuocTaoBoi

            cbDuocTaoBoi.Items.Add("Lead");
            cbDuocTaoBoi.Items.Add("PIC");
            cbDuocTaoBoi.Items.Add("Hệ thống");

            cbDuocTaoBoi.Text = "";
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
        private void frmDanhSachHoatDongLead_Load(object sender, EventArgs e)
        {
            LoadDataHoatDongLead();

            LoadDataCombobox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridDanhSachHoatDong.DataSource = bUSHoatDongLead.TimHoatDongLead(txtThanhTimKiem.Text);

            ThietLapHienThiBang();
        }

        private void btnLoc_Click(object sender, EventArgs e)


        {
            string MaLead = "LEA1";

            if (cbLoaiHoatDong.SelectedIndex < 0 && cbDuocTaoBoi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin lọc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridDanhSachHoatDong.DataSource = bUSHoatDongLead.LocHoatDongLead(MaLead,
                                                                                  cbLoaiHoatDong.SelectedItem != null ? cbLoaiHoatDong.Text : "",
                                                                                  cbDuocTaoBoi.SelectedItem != null ? cbDuocTaoBoi.Text : "");

            ThietLapHienThiBang();
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            LoadDataHoatDongLead();
        }

        private void btnThemHoatDongLead_Click(object sender, EventArgs e)
        {
            //frmTaoHoatDongLead taoHoatDongLead = new frmTaoHoatDongLead();
            //taoHoatDongLead.Show();

            this.Hide();
            frmTaoHoatDongLead taoHoatDongLead = new frmTaoHoatDongLead();
            taoHoatDongLead.Closed += (s, args) => this.Close();
            taoHoatDongLead.Show();
        }
    }
}
