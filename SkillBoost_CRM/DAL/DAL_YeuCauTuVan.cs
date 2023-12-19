using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DTO;
using System.Diagnostics.SymbolStore;

namespace DAL
{
    public class DAL_YeuCauTuVan : DBConnect
    {
        public DataTable SelectYCTV()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.MaTuVan as 'Mã Tư Vấn',YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' from YeuCauTuVan"
                                                , conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dt.Columns.Add("Tên Khóa Học");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM ChiTietKhoaHocThuocYeuCauTuVan WHERE MaTuVan = \'" + dt.Rows[i][0] + "\'", conn);

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt2);
                    da1.Dispose();
                    string s = dt2.Rows[0][2].ToString();
                    for (int j = 1; j < dt2.Rows.Count; j++)
                    {
                        s = s + ", " + dt2.Rows[j][2].ToString();

                    }
                    dt.Rows[i][4] = s;
                }

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable TimYCTV(string s)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' "
                                                + "from YeuCauTuVan where TenLeadYeuCau like N'%" + s + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable LocYCTV(string s)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' "
                                                + "from YeuCauTuVan where TrangThaiYCTV like N'%" + s + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InsertYCTV(DTO_YeuCauTuVan tt_yctv)
        {
            try
            {
                DAL_YeuCauTuVan dAL_YeuCauTuVan = new DAL_YeuCauTuVan();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select MaLead from Lead where SoDienThoaiLead = @SDT", conn);
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tt_yctv.SDTLeadYeuCau;
                tt_yctv.TaoBoiLead = cmd.ExecuteScalar().ToString();

                SqlCommand cmdYCTV = new SqlCommand("Insert into YeuCauTuVan (TenLeadYeuCau,NgaySinhLeadYeuCau,EmailLeadYeuCau,SDTLeadYeuCau,GhiChuYCTV,TrangThaiYCTV,TaoVaoLuc,TaoBoiLead) " +
                    "values " +
                    "(@TenLeadYeuCau, @NgaySinhLeadYeuCau, @EmailLeadYeuCau, @SDTLeadYeuCau, @GhiChuYCTV, @TrangThaiYCTV, @TaoVaoLuc, @TaoBoiLead)", conn);

                cmdYCTV.Parameters.Add("@TenLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TenLeadYeuCau"].Value = tt_yctv.TenLeadYeuCau;

                cmdYCTV.Parameters.Add("@NgaySinhLeadYeuCau", SqlDbType.DateTime);
                cmdYCTV.Parameters["@NgaySinhLeadYeuCau"].Value = tt_yctv.NgaySinhLeadYeuCau;

                cmdYCTV.Parameters.Add("@EmailLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@EmailLeadYeuCau"].Value = tt_yctv.EmailLeadYeuCau;

                cmdYCTV.Parameters.Add("@SDTLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@SDTLeadYeuCau"].Value = tt_yctv.SDTLeadYeuCau;

                cmdYCTV.Parameters.Add("@GhiChuYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@GhiChuYCTV"].Value = tt_yctv.GhiChuYCTV;

                cmdYCTV.Parameters.Add("@TrangThaiYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TrangThaiYCTV"].Value = tt_yctv.TrangThaiYCTV;

                cmdYCTV.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmdYCTV.Parameters["@TaoVaoLuc"].Value = tt_yctv.TaoVaoLuc;

                cmdYCTV.Parameters.Add("@TaoBoiLead", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TaoBoiLead"].Value = tt_yctv.TaoBoiLead;

                SqlCommand cmdChiTietKhoaHoc = new SqlCommand("Insert Into ChiTietKhoaHocThuocYeuCauTuVan values (@MaTuVan, @MaKhoaHoc, @TenKhoaHoc, @GiangVien,@GiaTien");
                if (cmdYCTV.ExecuteNonQuery() > 0)
                {
                    
                    dAL_YeuCauTuVan.InsertChiTietKhoaHoc(tt_yctv);
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
        public bool InsertLeadcuaYCTV(DTO_YeuCauTuVan yctv)
        {
            try
            {
                DAL_YeuCauTuVan dAL_YeuCauTuVan = new DAL_YeuCauTuVan();
                //Check if a new or already had a Lead code or not ?
                conn.Open();
                SqlCommand cmdCheckLead = new SqlCommand("Select MaLead from Lead where SoDienThoaiLead = @SoDienThoaiLead", conn);
                cmdCheckLead.Parameters.Add("@SoDienThoaiLead", SqlDbType.NVarChar).Value = yctv.SDTLeadYeuCau;
                SqlDataReader reader = cmdCheckLead.ExecuteReader();

                if (reader.HasRows)
                {
                    return dAL_YeuCauTuVan.InsertYCTV(yctv);

                }
                else
                {
                    DTO_Lead lead = new DTO_Lead();
                    DAL_Lead dAL_Lead = new DAL_Lead();
                    lead.HoTenLead = yctv.TenLeadYeuCau;
                    lead.GioiTinhLead = "";
                    lead.NgaySinhLead = yctv.NgaySinhLeadYeuCau;
                    lead.SoDienThoaiLead = yctv.SDTLeadYeuCau;
                    lead.EmailLead = yctv.EmailLeadYeuCau;
                    lead.MaNgheNghiep = "";
                    lead.TenNgheNghiep = "";
                    lead.MaNVPhuTrachLead = "STA0";
                    lead.TenNVPhuTrachLead = "";
                    lead.TrangThaiLead = yctv.TrangThaiYCTV;
                    lead.LyDoTrangThaiLead = "";
                    lead.NguonLead = "Website";
                    lead.GhiChuLead = yctv.GhiChuYCTV;
                    lead.LeadTuKHCu = "";
                    lead.TaoVaoLuc = yctv.TaoVaoLuc;
                    lead.TaoBoi = "Hệ thống";
                    lead.ChinhSuaLanCuoiVaoLuc = yctv.TaoVaoLuc;
                    lead.ChinhSuaLanCuoiBoi = "Hệ thống";
                    reader.Close();
                    
                    
                    
                    DAL_HoatDongLead dAL_HDLead = new DAL_HoatDongLead();
                    if (dAL_Lead.InsertLead(lead))
                    {
                        SqlCommand cmdmalead = new SqlCommand("select top 1 MaLead from Lead order by STT DESC", conn);
                        dAL_HDLead.MaLead = cmdmalead.ExecuteScalar().ToString();
                        if (dAL_HDLead.ThemHoatDongLead())
                        {
                            return true;
                        }
                        else return false; 

                    }

                    return false;
                }
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
        public DataTable SelectKhoaHoc()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaKhoaHoc, TenKhoaHoc FROM KhoaHoc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InsertChiTietKhoaHoc(DTO_YeuCauTuVan khoahoc_yctv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select TenKhoaHoc from KhoaHoc where MaKhoaHoc = @MaKhoaHoc", conn);
                cmd1.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = khoahoc_yctv.MaKhoaHoc;
                khoahoc_yctv.TenKhoaHoc = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand("select GiangVien from KhoaHoc where MaKhoaHoc = @MaKhoaHoc", conn);
                cmd2.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = khoahoc_yctv.MaKhoaHoc;
                khoahoc_yctv.GiangVien = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd3 = new SqlCommand("select GiaTien from KhoaHoc where MaKhoaHoc = @MaKhoaHoc", conn);
                cmd3.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = khoahoc_yctv.MaKhoaHoc;
                khoahoc_yctv.GiaTien = cmd3.ExecuteScalar().ToString();
                SqlCommand cm4 = new SqlCommand("select top 1 MaTuVan from YeuCauTuVan order by STT DESC", conn);
                khoahoc_yctv.MaTuVan = cm4.ExecuteScalar().ToString();

                SqlCommand cmdChiTietKhoaHoc = new SqlCommand("Insert into ChiTietKhoaHocThuocYeuCauTuVan values (@MaTuVan, @MaKhoaHoc, @TenKhoaHoc, @GiangVien, @GiaTien) ", conn);

                cmdChiTietKhoaHoc.Parameters.Add("@MaTuVan", SqlDbType.NVarChar);
                cmdChiTietKhoaHoc.Parameters["@MaTuVan"].Value = khoahoc_yctv.MaTuVan;

                cmdChiTietKhoaHoc.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar);
                cmdChiTietKhoaHoc.Parameters["@MaKhoaHoc"].Value = khoahoc_yctv.MaKhoaHoc;

                cmdChiTietKhoaHoc.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar);
                cmdChiTietKhoaHoc.Parameters["@TenKhoaHoc"].Value = khoahoc_yctv.TenKhoaHoc;

                cmdChiTietKhoaHoc.Parameters.Add("@GiangVien", SqlDbType.NVarChar);
                cmdChiTietKhoaHoc.Parameters["@GiangVien"].Value = khoahoc_yctv.GiangVien;

                cmdChiTietKhoaHoc.Parameters.Add("@GiaTien", SqlDbType.NVarChar);
                cmdChiTietKhoaHoc.Parameters["@GiaTien"].Value = khoahoc_yctv.GiaTien;

                if (cmdChiTietKhoaHoc.ExecuteNonQuery() > 0)
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
