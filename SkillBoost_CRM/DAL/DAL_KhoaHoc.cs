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
