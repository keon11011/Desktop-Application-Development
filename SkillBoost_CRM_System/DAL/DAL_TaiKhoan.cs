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
        private void AddParameter(SqlCommand cmd, SanPham sanPham)
        {
            cmd.Parameters.Add("@MaSP", SqlDbType.VarChar);
            cmd.Parameters["@MaSP"].Value = sanPham.MaSP;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar);
            cmd.Parameters["@TenSP"].Value = sanPham.TenSP;
            cmd.Parameters.Add("@DvTinh", SqlDbType.NVarChar);
            cmd.Parameters["@DvTinh"].Value = sanPham.DvTinh;
            cmd.Parameters.Add("@DonGia", SqlDbType.Int);
            cmd.Parameters["@DonGia"].Value = sanPham.DonGia;
            cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar);
            cmd.Parameters["@MaLoai"].Value = sanPham.MaLoai;
        }
        public DataTable SelectSanPham()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", conn);
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
        public bool InsertSanPham(SanPham sanPham)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SANPHAM VALUES(@MaSP, @TenSP, @DvTinh, @DonGia, @MaLoai)", conn);
                AddParameter(cmd, sanPham);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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
        public bool UpdatetSanPham(SanPham sanPham)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SANPHAM SET MaSP = @MaSP, TenSP = @TenSP, DvTinh = @DvTinh, DonGia = @DonGia, MaLoai = @MaLoai WHERE MaSP = @MaSP)", conn);
                AddParameter(cmd, sanPham);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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
    }
}
