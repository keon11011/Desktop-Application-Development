using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmTaoQuyDinhGiamGia : Form
    {
        BUS_QuyDinhGiamGia busQuyDinhGiamGia = new BUS_QuyDinhGiamGia();
        DTO_QuyDinhGiamGia newQuyDinhGiamGia = new DTO_QuyDinhGiamGia();

        public frmTaoQuyDinhGiamGia()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadNgheNghiep()
        {
            DataTable dt = busQuyDinhGiamGia.SelectNgheNghiep();
            cboNgheNghiep.DataSource = dt;
            cboNgheNghiep.ValueMember = "MaNgheNghiep";
            cboNgheNghiep.DisplayMember = "TenNgheNghiep";
        }

        private void frmTaoQuyDinhGiamGia_Load(object sender, EventArgs e)
        {
            LoadNgheNghiep();
        }

        private void btnTaoQuyDinhGiamGIa_Click(object sender, EventArgs e)
        {
            if ((txtMaQuyDinhGiamGia.Text == "") || (txtMoTaLoaiGiamGia.Text == ""))
            {
                MessageBox.Show("Thêm thiếu giá trị ở các cột bắt buộc");
            }
            else
            {
                newQuyDinhGiamGia.MaQuyDinhGiamGia = txtMaQuyDinhGiamGia.Text;
                newQuyDinhGiamGia.MoTaLoaiGiamGia = txtMoTaLoaiGiamGia.Text;
                newQuyDinhGiamGia.SoLuongKhoaHocDangKy = int.Parse(numUpDownSoLuongKhoaHocDangKy.Value.ToString());
                newQuyDinhGiamGia.MaNgheNghiep = (string) cboNgheNghiep.SelectedValue;
                newQuyDinhGiamGia.TenNgheNghiep = cboNgheNghiep.Text;
                newQuyDinhGiamGia.NgayBatDau = dateTimePickerNgayBatDau.Value;
                newQuyDinhGiamGia.NgayKetThuc = dateTimePickerNgayKetThuc.Value;
                newQuyDinhGiamGia.PhanTramGiamGiaMacDinh = int.Parse(numUpDownPhanTramGiamGiaMacDinh.Value.ToString());
                newQuyDinhGiamGia.PhanTramGiamGiaToiDa = int.Parse(numUpDownPhanTramGiamGiaToiDa.Value.ToString());

                switch (busQuyDinhGiamGia.ThemQuyDinhGiamGia(newQuyDinhGiamGia))
                {
                    case "Success":
                        MessageBox.Show("Tạo Quy định giảm giá mới thành công");
                        break;

                    case "Fail":
                        MessageBox.Show("Tạo Quy định giảm giá mới thất bại");
                        break;

                    case "Exception":
                        MessageBox.Show("Lỗi khác!");
                        break;
                }
            }
        }
    }
}
