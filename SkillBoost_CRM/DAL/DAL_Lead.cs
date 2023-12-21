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
                da.Dispose();
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
                    cmdYCTVNewLead.Dispose();
                    return true;
                }
                cmdYCTVNewLead.Dispose();
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
                string cmdText = "select * from Lead where MaLead = @MaLead";

                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();
                dTO_Lead.HoTenLead = dt.Rows[0][2].ToString();
                dTO_Lead.GioiTinhLead = dt.Rows[0][3].ToString();
                if (dt.Rows[0][4] == DBNull.Value)
                {
                    dTO_Lead.NgaySinhLead = null;
                }
                else 
                {
                    dTO_Lead.NgaySinhLead = (DateTime)dt.Rows[0][4];
                }
                dTO_Lead.SoDienThoaiLead = dt.Rows[0][5].ToString();
                dTO_Lead.EmailLead = dt.Rows[0][6].ToString();
                dTO_Lead.MaNgheNghiep = dt.Rows[0][7].ToString();
                dTO_Lead.TenNgheNghiep = dt.Rows[0][8].ToString();
                dTO_Lead.MaNVPhuTrachLead = dt.Rows[0][9].ToString();
                dTO_Lead.TenNVPhuTrachLead = dt.Rows[0][10].ToString();
                dTO_Lead.TrangThaiLead = dt.Rows[0][11].ToString();
                dTO_Lead.LyDoTrangThaiLead = dt.Rows[0][12].ToString();
                dTO_Lead.NguonLead = dt.Rows[0][13].ToString();
                dTO_Lead.GhiChuLead = dt.Rows[0][14].ToString();
                dTO_Lead.LeadTuKHCu = dt.Rows[0][15].ToString();
                dTO_Lead.TaoVaoLuc = (DateTime)dt.Rows[0][16];
                dTO_Lead.TaoBoi = dt.Rows[0][17].ToString();
                dTO_Lead.ChinhSuaLanCuoiVaoLuc = (DateTime)dt.Rows[0][18];
                dTO_Lead.ChinhSuaLanCuoiBoi = dt.Rows[0][19].ToString();
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

                SqlCommand cmd = new SqlCommand("Update Lead set HoTenLead = @HoTenLead, GioiTinhLead = @GioiTinhLead, NgaySinhLead = @NgaySinhLead, " +
                    "SoDienThoaiLead = @SoDienThoaiLead, EmailLead = @Email, MaNgheNghiep = @MaNgheNghiep, TenNgheNghiep = @TenNgheNghiep, " +
                    "NguonLead = @NguonLead, GhiChuLead = @GhiChuLead, ChinhSuaLanCuoiVaoLuc = GETDATE(), " +
                    "ChinhSuaLanCuoiBoi = @MaPIC where MaLead = @MaLead", conn);

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

                cmd.Parameters.Add("@MaPIC", SqlDbType.VarChar);
                cmd.Parameters["@MaPIC"].Value =  dTO_Lead.MaNVPhuTrachLead;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
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
        public string LayMaPIC(string MaLead)
        {
            try
            {
                conn.Open();
                string cmdText = "select MaNVPhuTrachLead from Lead where MaLead = @MaLead";

                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.AddWithValue("@MaLead", MaLead);
                string s = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                return s;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public string LayTenPIC(string MaLead)
        {
            try
            {
                conn.Open();
                string cmdText = "select TenNVPhuTrachLead from Lead where MaLead = @MaLead";

                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.AddWithValue("@MaLead", MaLead);
                string s = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                return s;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataSet SelectKhoaHoc()
        {
            try
            {
                conn.Open();
                string cmdText = "select * from KhoaHoc";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "KhoaHoc");
                da.Dispose();
                return ds;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataSet DanhSachKhoaHoc(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                string cmdText = "Select * from KhoaHoc where MaKhoaHoc in (select MaKhoaHoc from ChiTietKhoaHocThuocYeuCauTuVan where MaTuVan in (Select MaTuVan from YeuCauTuVan where TaoBoiLead = @MaLead))";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet db = new DataSet();
                da.Fill(db, "KhoaHoc");
                da.Dispose();
                cmd.Dispose();
                return db;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public string HuyTheoDoiTuVan(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set TrangThaiLead = N'Ngừng theo dõi', LyDoTrangThaiLead = @LyDoTrangThaiLead, ChinhSuaLanCuoiBoi = @ChinhSuaLanCuoiBoi" +
                    " where MaLead = @MaLead", conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.VarChar);
                cmd.Parameters["@LyDoTrangThaiLead"].Value = dTO_Lead.LyDoTrangThaiLead;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.VarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = dTO_Lead.ChinhSuaLanCuoiBoi;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public string XoaMemLead(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set TrangThaiLead = N'Xóa mềm', LyDoTrangThaiLead = @LyDoTrangThaiLead, ChinhSuaLanCuoiBoi = @ChinhSuaLanCuoiBoi" +
                    " where MaLead = @MaLead", conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                cmd.Parameters["@LyDoTrangThaiLead"].Value = dTO_Lead.LyDoTrangThaiLead;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.VarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = dTO_Lead.ChinhSuaLanCuoiBoi;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public string TiepNhanLead(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Lead SET MaNVPhuTrachLead = @MaNVPhuTrachLead, TenNVPhuTrachLead = @TenNVPhuTrachLead, " +
                    "TrangThaiLead = N'Đang tư vấn', ChinhSuaLanCuoiVaoLuc = GETDATE(), LyDoTrangThaiLead = @LyDoTrangThaiLead, ChinhSuaLanCuoiBoi = @MaNVPhuTrachLead WHERE MaLead = @MaLead", conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@MaNVPhuTrachLead", SqlDbType.VarChar);
                cmd.Parameters["@MaNVPhuTrachLead"].Value = dTO_Lead.MaNVPhuTrachLead;

                cmd.Parameters.Add("@TenNVPhuTrachLead", SqlDbType.NVarChar);
                cmd.Parameters["@TenNVPhuTrachLead"].Value = dTO_Lead.TenNVPhuTrachLead;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.VarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = dTO_Lead.MaNVPhuTrachLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                cmd.Parameters["@LyDoTrangThaiLead"].Value = "Yêu cầu tư vấn được tiếp nhận";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable DanhSachLead(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                string cmdText = "Select * from Lead where TrangThaiLead not like N'Xóa mềm'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable db = new DataTable();
                da.Fill(db);
                da.Dispose();
                cmd.Dispose();
                return db;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public string Themlead(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Lead(HoTenLead, GioiTinhLead, NgaySinhLead, SoDienThoaiLead, EmailLead, MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachLead, TenNVPhuTrachLead, TrangThaiLead, LyDoTrangThaiLead, NguonLead, GhiChuLead, LeadTuKHCu, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi) " +
                    "VALUES ( @HoTenLead, @GioiTinhLead ,@NgaySinhLead , @SoDienThoaiLead, @EmailLead, @MaNgheNghiep, @TenNgheNghiep, @MaNVPhuTrachLead, @TenNVPhuTrachLead, @TrangThaiLead, @LyDoTrangThaiLead, @NguonLead, @GhiChuLead, @LeadTuKHCu, GETDATE(), @TaoBoi, GETDATE(), @ChinhSuaLanCuoiBoi)", conn);

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = dTO_Lead.HoTenLead;

                cmd.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                cmd.Parameters["@GioiTinhLead"].Value = dTO_Lead.GioiTinhLead;

                cmd.Parameters.Add("@NgaySinhLead", SqlDbType.Date);
                cmd.Parameters["@NgaySinhLead"].Value = dTO_Lead.NgaySinhLead;

                cmd.Parameters.Add("@SoDienThoaiLead", SqlDbType.Char);
                cmd.Parameters["@SoDienThoaiLead"].Value = dTO_Lead.SoDienThoaiLead;

                cmd.Parameters.Add("@MaNVPhuTrachLead", SqlDbType.VarChar);
                cmd.Parameters["@MaNVPhuTrachLead"].Value = dTO_Lead.MaNVPhuTrachLead;

                cmd.Parameters.Add("@TenNVPhuTrachLead", SqlDbType.NVarChar);
                cmd.Parameters["@TenNVPhuTrachLead"].Value = dTO_Lead.TenNVPhuTrachLead;

                cmd.Parameters.Add("@TrangThaiLead", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiLead"].Value = dTO_Lead.TrangThaiLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                cmd.Parameters["@LyDoTrangThaiLead"].Value = dTO_Lead.LyDoTrangThaiLead;

                cmd.Parameters.Add("@EmailLead", SqlDbType.VarChar);
                cmd.Parameters["@EmailLead"].Value = dTO_Lead.EmailLead;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.VarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = dTO_Lead.MaNgheNghiep;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = dTO_Lead.TenNgheNghiep;

                cmd.Parameters.Add("@NguonLead", SqlDbType.NVarChar);
                cmd.Parameters["@NguonLead"].Value = dTO_Lead.NguonLead;

                cmd.Parameters.Add("@GhiChuLead", SqlDbType.NVarChar);
                cmd.Parameters["@GhiChuLead"].Value = dTO_Lead.GhiChuLead;

                cmd.Parameters.Add("@LeadTuKHCu", SqlDbType.VarChar, 15).IsNullable = true;
                cmd.Parameters["@LeadTuKHCU"].Value = (object)dTO_Lead.LeadTuKHCu ?? DBNull.Value;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = dTO_Lead.TaoBoi;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = dTO_Lead.ChinhSuaLanCuoiBoi;


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public string SelectLead()
        {
            try
            {
                conn.Open();
                string cmd = "Select Top 1 MaLead from Lead order by STT desc";
                SqlCommand cmd1 = new SqlCommand(cmd, conn);
                string s = cmd1.ExecuteScalar().ToString();
                cmd1.Dispose();
                return s;
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public string SelectTuVanMoiTao()
        {
            try
            {
                conn.Open();

                string cmdText = "SELECT top 1 MaTuVan FROM YeuCauTuVan order by STT desc";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                string s = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                return s;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public string ThemChiTietKhoaHocThuocYeuCauTuVan(DTO_ChiTietKhoaHocThuocYCTV khThuocYCTV)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietKhoaHocThuocYeuCauTuVan " +
                                                "VALUES (@MaTuVan, @MaKhoaHoc, @TenKhoaHoc, @GiangVien, @GiaTien)", conn);

                cmd.Parameters.Add("@MaTuVan", SqlDbType.VarChar);
                cmd.Parameters["@MaTuVan"].Value = khThuocYCTV.MaTuVan;

                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar);
                cmd.Parameters["@MaKhoaHoc"].Value = khThuocYCTV.MaKhoaHoc;

                cmd.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar);
                cmd.Parameters["@TenKhoaHoc"].Value = khThuocYCTV.TenKhoaHoc;

                cmd.Parameters.Add("@GiangVien", SqlDbType.NVarChar);
                cmd.Parameters["@GiangVien"].Value = khThuocYCTV.GiangVien;

                cmd.Parameters.Add("@GiaTien", SqlDbType.Float);
                cmd.Parameters["@GiaTien"].Value = khThuocYCTV.GiaTien;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public string TaoTuVanMoi(DTO_YeuCauTuVan dTO_YeuCauTuVan)
        {
            try
            {
                conn.Open();
                string cmd = "INSERT INTO YeuCauTuVan(TenLeadYeuCau, NgaySinhLeadYeuCau, EmailLeadYeuCau, SDTLeadYeuCau, GhiChuYCTV, TrangThaiYCTV, TaoVaoLuc, TaoBoiLead)\r\nVALUES \r\n(" +
                    "@TenLeadYeuCau, @NgaySinhLeadYeuCau, @EmailLeadYeuCau, @SDTLeadYeuCau, @GhiChuYCTV, @TrangThaiYCTV, GETDATE(), @TaoBoiLead)";
                SqlCommand cmdText = new SqlCommand(cmd, conn);

                cmdText.Parameters.Add("@TenLeadYeuCau", SqlDbType.NVarChar);
                cmdText.Parameters["@TenLeadYeuCau"].Value = dTO_YeuCauTuVan.TenLeadYeuCau;

                cmdText.Parameters.Add("@NgaySinhLeadYeuCau", SqlDbType.DateTime);
                cmdText.Parameters["@NgaySinhLeadYeuCau"].Value = dTO_YeuCauTuVan.NgaySinhLeadYeuCau;

                cmdText.Parameters.Add("@EmailLeadYeuCau", SqlDbType.NVarChar);
                cmdText.Parameters["@EmailLeadYeuCau"].Value = dTO_YeuCauTuVan.EmailLeadYeuCau;

                cmdText.Parameters.Add("@SDTLeadYeuCau", SqlDbType.Char);
                cmdText.Parameters["@SDTLeadYeuCau"].Value = dTO_YeuCauTuVan.SDTLeadYeuCau;

                cmdText.Parameters.Add("@GhiChuYCTV", SqlDbType.NVarChar);
                cmdText.Parameters["@GhiChuYCTV"].Value = dTO_YeuCauTuVan.GhiChuYCTV;

                cmdText.Parameters.Add("@TrangThaiYCTV", SqlDbType.NVarChar);
                cmdText.Parameters["@TrangThaiYCTV"].Value = "Đã tiếp nhận";

                cmdText.Parameters.Add("@TaoBoiLead", SqlDbType.VarChar);
                cmdText.Parameters["@TaoBoiLead"].Value = dTO_YeuCauTuVan.TaoBoiLead;

                if (cmdText.ExecuteNonQuery() > 0)
                {
                    cmdText.Dispose();
                    return "Success";
                }
                cmdText.Dispose();
                return "Fail";

            }
            catch (Exception ex)
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Select1KhoaHoc(DTO_KhoaHoc khoaHoc)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaKhoaHoc, TenKhoaHoc, MoTaKhoaHoc, ThoiLuongKhoaHoc, GiangVien, MucDoKhoaHoc, SoLuongHocVienToiDa, GiaTien FROM KhoaHoc "
                                                + "WHERE MaKhoaHoc = @MaKhoaHoc", conn);
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar);
                cmd.Parameters["@MaKhoaHoc"].Value = khoaHoc.MaKhoaHoc;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
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
        public string XoaChiTietKhoaHocThuocYCTV(DTO_ChiTietKhoaHocThuocYCTV khThuocYCTV)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietKhoaHocThuocYeuCauTuVan "
                                                + "WHERE MaTuVan = @MaTuVan", conn);

                cmd.Parameters.Add("@MaTuVan", SqlDbType.VarChar);
                cmd.Parameters["@MaTuVan"].Value = khThuocYCTV.MaTuVan;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return "Success";
                }
                cmd.Dispose();
                return "Fail";
            }
            catch
            {
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
