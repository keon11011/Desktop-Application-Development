using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmYCTV_KhachHang : Form
    {
        BUS_YeuCauTuVan bUS_YeuCauTuVan = new BUS_YeuCauTuVan();
        BUS_Lead bUS_Lead = new BUS_Lead();
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

        private void btnGuiYCTV_Click(object sender, EventArgs e)
        {
            //Check if a new or already had a Lead code or not ?
            SqlConnection con = new SqlConnection("Data Source=VIS-LAPTOP;Initial Catalog=SkillBoost;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmdCheckLead = new SqlCommand("Select MaLead from Lead where HoTenLead = @HoTenLead and SoDienThoaiLead = @SoDienThoaiLead", con);
            cmdCheckLead.Parameters.Add("@HoTenLead", SqlDbType.NVarChar).Value = txtHoten.Text;
            cmdCheckLead.Parameters.Add("@SoDienThoaiLead", SqlDbType.NVarChar).Value = txtSdt.Text;
            SqlDataReader reader = cmdCheckLead.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows) //Already had a Lead code in database
                {
                    //Olds
                    DTO_YeuCauTuVan yctvOld = new DTO_YeuCauTuVan();
                    yctvOld.TenLeadYeuCau = txtHoten.Text;
                    yctvOld.NgaySinhLeadYeuCau = dtpNgaySinh.Value;
                    yctvOld.EmailLeadYeuCau = txtEmail.Text;
                    yctvOld.SDTLeadYeuCau = txtSdt.Text;
                    yctvOld.GhiChuYCTV = txtGhichu.Text;
                    yctvOld.TrangThaiYCTV = "Chờ tiếp nhận";
                    yctvOld.TaoVaoLuc = DateTime.Now;
                    yctvOld.TaoBoiLead = reader.GetValue(0).ToString();
                    if (bUS_YeuCauTuVan.InsertYCTVOld(yctvOld))
                    {
                        MessageBox.Show($"Bạn là Lead cũ! Gửi Yêu cầu tư vấn thành công!");
                        txtHoten.Text = "";
                        dtpNgaySinh.Value = DateTime.Now;
                        txtEmail.Text = "";
                        txtGhichu.Text = "";
                        txtSdt.Text = "";
                    }
                    else MessageBox.Show($"Gửi Yêu cầu tư vấn thất bại! (Lỗi kết nối Database YCTV)");
                }
                else //A New Lead so didn't have a Lead_Code in database
                {
                    //New
                    DTO_Lead yctvLeadNew = new DTO_Lead();
                    yctvLeadNew.HoTenLead = txtHoten.Text;
                    yctvLeadNew.GioiTinhLead = "";
                    yctvLeadNew.NgaySinhLead = dtpNgaySinh.Value;
                    yctvLeadNew.SoDienThoaiLead = txtSdt.Text;
                    yctvLeadNew.EmailLead = txtEmail.Text;
                    yctvLeadNew.MaNgheNghiep = "";
                    yctvLeadNew.TenNgheNghiep = "";
                    yctvLeadNew.MaNVPhuTrachLead = SharedResources.MaPIC;
                    yctvLeadNew.TenNVPhuTrachLead = "";
                    yctvLeadNew.TrangThaiLead = "Chờ tư vấn";
                    yctvLeadNew.LyDoTrangThaiLead = "";
                    yctvLeadNew.NguonLead = "Website";
                    yctvLeadNew.GhiChuLead = "";
                    yctvLeadNew.LeadTuKHCu = "";
                    yctvLeadNew.TaoVaoLuc = DateTime.Now;
                    yctvLeadNew.TaoBoi = "Hệ thống";
                    yctvLeadNew.ChinhSuaLanCuoiVaoLuc = DateTime.Now;
                    yctvLeadNew.ChinhSuaLanCuoiBoi = SharedResources.MaPIC;
                    if (bUS_Lead.InsertYCTVcuaLeadNew(yctvLeadNew))
                    {

                        MessageBox.Show($"Bạn là Lead mới! Gửi Yêu cầu tư vấn thành công!");

                    }
                    else
                    {
                        MessageBox.Show($"Gửi Yêu cầu tư vấn thất bại! (Lỗi kết nối Database Lead)");
                        return;
                    }
                    DTO_YeuCauTuVan yctvNew = new DTO_YeuCauTuVan();
                    yctvNew.TenLeadYeuCau = txtHoten.Text;
                    yctvNew.NgaySinhLeadYeuCau = dtpNgaySinh.Value;
                    yctvNew.EmailLeadYeuCau = txtEmail.Text;
                    yctvNew.SDTLeadYeuCau = txtSdt.Text;
                    yctvNew.GhiChuYCTV = txtGhichu.Text;
                    yctvNew.TrangThaiYCTV = "Chờ tiếp nhận";
                    yctvNew.TaoVaoLuc = DateTime.Now;
                    yctvNew.TaoBoiLead = "";
                    if (bUS_YeuCauTuVan.InsertYCTVNew(yctvNew))
                    {
                        MessageBox.Show($"Gửi Yêu cầu tư vấn thành công!");
                        txtHoten.Text = "";
                        dtpNgaySinh.Value = DateTime.Now;
                        txtEmail.Text = "";
                        txtGhichu.Text = "";
                        txtSdt.Text = "";
                    }
                    else MessageBox.Show($"Gửi Yêu cầu tư vấn thất bại! (Lỗi kết nối Database YCTV)");
                    con.Close();
                }
            
            }
        }
    }
}
