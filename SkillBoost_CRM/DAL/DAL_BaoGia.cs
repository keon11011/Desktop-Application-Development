using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_BaoGia : DBConnect
    {
        public DataTable SelectBaoGiaCuaLead(DTO_BaoGia baoGiaLead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaBaoGia, TenBaoGia, MaLead, HoTenLead, TongTienTruocGiam, MaGiamGia, PhanTramGiamGia, TongTien, TrangThaiBaoGia "
                                   + "FROM BaoGia "
                                   + "WHERE MaLead = @MaLead AND TrangThaiBaoGia != N'Xóa mềm' "
                                   + "ORDER BY STT ASC", conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = baoGiaLead.MaLead;

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
        public DataTable SelectAllKhoaHoc()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien FROM KhoaHoc "
                                                       + "ORDER BY STT ASC", conn);
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
        public DataTable Select1KhoaHoc(DTO_KhoaHoc khoaHoc)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien FROM KhoaHoc "
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
        public DataTable SelectNgheNghiepCuaLead(DTO_Lead lead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaLead, HoTenLead, MaNgheNghiep, TenNgheNghiep "
                                   + "FROM Lead "
                                   + "WHERE MaLead = @MaLead ", conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = lead.MaLead;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();
                return dt;
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
        public string TaoMaGiamGia(DTO_MaGiamGia maGiamGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO MaGiamGia " +
                                                "VALUES (@MoTaMaGiamGia, @PhamViApDung, @PhanTramGiamGia, @TrangThaiMaGiamGia, @MaQuyDinhGiamGia, @TaoVaoLuc, @TaoBoi)", conn);

                cmd.Parameters.Add("@MoTaMaGiamGia", SqlDbType.VarChar);
                cmd.Parameters["@MoTaMaGiamGia"].Value = maGiamGia.MoTaGiamGia;

                cmd.Parameters.Add("@PhamViApDung", SqlDbType.NVarChar);
                cmd.Parameters["@PhamViApDung"].Value = maGiamGia.PhamViApDung;

                cmd.Parameters.Add("@PhanTramGiamGia", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGia"].Value = maGiamGia.PhanTramGiamGia;

                cmd.Parameters.Add("@TrangThaiMaGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiMaGiamGia"].Value = maGiamGia.TrangThaiMaGiamGia;

                cmd.Parameters.Add("@MaQuyDinhGiamGia", SqlDbType.VarChar);
                cmd.Parameters["@MaQuyDinhGiamGia"].Value = maGiamGia.MaQuyDinhGiamGia;
                /*
                cmd.Parameters.Add("@MaQuyDinhGiamGia", SqlDbType.VarChar, 50).IsNullable = true;
                cmd.Parameters["@MaQuyDinhGiamGia"].Value = (object)maGiamGia.MaQuyDinhGiamGia ?? DBNull.Value;
                */


                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = "Hệ thống";

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
        public DataTable SelectMaGiamGiaMoiTao()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaGiamGia, PhanTramGiamGia FROM MaGiamGia "
                                                       + "ORDER BY STT DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
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
        public string TaoBaoGia(DTO_BaoGia baoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO BaoGia " +
                                                "VALUES (@TenBaoGia, @MaLead, @HoTenLead, @TongTienTruocGiam, @MaGiamGia, @PhanTramGiamGia, @TongTien, @TrangThaiBaoGia, @TaoVaoLuc, @TaoBoi, @ChinhSuaLanCuoiVaoLuc, @ChinhSuaLanCuoiBoi)", conn);

                cmd.Parameters.Add("@TenBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TenBaoGia"].Value = baoGia.TenBaoGia;

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = baoGia.MaLead;

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = baoGia.HoTenLead;

                cmd.Parameters.Add("@TongTienTruocGiam", SqlDbType.Float);
                cmd.Parameters["@TongTienTruocGiam"].Value = baoGia.TongTienTruocGiam;

                /*
                cmd.Parameters.Add("@MaGiamGia", SqlDbType.VarChar);
                cmd.Parameters["@MaGiamGia"].Value = baoGia.MaGiamGia;

                cmd.Parameters.Add("@PhanTramGiamGia", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGia"].Value = baoGia.PhanTramGiamGia;
                */
                cmd.Parameters.Add("@MaGiamGia", SqlDbType.VarChar, 13).IsNullable = true;
                cmd.Parameters["@MaGiamGia"].Value = (object)baoGia.MaGiamGia ?? DBNull.Value;

                cmd.Parameters.Add("@PhanTramGiamGia", SqlDbType.Int).IsNullable = true;
                cmd.Parameters["@PhanTramGiamGia"].Value = (object)baoGia.PhanTramGiamGia ?? DBNull.Value;

                cmd.Parameters.Add("@TongTien", SqlDbType.Float);
                cmd.Parameters["@TongTien"].Value = baoGia.TongTien;

                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = baoGia.TrangThaiBaoGia;

                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = "Hệ thống";

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = "Hệ thống";


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
        public DataTable SelectBaoGiaMoiTao()
        {
            try
            {
                conn.Open();
                /*
                 * SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaGiamGia, PhanTramGiamGia FROM MaGiamGia "
                                                       + "ORDER BY STT DESC", conn);
                 */

                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaBaoGia, TenBaoGia FROM BaoGia "
                                                       + "ORDER BY STT DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
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
        public string ThemChiTietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietKhoaHocThuocBaoGia " +
                                                "VALUES (@MaBaoGia, @MaKhoaHoc, @TenKhoaHoc, @GiangVien, @GiaTien)", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = khThuocBaoGia.MaBaoGia;

                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar);
                cmd.Parameters["@MaKhoaHoc"].Value = khThuocBaoGia.MaKhoaHoc;

                cmd.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar);
                cmd.Parameters["@TenKhoaHoc"].Value = khThuocBaoGia.TenKhoaHoc;

                cmd.Parameters.Add("@GiangVien", SqlDbType.NVarChar);
                cmd.Parameters["@GiangVien"].Value = khThuocBaoGia.GiangVien;

                cmd.Parameters.Add("@GiaTien", SqlDbType.Float);
                cmd.Parameters["@GiaTien"].Value = khThuocBaoGia.GiaTien;

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
        public string XoaBaoGia(DTO_BaoGia baoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE BaoGia "
                                                + "SET TrangThaiBaoGia = @TrangThaiBaoGia, "
                                                + "ChinhSuaLanCuoiVaoLuc = @ChinhSuaLanCuoiVaoLuc "
                                                + "WHERE MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = baoGia.MaBaoGia;

                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = baoGia.TrangThaiBaoGia;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

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
        public DataTable SelectChiTietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien, MaBaoGia FROM ChiTietKhoaHocThuocBaoGia "
                                                + "WHERE MaBaoGia LIKE @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = khThuocBaoGia.MaBaoGia;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
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
        public DataTable SelectBaoGiaCuThe(DTO_BaoGia baoGia)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaBaoGia, TenBaoGia, MaLead, HoTenLead, TongTienTruocGiam, MaGiamGia, PhanTramGiamGia, TongTien, TrangThaiBaoGia "
                                                + "FROM BaoGia "
                                                + "WHERE MaBaoGia = @MaBaoGia AND TrangThaiBaoGia != N'Xóa mềm'", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = baoGia.MaBaoGia;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();
                return dt;
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
        public string SuaBaoGia(DTO_BaoGia baoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE BaoGia "
                                                + "SET TenBaoGia = @TenBaoGia, TongTienTruocGiam = @TongTienTruocGiam, "
                                                + "MaGiamGia = @MaGiamGia, PhanTramGiamGia = @PhanTramGiamGia, "
                                                + "TongTien = @TongTien, TrangThaiBaoGia = @TrangThaiBaoGia, "
                                                + "ChinhSuaLanCuoiVaoLuc = @ChinhSuaLanCuoiVaoLuc "
                                                + "WHERE MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = baoGia.MaBaoGia;

                cmd.Parameters.Add("@TenBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TenBaoGia"].Value = baoGia.TenBaoGia;

                cmd.Parameters.Add("@TongTienTruocGiam", SqlDbType.Float);
                cmd.Parameters["@TongTienTruocGiam"].Value = baoGia.TongTienTruocGiam;

                cmd.Parameters.Add("@MaGiamGia", SqlDbType.VarChar, 13).IsNullable = true;
                cmd.Parameters["@MaGiamGia"].Value = (object)baoGia.MaGiamGia ?? DBNull.Value;

                cmd.Parameters.Add("@PhanTramGiamGia", SqlDbType.Int).IsNullable = true;
                cmd.Parameters["@PhanTramGiamGia"].Value = (object)baoGia.PhanTramGiamGia ?? DBNull.Value;

                cmd.Parameters.Add("@TongTien", SqlDbType.Float);
                cmd.Parameters["@TongTien"].Value = baoGia.TongTien;

                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = baoGia.TrangThaiBaoGia;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

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
        public string SuaTrangThaiBaoGia(DTO_BaoGia baoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE BaoGia "
                                                + "SET TrangThaiBaoGia = @TrangThaiBaoGia, "
                                                + "ChinhSuaLanCuoiVaoLuc = @ChinhSuaLanCuoiVaoLuc "
                                                + "WHERE MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = baoGia.MaBaoGia;

                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = baoGia.TrangThaiBaoGia;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

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
        public string XoaChiThietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietKhoaHocThuocBaoGia "
                                                + "WHERE MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = khThuocBaoGia.MaBaoGia;

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
