using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DAL
{
    public class DAL_ThanhToan:DBConnect
    {
        public bool InsertThanhToan(DTO_ThanhToan tt)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert into BaoGia (MaBaoGia,TenBaoGia, MaLead, HoTenLead, TongTienTruocGiam, MaGiamGia,  PhanTramGiamGia, TongTien, TrangThaiBaoGia, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc,  ChinhSuaLanCuoiBoi) " +
                                                    "values (@MaBaoGia,@TenBaoGia,@MaLead, @HoTenLead, @TongTienTruocGiam, @MaGiamGia , @ PhanTramGiamGia, @TongTien, @TrangThaiBaoGia, @TaoVaoLuc,@TaoBoi, @ ChinhSuaLanCuoiVaoLuc, @ ChinhSuaLanCuoiBoi)", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@MaBaoGia"].Value = tt.MaBaoGia;

                cmd.Parameters.Add("@TenBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TenBaoGia"].Value = tt.TenBaoGia;

                cmd.Parameters.Add("@MaLead", SqlDbType.NVarChar);
                cmd.Parameters["@MaLead"].Value = tt.MaLead;

                cmd.Parameters.Add("@HoTenLead", SqlDbType.NVarChar);
                cmd.Parameters["@HoTenLead"].Value = tt.HoTenLead;

                cmd.Parameters.Add("@TongTienTruocGiam", SqlDbType.Float);
                cmd.Parameters["@TongTienTruocGiam"].Value = tt.TongTienTruocGiam;

                cmd.Parameters.Add("@MaGiamGia", SqlDbType.DateTime);
                cmd.Parameters["@MaGiamGia"].Value = tt.MaGiamGia;

                cmd.Parameters.Add("@PhanTramGiamGia", SqlDbType.Int);
                cmd.Parameters["@PhanTramGiamGia"].Value = tt.PhanTramGiamGia;

                cmd.Parameters.Add("@TongTien", SqlDbType.Float);
                cmd.Parameters["@TongTien"].Value = tt.TongTien;

                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = tt.TrangThaiBaoGia;

                cmd.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@TaoVaoLuc"].Value = tt.TaoVaoLuc;

                cmd.Parameters.Add("@TaoBoi", SqlDbType.NVarChar);
                cmd.Parameters["@TaoBoi"].Value = tt.TaoBoi;

                cmd.Parameters.Add("@ChinhSuaLanCuoiVaoLuc", SqlDbType.DateTime);
                cmd.Parameters["@ChinhSuaLanCuoiVaoLuc"].Value = tt.ChinhSuaLanCuoiVaoLuc;

                cmd.Parameters.Add("@ChinhSuaLanCuoiBoi", SqlDbType.NVarChar);
                cmd.Parameters["@ChinhSuaLanCuoiBoi"].Value = tt.ChinhSuaLanCuoiBoi;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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
        public bool UpdateThanhToan(DTO_ThanhToan tt)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update BaoGia set TrangThaiBaoGia = @TrangThaiBaoGia where MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = tt.MaBaoGia;
                cmd.Parameters.Add("@TrangThaiBaoGia", SqlDbType.NVarChar);
                cmd.Parameters["@TrangThaiBaoGia"].Value = tt.TrangThaiBaoGia;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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
        public bool UpdateTrangThaiLead( DTO_ThanhToan tt)
        {

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update Lead set TrangThaiLead = N'Đã thanh toán' from Lead join BaoGia on Lead.MaLead = BaoGia.MaLead where MaBaoGia = @MaBaoGia", conn);

                cmd.Parameters.Add("@MaBaoGia", SqlDbType.VarChar);
                cmd.Parameters["@MaBaoGia"].Value = tt.MaBaoGia;
              
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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
        public bool TimThongTinThanhToan(ref DTO_ThanhToan tt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select MaGiamGia, TongTien,MaLead from BaoGia where MaBaoGia = @MaBaoGia", conn);
                cmd.Parameters.AddWithValue("@MaBaoGia", tt.MaBaoGia);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tt.MaGiamGia = reader["MaGiamGia"].ToString();
                    tt.TongTien = reader["TongTien"].ToString();
                    tt.MaLead = reader["MaLead"].ToString() ;

                    return true;
                }
                else
                {
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
        
        
    }
}
