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
        DataTable dtNgheNghiep = new DataTable();
        BUS_Lead bUS_Lead = new BUS_Lead();
        BUS_KhoaHoc bUS_KhoaHoc = new BUS_KhoaHoc();
        DataTable dtKhoaHoc = new DataTable();
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
            dtKhoaHoc = bUS_Lead.DanhSachKhoaHoc(dTO_Lead).Tables["KhoaHoc"];
            dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
            dataGridViewKhoaHocKHQuanTam.Columns[0].HeaderText = "Mã khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[1].HeaderText = "Tên khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[2].HeaderText = "Mô tả khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[3].HeaderText = "Thời lượng khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[4].HeaderText = "Giảng viên";
            dataGridViewKhoaHocKHQuanTam.Columns[5].HeaderText = "Mức độ khóa học";
            dataGridViewKhoaHocKHQuanTam.Columns[6].HeaderText = "Số lượng học viên tối đa";
            dataGridViewKhoaHocKHQuanTam.Columns[7].HeaderText = "Giá tiền";
            dataGridViewKhoaHocKHQuanTam.Columns[8].HeaderText = "Ngày khai giảng";
            dataGridViewKhoaHocKHQuanTam.Columns[9].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[10].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[11].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[12].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[13].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[14].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[15].Visible = false;
            dataGridViewKhoaHocKHQuanTam.Columns[16].Visible = false;

        }


        private void frmThongTinLead_Load_1(object sender, EventArgs e)
        {
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
           txtHoten.ReadOnly = true;
            dateTimePickerNgaySinh.Enabled = false;
            txtEmail.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            cbNgheNghiep.Enabled = false;
            cbNguonLead.Enabled = false;
            txtGhiChu.ReadOnly = true;
            dataGridViewKhoaHocKHQuanTam.ReadOnly = true; 
            btnHuyChinhSua.Hide();
            btnLuuThayDoi.Hide();
            dTO_Lead.MaLead = "LEA1";
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


        private int KhoaHocDaTonTai(string khoaHoc)
        {

            //foreach (DataGridViewRow row in dataGridViewKhoaHocKHQuanTam.Rows)          
            //{
            //    if (row.ToString().IndexOf(khoaHoc) != -1 )                  // Kiểm tra khóa học tồn tại hay chưa?
            //    {
            //        return i;           // Khóa học đã tồn tại
            //        i++;
            //    }
            //}
            //return -1 ; // Khóa học chưa tồn tại
            for (int i = 0; i < dataGridViewKhoaHocKHQuanTam.Rows.Count; i++)
            {
                if (dataGridViewKhoaHocKHQuanTam[1,i].Value.ToString() == khoaHoc)     // Xét tên khóa học so với ComboBoxKhoaHoc
                {
                    return i;
                }

            }
            return -1;
        }


        private void btnThemKhoaHoc_Click(object sender, EventArgs e)                    // Button Thêm Khóa học vào DataGridView    
        {
            string khoaHocDuocChonThem = cbKhoaHoc.Text;

            // Kiểm tra xem khóa học đã tồn tại trong DataTable hay chưa
            if (KhoaHocDaTonTai(khoaHocDuocChonThem) == -1)
            {
                dTO_KhoaHoc.MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString();             // Lấy mã khóa học 
    
                DataGridViewRow row = (DataGridViewRow)dataGridViewKhoaHocKHQuanTam.Rows[0].Clone();
                if (bUS_KhoaHoc.LayThongTinKhoaHocChonThem(ref dTO_KhoaHoc))
                {
                    DataRow dr = dtKhoaHoc.NewRow();

                    dr[0] = dTO_KhoaHoc.MaKhoaHoc;
                    dr[1] = dTO_KhoaHoc.TenKhoaHoc;
                    dr[2] = dTO_KhoaHoc.MoTaKhoaHoc;
                    dr[3] = dTO_KhoaHoc.ThoiLuongKhoaHoc;
                    dr[4] = dTO_KhoaHoc.GiangVien;
                    dr[5] = dTO_KhoaHoc.MucDoKhoaHoc;
                    dr[6] = dTO_KhoaHoc.SoLuongHocVienToiDa;
                    dr[7] = dTO_KhoaHoc.GiaTien;
                    dr[8] = dTO_KhoaHoc.NgayKhaiGiang;
                    dtKhoaHoc.Rows.Add(dr);

                    dataGridViewKhoaHocKHQuanTam.DataSource = dtKhoaHoc;
                 }
                else
                {
                    MessageBox.Show("Không lấy được dữ liệu của khóa học vừa thêm");
                }
            }   
            else
            {
                MessageBox.Show("Khóa học không tồn tại trong danh sách.");
            }
                
        }
        private void XoaKhoaHoc(int STTkhoaHoc)
        {
            dataGridViewKhoaHocKHQuanTam.Rows.RemoveAt(STTkhoaHoc);
        }
        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)                            // Button Xóa Khóa học trong DataGridView 
        {
            string khoaHocDuocChonXoa = cbKhoaHoc.Text;
            
            // Kiểm tra xem khóa học đã tồn tại trong DataGridView hay chưa
            int STTKhoaHoc = KhoaHocDaTonTai(khoaHocDuocChonXoa);
            if (STTKhoaHoc != -1)
            {
                // Nếu tồn tại, xóa khóa học khỏi DataGridView
                XoaKhoaHoc(STTKhoaHoc);
            }
            else
            {
                MessageBox.Show("Khóa học không tồn tại trong danh sách.");
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