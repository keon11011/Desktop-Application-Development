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
    public class DAL_TaiKhoan : DBConnect
    {
        public bool DangNhap(DTO_TaiKhoan dTO_TaiKhoan, ref string maPIC)
        {
            try
            {
                conn.Open();
                string cmdText = "SELECT * FROM TaiKhoan WHERE EmailTK = \'" + dTO_TaiKhoan.EmailTK + "\'";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                dTO_TaiKhoan.TrangThaiTK = dt.Rows[0][5].ToString();

                if (dt.Rows.Count == 0 || dTO_TaiKhoan.TrangThaiTK == "Dừng hoạt động")
                {
                    return false;
                }
                else
                {
                    cmdText = "SELECT HASHBYTES('SHA2_512', @MatKhauTK + CAST(@MaSaltTK AS NVARCHAR(36)))";

                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.Parameters.Add("@MatKhauTK", SqlDbType.VarChar);
                    cmd.Parameters["@MatKhauTK"].Value = dTO_TaiKhoan.MatKhauTK;

                    dTO_TaiKhoan.MaSaltTK = dt.Rows[0][4].ToString();

                    cmd.Parameters.Add("@MaSaltTK", SqlDbType.UniqueIdentifier);
                    cmd.Parameters["@MaSaltTK"].Value = dt.Rows[0][4];

                    dTO_TaiKhoan.MaHashTK = (byte[])cmd.ExecuteScalar();

                    var MaHashTK = dt.Rows[0][3];

                    if (dTO_TaiKhoan.MaHashTK.SequenceEqual((IEnumerable<byte>)MaHashTK))
                    {
                        return true;
                        maPIC = dt.Rows[0][6].ToString();
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
       
        //public DataTable SelectSanPham()
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", conn);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        da.Dispose();

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        //public bool InsertSanPham(SanPham sanPham)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO SANPHAM VALUES(@MaSP, @TenSP, @DvTinh, @DonGia, @MaLoai)", conn);
        //        AddParameter(cmd, sanPham);
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
        //public bool UpdatetSanPham(SanPham sanPham)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("UPDATE SANPHAM SET MaSP = @MaSP, TenSP = @TenSP, DvTinh = @DvTinh, DonGia = @DonGia, MaLoai = @MaLoai WHERE MaSP = @MaSP)", conn);
        //        AddParameter(cmd, sanPham);
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
