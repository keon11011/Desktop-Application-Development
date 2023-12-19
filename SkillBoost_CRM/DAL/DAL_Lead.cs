using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace DAL
{
    public class DAL_Lead : DBConnect
    {
        public DataSet SelectNgheNghiep()
        {
            try
            {
                conn.Open();
                string cmdText = "select * from NgheNghiep";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "NgheNghiep");
                return ds;

            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InsertLead(DTO_Lead lead)
        {
            try
            {
                conn.Open();
                SqlCommand cmdYCTVNewLead = new SqlCommand("Insert into Lead(HoTenLead,GioiTinhLead,NgaySinhLead,SoDienThoaiLead,EmailLead,MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachLead, TenNVPhuTrachLead, TrangThaiLead, LyDoTrangThaiLead, NguonLead, GhiChuLead, LeadTuKHCu, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) " +
                "values " +
                "(@HoTenLead, @GioiTinhLead, @NgaySinhLead, @SoDienThoaiLead, @EmailLead, @MaNgheNghiep, @TenNgheNghiep, @MaNVPhuTrachLead,@TenNVPhuTrachLead,@TrangThaiLead,@LyDoTrangThaiLead,@NguonLead,@GhiChuLead,@LeadTuKHCu,@TaoVaoLuc,@TaoBoi,@ChinhSuaLanCuoiVaoLuc,@ChinhSuaLanCuoiBoi)", conn);

                cmdYCTVNewLead.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@HoTenLead"].Value = lead.HoTenLead;

                cmdYCTVNewLead.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@GioiTinhLead"].Value = lead.GioiTinhLead;

                cmdYCTVNewLead.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                cmdYCTVNewLead.Parameters["@NgaySinhLead"].Value = lead.NgaySinhLead;

                cmdYCTVNewLead.Parameters.Add("@SoDienThoaiLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@SoDienThoaiLead"].Value = lead.SoDienThoaiLead;

                cmdYCTVNewLead.Parameters.Add("@EmailLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@EmailLead"].Value = lead.EmailLead;

                cmdYCTVNewLead.Parameters.AddWithValue("@MaNgheNghiep", string.IsNullOrEmpty(lead.MaNgheNghiep) ? (object)DBNull.Value:lead.MaNgheNghiep);

                cmdYCTVNewLead.Parameters.AddWithValue("@TenNgheNghiep", string.IsNullOrEmpty(lead.TenNgheNghiep) ? (object)DBNull.Value : lead.TenNgheNghiep);

                cmdYCTVNewLead.Parameters.Add("@MaNVPhuTrachLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@MaNVPhuTrachLead"].Value = lead.MaNVPhuTrachLead;

                cmdYCTVNewLead.Parameters.Add("@TenNVPhuTrachLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@TenNVPhuTrachLead"].Value = lead.TenNVPhuTrachLead;

                cmdYCTVNewLead.Parameters.Add("@TrangThaiLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@TrangThaiLead"].Value = "Chờ tư vấn";

                cmdYCTVNewLead.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@LyDoTrangThaiLead"].Value = lead.LyDoTrangThaiLead;

                cmdYCTVNewLead.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@NguonLead"].Value = lead.NguonLead;

                cmdYCTVNewLead.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@GhiChuLead"].Value = lead.GhiChuLead;

                cmdYCTVNewLead.Parameters.AddWithValue("@LeadTuKHCu", string.IsNullOrEmpty(lead.LeadTuKHCu) ? (object)DBNull.Value : lead.LeadTuKHCu);

                cmdYCTVNewLead.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmdYCTVNewLead.Parameters["@TaoVaoLuc"].Value = lead.TaoVaoLuc;

                cmdYCTVNewLead.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@TaoBoi"].Value = lead.TaoBoi;

                cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = lead.ChinhSuaLanCuoiVaoLuc;

                cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiBoi"].Value = lead.ChinhSuaLanCuoiBoi;

                if (cmdYCTVNewLead.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public void SelectLead(ref DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                string cmdText = "select * from Lead where MaLead = 'LEA001'";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                dTO_Lead.HoTenLead = dt.Rows[0][1].ToString();
                dTO_Lead.GioiTinhLead = dt.Rows[0][2].ToString();
                dTO_Lead.NgaySinhLead = (DateTime)dt.Rows[0][3];
                dTO_Lead.SoDienThoaiLead = dt.Rows[0][4].ToString();
                dTO_Lead.EmailLead = dt.Rows[0][5].ToString();
                dTO_Lead.MaNgheNghiep = dt.Rows[0][6].ToString();
                dTO_Lead.TenNgheNghiep = dt.Rows[0][7].ToString();
                dTO_Lead.MaNVPhuTrachLead = dt.Rows[0][8].ToString();
                dTO_Lead.TenNVPhuTrachLead = dt.Rows[0][9].ToString();
                dTO_Lead.TrangThaiLead = dt.Rows[0][10].ToString();
                dTO_Lead.LyDoTrangThaiLead = dt.Rows[0][11].ToString();
                dTO_Lead.NguonLead = dt.Rows[0][12].ToString();
                dTO_Lead.GhiChuLead = dt.Rows[0][13].ToString();
                dTO_Lead.LeadTuKHCu = dt.Rows[0][14].ToString();
                dTO_Lead.TaoVaoLuc = (DateTime)dt.Rows[0][15];
                dTO_Lead.TaoBoi = dt.Rows[0][16].ToString();
                dTO_Lead.ChinhSuaLanCuoiVaoLuc = (DateTime)dt.Rows[0][17];
                dTO_Lead.ChinhSuaLanCuoiBoi = dt.Rows[0][18].ToString();


            }
            catch (Exception)
            {
                /* return null; */
            }
            finally
            {
                conn.Close();
            }
        }
        public string SuaThongTinLead(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set HoTenLead = @HoTenLead, GioiTinhLead = @GioiTinhLead, NgaySinhLead = @NgaySinhLead, SoDienThoaiLead = @SoDienThoaiLead, EmailLead = @Email, MaNgheNghiep = @MaNgheNghiep, TenNgheNghiep = @TenNgheNghiep, NguonLead = @NguonLead, GhiChuLead = @GhiChuLead, ChinhSuaLanCuoiVaoLuc = GETDATE(), ChinhSuaLanCuoiBoi = @MaPIC where MaLead = @MaLead", conn);

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = dTO_Lead.HoTenLead;

                cmd.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                cmd.Parameters["@GioiTinhLead"].Value = dTO_Lead.GioiTinhLead;

                cmd.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                cmd.Parameters["@NgaySinhLead"].Value = dTO_Lead.GioiTinhLead;

                cmd.Parameters.Add("@SoDienThoaiLead", SqlDbType.Char);
                cmd.Parameters["@SoDienThoaiLead"].Value = dTO_Lead.SoDienThoaiLead;

                cmd.Parameters.Add("@EmailLead", SqlDbType.NVarChar);
                cmd.Parameters["@EmailLead"].Value = dTO_Lead.EmailLead;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = dTO_Lead.MaNgheNghiep;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = dTO_Lead.TenNgheNghiep;

                cmd.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                cmd.Parameters["@NguonLead"].Value = dTO_Lead.NguonLead;

                cmd.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                cmd.Parameters["@GhiChuLead"].Value = dTO_Lead.GhiChuLead;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = dTO_Lead.ChinhSuaLanCuoiVaoLuc;

                cmd.Parameters.Add("@MaPIC", SqlDbType.NVarChar);
                cmd.Parameters["@MaPIC"].Value =  "STA0";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
                return "Fail";
            }
            catch (Exception)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InsertHDLead (DTO_Lead lead)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select HoTenNV from NhanVien where MaNV=@MaNV", conn);
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = lead.MaNVPhuTrachLead;
                lead.TenNVPhuTrachLead = cmd.ExecuteScalar().ToString();

                SqlCommand cmdNewHDLead = new SqlCommand("Insert into HoatDongLead(MaLead,TenHDLead,LoaiHDLead,HDLeadDuocTaoBoi, MaNVPhuTrachHDLead, TenNVPhuTrachHDLead, MaEmailDenLead, TaoVaoLuc) " +
                "values " +
                "(@MaLead, @TenHDLead, @LoaiHDLead, @HDLeadDuocTaoBoi, @MaNVPhuTrachHDLead, @TenNVPhuTrachHDLead, @MaEmailDenLead, @TaoVaoLuc)", conn);

                cmdNewHDLead.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmdNewHDLead.Parameters["@MaLead"].Value = lead.MaLead;

                cmdNewHDLead.Parameters.Add("@TenHDLead", SqlDbType.NVarChar);
                cmdNewHDLead.Parameters["@TenHDLead"].Value = "Yêu cầu tư vấn đến " + lead.HoTenLead;

                cmdNewHDLead.Parameters.Add("@LoaiHDLead", SqlDbType.NVarChar);
                cmdNewHDLead.Parameters["@LoaiHDLead"].Value = "Yêu cầu";

                cmdNewHDLead.Parameters.Add("@HDLeadDuocTaoBoi", SqlDbType.NVarChar);
                cmdNewHDLead.Parameters["@HDLeadDuocTaoBoi"].Value = lead.HoTenLead;

                cmdNewHDLead.Parameters.Add("@MaNVPhuTrachHDLead ", SqlDbType.VarChar);
                cmdNewHDLead.Parameters["@MaNVPhuTrachHDLead"].Value = lead.MaNVPhuTrachLead;

                cmdNewHDLead.Parameters.Add("@TenNVPhuTrachHDLead", SqlDbType.NVarChar);
                cmdNewHDLead.Parameters["@TenNVPhuTrachHDLead"].Value = lead.TenNVPhuTrachLead;

                cmdNewHDLead.Parameters.AddWithValue("@MaEmailDenLead", string.IsNullOrEmpty("") ? (object)DBNull.Value : "");

                cmdNewHDLead.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmdNewHDLead.Parameters["@TaoVaoLuc"].Value = DateTime.Now;
                if (cmdNewHDLead.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    } 
}
