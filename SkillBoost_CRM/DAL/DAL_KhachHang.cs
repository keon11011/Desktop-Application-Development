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
    public class DAL_KhachHang : DBConnect
    {
        public bool ThemKhachHang(DTO_KhachHang dTO_KhachHang)
        {
            try
            {
                conn.Open();
                string cmdText = "INSERT INTO KhachHang (HoTenKH, GioiTinhKH, NgaySinhKH, SoDienThoaiKH, EmailKH, MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachKH, TenNVPhuTrachKH, TrangThaiKH, LyDoTrangThaiKH, GhiChuKH, ChuyenDoiTuMaLead, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi) " +
                    "VALUES (@HoTenKH, @GioiTinhKH,@NgaySinhKH, @SoDienThoaiKH, @EmailKH, @MaNgheNghiep, @TenNgheNghiep, @MaNVPhuTrachKH, @TenNVPhuTrachKH, @TrangThaiKH, @LyDoTrangThaiKH, @GhiChuKH, @ChuyenDoiTuMaLead, GETDATE(), N'Hệ thống', GETDATE(), N'Hệ thống')";
                SqlCommand cmd = new SqlCommand(cmdText,conn);

                cmd.Parameters.Add("@HoTenKH", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenKH"].Value = dTO_KhachHang.HoTenKH;

                cmd.Parameters.Add("@GioiTinhKH", SqlDbType.NVarChar);
                cmd.Parameters["@GioiTinhKH"].Value = DBNull.Value;

                cmd.Parameters.Add("@NgaySinhKH", SqlDbType.Date);
                cmd.Parameters["@NgaySinhKH"].Value = DBNull.Value;

                cmd.Parameters.Add("@SoDienThoaiKH", SqlDbType.Char);
                cmd.Parameters["@SoDienThoaiKH"].Value = dTO_KhachHang.SoDienThoaiKH;

                cmd.Parameters.Add("@EmailKH", SqlDbType.VarChar);
                cmd.Parameters["@EmailKH"].Value = dTO_KhachHang.EmailKH;

                cmd.Parameters.Add("@MaNgheNghiep", SqlDbType.VarChar);
                cmd.Parameters["@MaNgheNghiep"].Value = DBNull.Value;

                cmd.Parameters.Add("@TenNgheNghiep", SqlDbType.NVarChar);
                cmd.Parameters["@TenNgheNghiep"].Value = DBNull.Value;

                cmd.Parameters.Add("@MaNVPhuTrachKH", SqlDbType.VarChar);
                cmd.Parameters["@MaNVPhuTrachKH"].Value = dTO_KhachHang.MaNVPhuTrachKH;

                cmd.Parameters.Add("@TenNVPhuTrachKH", SqlDbType.VarChar);
                cmd.Parameters["@TenNVPhuTrachKH"].Value = dTO_KhachHang.TenNVPhuTrachKH;

                cmd.Parameters.Add("@TrangThaiKH", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiKH"].Value = "Đang hoạt động";

                cmd.Parameters.Add("@LyDoTrangThaiKH", SqlDbType.NVarChar);
                cmd.Parameters["@LyDoTrangThaiKH"].Value = "Tạo từ Lead đã thanh toán";

                cmd.Parameters.Add("@GhiChuKH", SqlDbType.NVarChar);
                cmd.Parameters["@GhiChuKH"].Value = DBNull.Value;

                cmd.Parameters.Add("@ChuyenDoiTuMaLead", SqlDbType.VarChar);
                cmd.Parameters["@ChuyenDoiTuMaLead"].Value = dTO_KhachHang.ChuyenDoiTuMaLeadKH;


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    cmd.Dispose();
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
        public DataTable SelectKhachHang(string maPIC, string ChucVu)
        {
            try
            {
                conn.Open();
                string cmdText;
                if (ChucVu == "Nhân viên")
                {
                    cmdText = "SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', " +
                        "SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', " +
                        "TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái', " +
                        "LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' , " +
                        "TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', " +
                        "ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' FROM KhachHang WHERE TrangThaiKH NOT LIKE N'Xóa mềm' " +
                        "AND MaNVPhuTrachKH = \'" + maPIC + "\'";                
                }
                else
                {
                    cmdText = "SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', " +
                        "SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', " +
                        "TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái', " +
                        "LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' , " +
                        "TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', " +
                        "ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' FROM KhachHang WHERE TrangThaiKH NOT LIKE N'Xóa mềm' ";
                }
                                
                SqlDataAdapter da = new SqlDataAdapter(cmdText,conn);
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
        public DataTable LocKhachHang(DTO_KhachHang dTO_KhachHang, string ChucVu, string MaPIC)
        {
            try
            {
                string cmdText;
                if (ChucVu == "Quản lý")
                {
                    cmdText = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                                SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                                TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái', 
                                LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                                TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                                ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi'
                                from KhachHang Where
                                TrangThaiKH NOT LIKE N'Xóa mềm' AND
                                (GioiTinhKH = {(!string.IsNullOrEmpty(dTO_KhachHang.GioiTinhKH) ? $"N'{dTO_KhachHang.GioiTinhKH}'" : "GioiTinhKH")}) AND
                                (TrangThaiKH = {(!string.IsNullOrEmpty(dTO_KhachHang.TrangThaiKH) ? $"N'{dTO_KhachHang.TrangThaiKH}'" : "TrangThaiKH")})
                                ORDER BY STT DESC";
                }
                else
                {
                    cmdText = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                                SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                                TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái',
                                LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                                TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                                ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' from KhachHang Where
                                TrangThaiKH NOT LIKE N'Xóa mềm' AND
                                (GioiTinhKH = {(!string.IsNullOrEmpty(dTO_KhachHang.GioiTinhKH) ? $"N'{dTO_KhachHang.GioiTinhKH}'" : "GioiTinhKH")}) AND
                                (TrangThaiKH = {(!string.IsNullOrEmpty(dTO_KhachHang.TrangThaiKH) ? $"N'{dTO_KhachHang.TrangThaiKH}'" : "TrangThaiKH")}) AND
                                MaNVPhuTrachKH = '{MaPIC}'
                                ORDER BY STT DESC";
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable TimKhachHang(string input_TuKhoa, string ChucVu, string MaPIC)
        {
            try
            {
                conn.Open();

                string sql = "";
                if (ChucVu == "Nhân viên" ) 
                {
                    if (input_TuKhoa == "")
                    {
                        sql = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                            SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                            TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái',
                            LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                            TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                            ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' from KhachHang Where
                            TrangThaiKH NOT LIKE N'Xóa mềm' AND MaNVPhuTrachKH = '{MaPIC}'
                            ORDER BY STT DESC";
                    }
                    else
                    {
                        sql = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                                SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                                TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái',
                                LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                                TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                                ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' from KhachHang Where
                                TrangThaiKH NOT LIKE N'Xóa mềm' AND MaNVPhuTrachKH = '{MaPIC}' AND
                                HoTenKH like N'%" + input_TuKhoa + "%' ORDER BY STT DESC";
                    }
                }
                else
                {
                    if (input_TuKhoa != "")
                    {
                        sql = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                                SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                                TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái',
                                LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                                TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                                ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' from KhachHang Where
                                TrangThaiKH NOT LIKE N'Xóa mềm' AND
                                HoTenKH like N'%" + input_TuKhoa + "%' ORDER BY STT DESC";
                    }
                    else
                    {
                        sql = $@"SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', 
                                SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', 
                                TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái',
                                LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' ,
                                TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', 
                                ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' from KhachHang Where
                                TrangThaiKH NOT LIKE N'Xóa mềm'
                                ORDER BY STT DESC";
                    }
                }
               

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                return dt;

            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
