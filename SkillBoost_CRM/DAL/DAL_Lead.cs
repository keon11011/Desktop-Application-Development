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
        public void InsertYCTVcuaLeadOld()
        {
           
        }
        public bool InsertYCTVcuaLeadNew(DTO_Lead tt_yctv)
        {
            try
            {
                conn.Open();
                    SqlCommand cmdYCTVNewLead = new SqlCommand("Insert into Lead(HoTenLead,GioiTinhLead,NgaySinhLead,SoDienThoaiLead,EmailLead,MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachLead, TenNVPhuTrachLead, TrangThaiLead, LyDoTrangThaiLead, NguonLead, GhiChuLead, LeadTuKHCu, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi " +
                    "values " +
                    "(@HoTenLead, @GioiTinhLead, @NgaySinhLead, @SoDienThoaiLead, @EmailLead, @MaNgheNghiep, @TenNgheNghiep, @MaNVPhuTrachLead,@TenNVPhuTrachLead,@TrangThaiLead,@LyDoTrangThaiLead,@NguonLead,@GhiChuLead,@LeadTuKHCu,@TaoVaoLuc,@TaoBoi,@ChinhSuaLanCuoiVaoLuc,@ChinhSuaLanCuoiBoi)", conn);

                    cmdYCTVNewLead.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@HoTenLead"].Value = tt_yctv.HoTenLead;

                    cmdYCTVNewLead.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@GioiTinhLead"].Value = tt_yctv.GioiTinhLead;

                    cmdYCTVNewLead.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@NgaySinhLead"].Value = tt_yctv.NgaySinhLead;

                    cmdYCTVNewLead.Parameters.Add("@SoDienThoaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@SoDienThoaiLead"].Value = tt_yctv.SoDienThoaiLead;

                    cmdYCTVNewLead.Parameters.Add("@EmailLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@EmailLead"].Value = tt_yctv.EmailLead;

                    cmdYCTVNewLead.Parameters.Add("@MaNgheNghiep", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@MaNgheNghiep"].Value = tt_yctv.MaNgheNghiep;

                    cmdYCTVNewLead.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TenNgheNghiep"].Value = tt_yctv.TenNgheNghiep;

                    cmdYCTVNewLead.Parameters.Add("@MaNVPhuTrachLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@MaNVPhuTrachLead"].Value = tt_yctv.MaNVPhuTrachLead;

                    cmdYCTVNewLead.Parameters.Add("@TenNVPhuTrachLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TenNVPhuTrachLead"].Value = tt_yctv.TenNVPhuTrachLead;

                    cmdYCTVNewLead.Parameters.Add("@TrangThaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TrangThaiLead"].Value = tt_yctv.TrangThaiLead;

                    cmdYCTVNewLead.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@LyDoTrangThaiLead"].Value = tt_yctv.LyDoTrangThaiLead;

                    cmdYCTVNewLead.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@NguonLead"].Value = tt_yctv.NguonLead;

                    cmdYCTVNewLead.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@GhiChuLead"].Value = tt_yctv.GhiChuLead;

                    cmdYCTVNewLead.Parameters.Add("@LeadTuKHCu", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@LeadTuKHCu"].Value = tt_yctv.LeadTuKHCu;

                    cmdYCTVNewLead.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@TaoVaoLuc"].Value = tt_yctv.TaoVaoLuc;

                    cmdYCTVNewLead.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@TaoBoi"].Value = tt_yctv.TaoBoi;

                    cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                    cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = tt_yctv.ChinhSuaLanCuoiVaoLuc;

                    cmdYCTVNewLead.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                    cmdYCTVNewLead.Parameters["@ChinhSuaLanCuoiBoi"].Value = tt_yctv.ChinhSuaLanCuoiBoi;

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
    }
}
