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

                dTO_TaiKhoan.TrangThaiTK = dt.Rows[0][6].ToString();

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

                    dTO_TaiKhoan.MaSaltTK = dt.Rows[0][5].ToString();

                    cmd.Parameters.Add("@MaSaltTK", SqlDbType.UniqueIdentifier);
                    cmd.Parameters["@MaSaltTK"].Value = dt.Rows[0][5];

                    //cmd.Parameters.Add("@GuidParameter", SqlDbType.UniqueIdentifier).Value = new System.Data.SqlTypes.SqlGuid(dt.Rows[0][4]); //The value of @ID


                    dTO_TaiKhoan.MaHashTK = (byte[])cmd.ExecuteScalar();

                    var MaHashTK = dt.Rows[0][4];

                    if (dTO_TaiKhoan.MaHashTK.SequenceEqual((byte[])MaHashTK))
                    {
                        maPIC = dt.Rows[0][7].ToString();
                        return true;
                    }
                    else
                    {
                        return false;

                    }
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
        public bool TimChucVu(ref string chucVu, string maPIC)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ChucVu FROM NhanVien WHERE MaNV = @MaPIC", conn);
                cmd.Parameters.Add("@MaPIC", SqlDbType.VarChar);
                cmd.Parameters["@MaPIC"].Value = maPIC;
                chucVu = (string)cmd.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally 
            { 
                conn.Close(); 
            }   
        }
       
    }
}
