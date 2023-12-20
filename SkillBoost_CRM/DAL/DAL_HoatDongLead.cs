using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Data;
using System.Data.Common;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_HoatDongLead : DBConnect
    {
        public DataTable SelectHoatDongLead(string MaLead)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from HoatDongLead WHERE MaLead = @MaLead ORDER BY STT DESC", conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = MaLead;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

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

        public bool ThemHoatDongLead(HoatDongLead hoatDongLead)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HOATDONGLEAD VALUES(@MaLead, @TenHDLead, @LoaiHDLead,@HDLeadDuocTaoBoi, @MaNVPhuTrachHDLead, @TenNVPhuTrachHDLead, @MaEmailDenLead, @TaoVaoLuc)", conn);

                cmd.Parameters.Add("@MaLead", SqlDbType.VarChar);
                cmd.Parameters["@MaLead"].Value = hoatDongLead.MaLead;

                cmd.Parameters.Add("@TenHDLead", SqlDbType.NVarChar);
                cmd.Parameters["@TenHDLead"].Value = hoatDongLead.TenHDLead;

                cmd.Parameters.Add("@LoaiHDLead", SqlDbType.NVarChar);
                cmd.Parameters["@LoaiHDLead"].Value = hoatDongLead.LoaiHDLead;

                cmd.Parameters.Add("@HDLeadDuocTaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@HDLeadDuocTaoBoi"].Value = hoatDongLead.HDLeadDuocTaoBoi;

                cmd.Parameters.Add("@MaNVPhuTrachHDLead", SqlDbType.VarChar);
                cmd.Parameters["@MaNVPhuTrachHDLead"].Value = hoatDongLead.MaNVPhuTrachHDLead;

                cmd.Parameters.Add("@TenNVPhuTrachHDLead", SqlDbType.NVarChar);
                cmd.Parameters["@TenNVPhuTrachHDLead"].Value = hoatDongLead.TenNVPhuTrachHDLead;

                cmd.Parameters.AddWithValue("@MaEmailDenLead", string.IsNullOrEmpty(hoatDongLead.MaEmailDenLead) ? (object)DBNull.Value : hoatDongLead.MaEmailDenLead);

                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = DateTime.Now;

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

        public DataTable TimHoatDongLead(string input_TuKhoa)
        {
            try
            {
                conn.Open();

                string sql = "";
                if (input_TuKhoa != "")
                {
                    sql = "SELECT * FROM HoatDongLead Where TenHDLead like N'%" + input_TuKhoa + "%' AND MaLead = 'LEA1' ORDER BY STT DESC";
                }
                else
                {
                    sql = "SELECT * FROM HoatDongLead ORDER BY STT DESC";
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

        public DataTable LocHoatDongLead(string MaLead, string loaiHDLead, string HDLeadDuocTaoBoi)
        {
            try
            {
                string sqlCommand = $@"Select * from HoatDongLead Where
                                                (MaLead = '{MaLead}') AND
                                                (LoaiHDLead = {(!string.IsNullOrEmpty(loaiHDLead) ? $"N'{loaiHDLead}'" : "LoaiHDLead")}) AND
                                                (HDLeadDuocTaoBoi = {(!string.IsNullOrEmpty(HDLeadDuocTaoBoi) ? $"N'{HDLeadDuocTaoBoi}'" : "HDLeadDuocTaoBoi")})
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
