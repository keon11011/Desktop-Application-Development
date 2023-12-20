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
    public class DAL_QuyDinhGiamGia : DBConnect
    {
        public DataTable SelectQuyDinhGiamGia()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaQuyDinhGiamGia, MoTaLoaiGiamGia, SoLuongKhoaHocDangKy, TenNgheNghiep, NgayBatDau, NgayKetThuc, PhanTramGiamGiaMacDinh, PhanTramGiamGiaToiDa, TrangThaiQuyDinhGiamGia, TaoVaoLuc, TaoBoiNV FROM QuyDinhGiamGia "
                                                       + "WHERE TrangThaiQuyDinhGiamGia NOT LIKE N'Xóa mềm' "
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
        public string ThemQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO QuyDinhGiamGia " +
                                                "VALUES (@MoTaLoaiGiamGia, @SoLuongKhoaHocDangKy, @MaNgheNghiep, @TenNgheNghiep, @NgayBatDau, @NgayKetThuc, @PhanTramGiamGiaMacDinh, @PhanTramGiamGiaToiDa, @TaoVaoLuc, @TaoBoi, @TaoBoiNV, @ChinhSuaLanCuoiVaoLuc, @ChinhSuaLanCuoiBoi, @TrangThaiQuyDinhGiamGia)", conn);

                cmd.Parameters.Add("@MoTaLoaiGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@MoTaLoaiGiamGia"].Value = qdGiamGia.MoTaLoaiGiamGia;

                cmd.Parameters.Add("@SoLuongKhoaHocDangKy", SqlDbType.Int);
                cmd.Parameters["@SoLuongKhoaHocDangKy"].Value = qdGiamGia.SoLuongKhoaHocDangKy;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.VarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = qdGiamGia.MaNgheNghiep;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = qdGiamGia.TenNgheNghiep;

                cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date);
                cmd.Parameters["@NgayBatDau"].Value = (object)qdGiamGia.NgayBatDau ?? DBNull.Value;

                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date);
                cmd.Parameters["@NgayKetThuc"].Value = (object)qdGiamGia.NgayKetThuc ?? DBNull.Value;

                cmd.Parameters.Add("@PhanTramGiamGiaMacDinh", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaMacDinh"].Value = qdGiamGia.PhanTramGiamGiaMacDinh;

                cmd.Parameters.Add("@PhanTramGiamGiaToiDa", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaToiDa"].Value = qdGiamGia.PhanTramGiamGiaToiDa;

                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = "STA1";

                cmd.Parameters.Add("@TaoBoiNV", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoiNV"].Value = "Nguyễn Phương Thanh";

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = "STA1";

                cmd.Parameters.Add("@TrangThaiQuyDinhGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiQuyDinhGiamGia"].Value = qdGiamGia.TrangThaiQuyDinhGiamGia;

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
        public string SuaQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE QuyDinhGiamGia "
                                                + "SET MoTaLoaiGiamGia = @MoTaLoaiGiamGia, SoLuongKhoaHocDangKy = @SoLuongKhoaHocDangKy, "
                                                + "MaNgheNghiep = @MaNgheNghiep, TenNgheNghiep = @TenNgheNghiep, "
                                                + "NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, "
                                                + "PhanTramGiamGiaMacDinh = @PhanTramGiamGiaMacDinh, PhanTramGiamGiaToiDa = @PhanTramGiamGiaToiDa, "
                                                + "ChinhSuaLanCuoiVaoLuc = @ChinhSuaLanCuoiVaoLuc, TrangThaiQuyDinhGiamGia = @TrangThaiQuyDinhGiamGia "
                                                + "WHERE MaQuyDinhGiamGia = @MaQuyDinhGiamGia", conn);

                cmd.Parameters.Add("@MaQuyDinhGiamGia", SqlDbType.VarChar);
                cmd.Parameters["@MaQuyDinhGiamGia"].Value = qdGiamGia.MaQuyDinhGiamGia;

                cmd.Parameters.Add("@MoTaLoaiGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@MoTaLoaiGiamGia"].Value = qdGiamGia.MoTaLoaiGiamGia;

                cmd.Parameters.Add("@SoLuongKhoaHocDangKy", SqlDbType.Int);
                cmd.Parameters["@SoLuongKhoaHocDangKy"].Value = qdGiamGia.SoLuongKhoaHocDangKy;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.VarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = qdGiamGia.MaNgheNghiep;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = qdGiamGia.TenNgheNghiep;

                cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date);
                cmd.Parameters["@NgayBatDau"].Value = (object)qdGiamGia.NgayBatDau ?? DBNull.Value;

                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date);
                cmd.Parameters["@NgayKetThuc"].Value = (object)qdGiamGia.NgayKetThuc ?? DBNull.Value;

                cmd.Parameters.Add("@PhanTramGiamGiaMacDinh", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaMacDinh"].Value = qdGiamGia.PhanTramGiamGiaMacDinh;

                cmd.Parameters.Add("@PhanTramGiamGiaToiDa", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaToiDa"].Value = qdGiamGia.PhanTramGiamGiaToiDa;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@TrangThaiQuyDinhGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiQuyDinhGiamGia"].Value = qdGiamGia.TrangThaiQuyDinhGiamGia;

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
        public string XoaQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE QuyDinhGiamGia "
                                                + "SET TrangThaiQuyDinhGiamGia = @TrangThaiQuyDinhGiamGia, "
                                                + "ChinhSuaLanCuoiVaoLuc = @ChinhSuaLanCuoiVaoLuc "
                                                + "WHERE MaQuyDinhGiamGia = @MaQuyDinhGiamGia", conn);

                cmd.Parameters.Add("@MaQuyDinhGiamGia", SqlDbType.VarChar);
                cmd.Parameters["@MaQuyDinhGiamGia"].Value = qdGiamGia.MaQuyDinhGiamGia;

                cmd.Parameters.Add("@TrangThaiQuyDinhGiamGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiQuyDinhGiamGia"].Value = qdGiamGia.TrangThaiQuyDinhGiamGia;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
                return "Fail";

            }
            catch (Exception ex)
                return "Exception";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
