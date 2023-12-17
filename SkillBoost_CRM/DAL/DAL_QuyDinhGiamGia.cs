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
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaQuyDinhGiamGia, MoTaLoaiGiamGia, PhanTramGiamGiaMacDinh, PhanTramGiamGiaToiDa, TaoVaoLuc, TaoBoiNV FROM QuyDinhGiamGia", conn);
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
                                                "VALUES (@MaQuyDinhGiamGia, @MoTaLoaiGiamGia, @SoLuongKhoaHocDangKy, @MaNgheNghiep, @TenNgheNghiep, @NgayBatDau, @NgayKetThuc, @PhanTramGiamGiaMacDinh, @PhanTramGiamGiaToiDa, @TaoVaoLuc, @TaoBoi, @ChinhSuaLanCuoiVaoLuc, @ChinhSuaLanCuoiBoi, @TaoBoiNV)", conn);
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

                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime);
                cmd.Parameters["@NgayBatDau"].Value = qdGiamGia.NgayBatDau;

                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime);
                cmd.Parameters["@NgayKetThuc"].Value = qdGiamGia.NgayKetThuc;

                cmd.Parameters.Add("@PhanTramGiamGiaMacDinh", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaMacDinh"].Value = qdGiamGia.PhanTramGiamGiaMacDinh;

                cmd.Parameters.Add("@PhanTramGiamGiaToiDa", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGiaToiDa"].Value = qdGiamGia.PhanTramGiamGiaToiDa;

                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = "STA000";

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = DateTime.Now;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = "STA000";

                cmd.Parameters.Add("@TaoBoiNV", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoiNV"].Value = "Nguyễn Phương Thanh";

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return "Success";
                }
                return "Fail";
            }
            catch(Exception)
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
