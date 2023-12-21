using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
        public DataSet DanhSachKhoaHoc(DTO_Lead dTO_Lead)
          {
              try
              {
                  conn.Open();
                  string cmdText = "Select * from KhoaHoc where MaKhoaHoc in (select MaKhoaHoc from " +
                    "ChiTietKhoaHocThuocYeuCauTuVan where MaTuVan in (Select MaTuVan from YeuCauTuVan where TaoBoiLead = @MaLead))";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                  DataSet db = new DataSet();
                  da.Fill(db, "KhoaHoc");
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
        public void SelectLead(ref DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                string cmdText = "select * from Lead where MaLead = @MaLead";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                da.Dispose();
                dTO_Lead.HoTenLead = dt.Rows[0][2].ToString();
                dTO_Lead.GioiTinhLead = dt.Rows[0][3].ToString();
                dTO_Lead.NgaySinhLead = (DateTime)dt.Rows[0][4];
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
                dTO_Lead.LeadTuKhachHangCu = dt.Rows[0][15].ToString();
                dTO_Lead.TaoVaoLuc = (DateTime)dt.Rows[0][16];
                dTO_Lead.TaoBoi = dt.Rows[0][17].ToString();
                dTO_Lead.ChinhSuaLanCuoiVaoLuc = (DateTime)dt.Rows[0][18];
                dTO_Lead.ChinhSuaLanCuoiBoi = dt.Rows[0][19].ToString();


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
        public string HuyTheoDoiTuVan(DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set TrangThaiLead = N'Ngừng theo dõi', LyDoTrangThaiLead = @LyDoTrangThaiLead where MaLead = @MaLead", conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);
                cmd.Parameters["@LyDoTrangThaiLead"].Value = dTO_Lead.LyDoTrangThaiLead;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
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

                SqlCommand cmd = new SqlCommand("Update Lead set TrangThaiLead = N'Xóa mềm', LyDoTrangThaiLead = @LyDoTrangThaiLead  where MaLead = @MaLead", conn);
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@LyDoTrangThaiLead", SqlDbType.NVarChar);                         
                cmd.Parameters["@LyDoTrangThaiLead"].Value = dTO_Lead.LyDoTrangThaiLead;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
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
       

                
         public string SuaThongTinLead(DTO_Lead dTO_Lead)
        {
               try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set HoTenLead = @HoTenLead, GioiTinhLead = @GioiTinhLead, NgaySinhLead = @NgaySinhLead, SoDienThoaiLead = @SoDienThoaiLead, EmailLead = @EmailLead, MaNgheNghiep = @MaNgheNghiep, TenNgheNghiep = @TenNgheNghiep, NguonLead = @NguonLead, GhiChuLead = @GhiChuLead, ChinhSuaLanCuoiVaoLuc = GETDATE(), ChinhSuaLanCuoiBoi = @MaPIC where MaLead = @MaLead", conn);
              
                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = dTO_Lead.MaLead;

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = dTO_Lead.HoTenLead;

                cmd.Parameters.Add("@GioiTinhLead", SqlDbType.NVarChar);
                cmd.Parameters["@GioiTinhLead"].Value = dTO_Lead.GioiTinhLead;

                cmd.Parameters.Add("@NgaySinhLead", SqlDbType.DateTime);
                cmd.Parameters["@NgaySinhLead"].Value = dTO_Lead.NgaySinhLead;

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

                cmd.Parameters.Add("@MaPIC", SqlDbType.NVarChar);
                cmd.Parameters["@MaPIC"].Value = dTO_Lead.MaLead;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
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
        public string ThemChiTietKhoaHocThuocYeuCauTuvan(DTO_ChiTietKhoaHocThuocYCTV khThuocYCTV)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietKhoaHocThuocYeuCauTuVan " +
                                                "VALUES (@MaTuVan, @MaKhoaHoc, @TenKhoaHoc, @GiangVien, @GiaTien)", conn);

                cmd.Parameters.Add("@MaTuVan", SqlDbType.VarChar);
                cmd.Parameters["@MaTuVan"].Value = khThuocYCTV.MaBaoGia;

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
                    return "Success";
                }
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
    }
}
