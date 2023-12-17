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
        public DataTable SelectKhachHang(string maPIC)
        {
            try
            {
                conn.Open();
                string cmdText = "SELECT MaKH as N'Mã Khách hàng', HoTenKH as N'Họ tên', ChinhSuaLanCuoiVaoLuc as N'Thời gian cập nhật gần nhất' " +
                    "FROM KhachHang " +
                    "WHERE TrangThaiKH = N'Đang hoạt động' AND MaNVPhuTrachKH = \'" + maPIC + "\'";
                
                //SqlCommand cmd = new SqlCommand(cmdText, conn);
                //cmd.Parameters.Add("@MaPIC", SqlDbType.Char);
                //cmd.Parameters["@MaPIC"].Value = maPIC;
                
                SqlDataAdapter da = new SqlDataAdapter(cmdText,conn);
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
    }
}
