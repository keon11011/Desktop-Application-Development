using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_YCTVKhachHang:DBConnect
    {
        //public bool InsertSanPham(DTOSanPham sp)
        //{
        //    try
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("Insert into SanPham(MaSP, TenSP, MaLoai) values (@MaSP, @TenSP, @MaLoai)", conn);

        //        cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar);
        //        cmd.Parameters["@MaSP"].Value = sp.MaSP;
        //        cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar);
        //        cmd.Parameters["@TenSP"].Value = sp.TenSP;
        //        cmd.Parameters.Add("@MaLoai", SqlDbType.NVarChar);
        //        cmd.Parameters["@MaLoai"].Value = sp.MaLoai;

        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}
