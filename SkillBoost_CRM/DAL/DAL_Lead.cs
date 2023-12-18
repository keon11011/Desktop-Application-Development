using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace DAL
{
    public class DAL_Lead : DBConnect
    {
        public DataSet SelectNgheNghiep()
        public void InsertYCTVcuaLeadOld()
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
            catch (Exception ex)
        public bool InsertYCTVcuaLeadNew(DTO_Lead tt_yctv)
        {
                return null;
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
                    SqlCommand cmdYCTVNewLead = new SqlCommand("Insert into Lead(HoTenLead,GioiTinhLead,NgaySinhLead,SoDienThoaiLead,EmailLead,MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachLead, TenNVPhuTrachLead, TrangThaiLead, LyDoTrangThaiLead, NguonLead, GhiChuLead, LeadTuKHCu, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi " +
                    "values " +
                    "(@HoTenLead, @GioiTinhLead, @NgaySinhLead, @SoDienThoaiLead, @EmailLead, @MaNgheNghiep, @TenNgheNghiep, @MaNVPhuTrachLead,@TenNVPhuTrachLead,@TrangThaiLead,@LyDoTrangThaiLead,@NguonLead,@GhiChuLead,@LeadTuKHCu,@TaoVaoLuc,@TaoBoi,@ChinhSuaLanCuoiVaoLuc,@ChinhSuaLanCuoiBoi)", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                    cmdYCTVNewLead.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@HoTenLead"].Value = tt_yctv.HoTenLead;

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
                dTO_Lead.LeadTuKhachHangCu = dt.Rows[0][14].ToString();
                dTO_Lead.TaoVaoLuc = (DateTime)dt.Rows[0][15];
                dTO_Lead.TaoBoi = dt.Rows[0][16].ToString();
                dTO_Lead.ChinhSuaLanCuoiVaoLuc = (DateTime)dt.Rows[0][17];
                dTO_Lead.ChinhSuaLanCuoiBoi = dt.Rows[0][18].ToString();
                    cmdYCTVNewLead.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@GioiTinhLead"].Value = tt_yctv.GioiTinhLead;

                    cmdYCTVNewLead.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@NgaySinhLead"].Value = tt_yctv.NgaySinhLead;

            }
            catch (Exception ex)
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
                    cmdYCTVNewLead.Parameters.Add("@SoDienThoaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@SoDienThoaiLead"].Value = tt_yctv.SoDienThoaiLead;

                    cmdYCTVNewLead.Parameters.Add("@EmailLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@EmailLead"].Value = tt_yctv.EmailLead;

                    cmdYCTVNewLead.Parameters.Add("@MaNgheNghiep", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@MaNgheNghiep"].Value = tt_yctv.MaNgheNghiep;

                SqlCommand cmd = new SqlCommand("Update Lead set HoTenLead = @HoTenLead, GioiTinhLead = @GioiTinhLead, NgaySinhLead = @NgaySinhLead, SoDienThoaiLead = @SoDienThoaiLead, EmailLead = @Email, MaNgheNghiep = @MaNgheNghiep, TenNgheNghiep = @TenNgheNghiep, NguonLead = @NguonLead, GhiChuLead = @GhiChuLead, ChinhSuaLanCuoiVaoLuc = GETDATE(), ChinhSuaLanCuoiBoi = @MaPIC where MaLead = @MaLead", conn);
                    cmdYCTVNewLead.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TenNgheNghiep"].Value = tt_yctv.TenNgheNghiep;

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = dTO_Lead.HoTenLead;
                    cmdYCTVNewLead.Parameters.Add("@MaNVPhuTrachLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@MaNVPhuTrachLead"].Value = tt_yctv.MaNVPhuTrachLead;

                cmd.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                cmd.Parameters["@GioiTinhLead"].Value = dTO_Lead.GioiTinhLead;
                    cmdYCTVNewLead.Parameters.Add("@TenNVPhuTrachLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TenNVPhuTrachLead"].Value = tt_yctv.TenNVPhuTrachLead;

                cmd.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                cmd.Parameters["@NgaySinhLead"].Value = dTO_Lead.GioiTinhLead;
                    cmdYCTVNewLead.Parameters.Add("@TrangThaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TrangThaiLead"].Value = tt_yctv.TrangThaiLead;

                cmd.Parameters.Add("@SoDienThoaiLead", SqlDbType.Char);
                cmd.Parameters["@SoDienThoaiLead"].Value = dTO_Lead.SoDienThoaiLead;
                    cmdYCTVNewLead.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@LyDoTrangThaiLead"].Value = tt_yctv.LyDoTrangThaiLead;

                cmd.Parameters.Add("@EmailLead", SqlDbType.NVarChar);
                cmd.Parameters["@EmailLead"].Value = dTO_Lead.EmailLead;
                    cmdYCTVNewLead.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@NguonLead"].Value = tt_yctv.NguonLead;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = dTO_Lead.MaNgheNghiep;
                    cmdYCTVNewLead.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@GhiChuLead"].Value = tt_yctv.GhiChuLead;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = dTO_Lead.TenNgheNghiep;
                    cmdYCTVNewLead.Parameters.Add("@LeadTuKHCu", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@LeadTuKHCu"].Value = tt_yctv.LeadTuKHCu;

                cmd.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                cmd.Parameters["@NguonLead"].Value = dTO_Lead.NguonLead;
                    cmdYCTVNewLead.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@TaoVaoLuc"].Value = tt_yctv.TaoVaoLuc;

                cmd.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                cmd.Parameters["@GhiChuLead"].Value = dTO_Lead.GhiChuLead;
                    cmdYCTVNewLead.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TaoBoi"].Value = tt_yctv.TaoBoi;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = dTO_Lead.ChinhSuaLanCuoiVaoLuc;
                    cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = tt_yctv.ChinhSuaLanCuoiVaoLuc;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = dTO_Lead.MaLead;
                    cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiBoi"].Value = tt_yctv.ChinhSuaLanCuoiBoi;

                if (cmd.ExecuteNonQuery() > 0)
                    if (cmdYCTVNewLead.ExecuteNonQuery() > 0)
                    {
                    return "Success";
                        return true;
                    }
                return "Fail";
                    return false;
                
            }
            catch (Exception ex)
            catch (Exception)
            {
                return "Exception";
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
