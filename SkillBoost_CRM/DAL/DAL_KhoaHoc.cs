using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using DTO;
using System.Data.Common;

namespace DAL
{
    public class DAL_KhoaHoc : DBConnect
    {
        public DataTable SelectKhoaHoc()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from KhoaHoc ORDER BY STT DESC", conn);
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
        public bool LayThongTinKhoaHocChonThem(ref DTO_KhoaHoc dTO_KhoaHoc)
        {
            try
            {
                conn.Open();
                string cmdText = "select * from KhoaHoc where MaKhoaHoc = @MaKhoaHoc";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar);
                cmd.Parameters["@MaKhoaHoc"].Value = dTO_KhoaHoc.MaKhoaHoc;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                cmd.Dispose();

                dTO_KhoaHoc.TenKhoaHoc = dt.Rows[0][1].ToString();
                dTO_KhoaHoc.MoTaKhoaHoc = dt.Rows[0][2].ToString();
                dTO_KhoaHoc.ThoiLuongKhoaHoc = dt.Rows[0][3].ToString();
                dTO_KhoaHoc.GiangVien = dt.Rows[0][4].ToString();
                dTO_KhoaHoc.MucDoKhoaHoc = dt.Rows[0][5].ToString();
                dTO_KhoaHoc.SoLuongHocVienToiDa = (int)dt.Rows[0][6];
                dTO_KhoaHoc.GiaTien = (double)dt.Rows[0][7];
                dTO_KhoaHoc.NgayKhaiGiang = (DateTime)dt.Rows[0][8];

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable TimKhoaHoc(string input_TuKhoa)
        {
            try
            {
                conn.Open();

                string sql = "";
                if (input_TuKhoa != "")
                {
                    sql = "SELECT * FROM KhoaHoc Where TenKhoaHoc like N'%" + input_TuKhoa + "%' ORDER BY STT DESC";
                }
                else
                {
                    sql = "SELECT * FROM KhoaHoc ORDER BY STT DESC";
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
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

        public DataTable LocKhoaHoc(string GiangVien, string TrangThaiKhoaHoc)
        {
            try
            {
                string sqlCommand = $@"Select * from KhoaHoc Where 
                                                (GiangVien = {(!string.IsNullOrEmpty(GiangVien) ? $"N'{GiangVien}'" : "GiangVien")}) AND
                                                (TrangThaiKhoaHoc = {(!string.IsNullOrEmpty(TrangThaiKhoaHoc) ? $"N'{TrangThaiKhoaHoc}'" : "TrangThaiKhoaHoc")})
                                                ORDER BY STT DESC";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand, conn);
                da.Fill(dt);
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
