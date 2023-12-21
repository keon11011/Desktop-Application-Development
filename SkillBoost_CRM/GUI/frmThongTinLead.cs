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
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class frmThongTinLead : Form
    {
        DTO_KhoaHoc dTO_KhoaHoc = new DTO_KhoaHoc();
        DTO_Lead dTO_Lead = new DTO_Lead();
       
        BUS_Lead bUS_Lead = new BUS_Lead();
        BUS_KhoaHoc bUS_KhoaHoc = new BUS_KhoaHoc();

        DataTable dtNgheNghiep = new DataTable();
        DataTable dt1KhoaHoc = new DataTable();
        DataTable dtKhoaHoc = new DataTable();
        DataTable dtKhoaHoc1 = new DataTable();
        public frmThongTinLead()
        {
            InitializeComponent();
        }
        public void LoadNgheNghiep()
        {
            dtNgheNghiep = bUS_Lead.SelectNgheNghiep().Tables["NgheNghiep"];
            cbNgheNghiep.DataSource = dtNgheNghiep;
            cbNgheNghiep.DisplayMember = "TenNgheNghiep";
            cbNgheNghiep.ValueMember = "MaNgheNghiep";
        }
        public void LoadKhoaHoc()
        {
            cbKhoaHoc.DataSource = bUS_Lead.SelectKhoaHoc().Tables["KhoaHoc"];
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }
        public void LoadDanhSachKhoaHoc()
        {
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
            //dataGridViewKhoaHocKHQuanTam.DataSource = bUS_Lead.DanhSachKhoaHoc(dTO_Lead).Tables["KhoaHoc"];
            dataGridViewKhoaHocKHQuanTam.Columns[0].HeaderText = "Mã khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[1].HeaderText = "Tên khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[2].HeaderText = "Mô tả khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[3].HeaderText = "Thời lượng khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[4].HeaderText = "Giảng viên";
            dataGridViewKhoaHocKHQuanTam.Columns[5].HeaderText = "Mức độ khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[6].HeaderText = "Số lượng học viên tối đa";
            dataGridViewKhoaHocKHQuanTam.Columns[7].HeaderText = "Giá tiền";
            //dataGridViewKhoaHocKHQuanTam.Columns[9].HeaderText = "Ngày khai giảng";
            //dataGridViewKhoaHocKHQuanTam.Columns[10].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[11].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[12].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[13].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[14].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[15].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[16].Visible = false;
            //dataGridViewKhoaHocKHQuanTam.Columns[17].Visible = false;

        }


        private void frmThongTinLead_Load_1(object sender, EventArgs e)
        {
            // Add Collums cho dtKhoaHoc
            dtKhoaHoc.Columns.Add("Mã khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Tên khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Mô tả khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Thời lượng khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Giảng viên", typeof(string));
            dtKhoaHoc.Columns.Add("Mức độ khóa học", typeof(string));
            dtKhoaHoc.Columns.Add("Số lượng học viên tối đa", typeof(string));
            dtKhoaHoc.Columns.Add("Giá tiền", typeof(float));
           

            LoadLaiThongTinLead();
        }
        void LoadcbNguonLead()
        {
            List<string> danhsachDuLieuNguonLead = new List<string>();
            danhsachDuLieuNguonLead.Add("Facebook");
            danhsachDuLieuNguonLead.Add("Website");
            danhsachDuLieuNguonLead.Add("Truyền miệng");
            danhsachDuLieuNguonLead.Add("LinkedIn");
            cbNguonLead.DataSource = danhsachDuLieuNguonLead;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnHuyChinhSua.Show();
            btnLuuThayDoi.Show();
            txtHoten.ReadOnly = false;
            dateTimePickerNgaySinh.Enabled = true;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            cbNgheNghiep.Enabled = true;
            cbNguonLead.Enabled = true;

            txtGhiChu.ReadOnly = false;
            dataGridViewKhoaHocKHQuanTam.ReadOnly = false;
            LoadNgheNghiep();
            LoadcbNguonLead();
            LoadKhoaHoc();
            for (int i = 0; i < cbNguonLead.Items.Count; i++)                               // note thuyết trình
            {
                if (cbNguonLead.Items[i].ToString() == dTO_Lead.NguonLead)
                {
                    cbNguonLead.SelectedIndex = i;
                    break;
                }

            }
            for (int i = 0; i < cbNgheNghiep.Items.Count; i++)
            {
                if (dtNgheNghiep.Rows[i][0].ToString() == dTO_Lead.MaNgheNghiep)
                {
                    cbNgheNghiep.SelectedIndex = i;
                    break;
                }

            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            dTO_Lead.HoTenLead = txtHoten.Text;
            dTO_Lead.NgaySinhLead = dateTimePickerNgaySinh.Value;
            dTO_Lead.EmailLead = txtEmail.Text;
            dTO_Lead.NguonLead = cbNguonLead.Text;
            dTO_Lead.MaNgheNghiep = cbNgheNghiep.SelectedValue.ToString();
            dTO_Lead.TenNgheNghiep = cbNgheNghiep.Text;
            dTO_Lead.GhiChuLead = txtGhiChu.Text;
            dTO_Lead.SoDienThoaiLead = txtSoDienThoai.Text;
            switch (bUS_Lead.SuaThongTinLead(dTO_Lead))
            {
                case "Success":
                    MessageBox.Show("Sửa thông tin Lead thành công");
                    break;

                case "Fail":
                    MessageBox.Show("Sửa thông tin Lead thất bại");
                    break;

                case "Exception":
                    MessageBox.Show("Lỗi khác!");
                    break;
            }


        }

        private void btnUnfollow_Click(object sender, EventArgs e)
        {
            this.Hide();
            SharedResources.MaLead = txtLeadID.Text;
            frmXacNhanHuyTheoDoi huyTheoDoi = new frmXacNhanHuyTheoDoi();
            huyTheoDoi.Closed += (s, arg) => this.Close();
            huyTheoDoi.Show();
       
        }
        private void LoadLaiThongTinLead()
        {
          

            // Hide 2 nút chỉnh sửa 
            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();


            txtHoten.ReadOnly = true;
            dateTimePickerNgaySinh.Enabled = false;
            txtEmail.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            cbNgheNghiep.Enabled = false;
            cbNguonLead.Enabled = false;
            txtGhiChu.ReadOnly = true;
            dataGridViewKhoaHocKHQuanTam.ReadOnly = true; 


            dTO_Lead.MaLead = "LEA1";  // Fix cứng 

            bUS_Lead.SelectLead(ref dTO_Lead);
            txtLeadID.Text = dTO_Lead.MaLead;
            txtHoten.Text = dTO_Lead.HoTenLead;
            dateTimePickerNgaySinh.Text = dTO_Lead.NgaySinhLead.ToString();
            txtEmail.Text = dTO_Lead.EmailLead;
            txtSoDienThoai.Text = dTO_Lead.SoDienThoaiLead;
            txtPIC.Text = dTO_Lead.TenNVPhuTrachLead;
            cbNgheNghiep.Text = dTO_Lead.TenNgheNghiep;
            cbNguonLead.Text = dTO_Lead.NguonLead;
            txtGhiChu.Text = dTO_Lead.GhiChuLead;
            txtTrangThaiLead.Text = dTO_Lead.TrangThaiLead;
            LoadDanhSachKhoaHoc();
        }

        private void btnHuyChinhSua_Click(object sender, EventArgs e)
        {
            LoadLaiThongTinLead();
        }


        private void btnThemKhoaHoc_Click(object sender, EventArgs e)                    // Button Thêm Khóa học vào DataGridView    
        {
            string selectedMaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            bool existMaKhoaHoc = false;

            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                if (dr.Field<string>("Mã khóa học") == selectedMaKhoaHoc)
                {
                    existMaKhoaHoc = true;
                    break;
                }
            }
            if (existMaKhoaHoc)
            {
                MessageBox.Show("Khóa học này đã được thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataRow newRow = dtKhoaHoc.NewRow();
                newRow["Mã khóa học"] = selectedMaKhoaHoc;
                newRow["Tên khóa học"] = cbKhoaHoc.Text;

                dTO_KhoaHoc.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
                //dTO_KhoaHoc.MaKhoaHoc = selectedMaKhoaHoc;
                dt1KhoaHoc = bUS_Lead.Select1KhoaHoc(dTO_KhoaHoc);
                newRow["Mô tả khóa học"] = dt1KhoaHoc.Rows[0][2].ToString();
                newRow["Thời lượng khóa học"] = dt1KhoaHoc.Rows[0][3];
                newRow["Giảng viên"] = dt1KhoaHoc.Rows[0][4];
                newRow["Mức độ khóa học"] = dt1KhoaHoc.Rows[0][5];
                newRow["Số lượng học viên tối đa"] = dt1KhoaHoc.Rows[0][6];
                newRow["Giá tiền"] = dt1KhoaHoc.Rows[0][7];

                dtKhoaHoc.Rows.Add(newRow);

                dataGridViewKhoaHocKHQuanTam.Refresh();
            }
        }
                private void XoaKhoaHoc(int STTkhoaHoc)
        {
            dataGridViewKhoaHocKHQuanTam.Rows.RemoveAt(STTkhoaHoc);
        }
        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)                            // Button Xóa Khóa học trong DataGridView 
        {
            string selectedMaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();
            bool existMaKhoaHoc = false;
            DataRow delRow = dtKhoaHoc.NewRow();

            foreach (DataRow dr in dtKhoaHoc.Rows)
            {
                if (dr.Field<string>("Mã khóa học") == selectedMaKhoaHoc)
                {
                    existMaKhoaHoc = true;
                    delRow = dr;
                    break;
                }
            }
            if (existMaKhoaHoc)
            {
                dtKhoaHoc.Rows.Remove(delRow);
            }
            else
            {
                MessageBox.Show("Khóa học chưa được thêm vào. Không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)                                   // Xóa mềm Lead => Hiện form Xác nhận Xóa Lead 
        {
            SharedResources.MaLead = txtLeadID.Text;
            this.Hide();
            frmXacNhanXoaLead xoaLead = new frmXacNhanXoaLead();
            xoaLead.Closed += (s, arg) => this.Close();
            xoaLead.Show();
        }
    }
}