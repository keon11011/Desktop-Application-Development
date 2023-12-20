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
                        "ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' FROM KhachHang WHERE TrangThaiKH = N'Đang hoạt động' " +
                        "AND MaNVPhuTrachKH = \'" + maPIC + "\'";                
                }
                else
                {
                    cmdText = "SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', GioiTinhKH as N'Giới tính', " +
                        "SoDienThoaiKH as N'Số điện thoại', EmailKH as 'Email', TenNgheNghiep as N'Nghề nghiệp', " +
                        "TenNVPhuTrachKH as N'Nhân viên phụ trách', TrangThaiKH as N'Trạng thái', " +
                        "LyDoTrangThaiKH as N'Lý do trạng thái', GhiChuKH as N'Ghi chú', ChuyenDoiTuMaLead As N'Chuyển từ Lead' , " +
                        "TaoVaoLuc as 'Tạo lúc', TaoBoi as N'Tạo bởi' ,  ChinhSuaLanCuoiVaoLuc as N'Chỉnh sửa lần cuối lúc', " +
                        "ChinhSuaLanCuoiBoi as N'Chỉnh sửa lần cuối bởi' FROM KhachHang WHERE TrangThaiKH = N'Đang hoạt động' ";
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
    }
}
