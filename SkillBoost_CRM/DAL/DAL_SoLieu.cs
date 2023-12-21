using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SoLieu : DBConnect
    {
        public bool TaoSoLieu(ref DTO_SoLieu solieu)
        {
            try
            {
                conn.Open();
                DAL_SoLieu dAL_SoLieu = new DAL_SoLieu();
                double result;

                SqlCommand cmdGetSoLuongLead = new SqlCommand("Select count (*) as SoLuongLead from Lead where TaoVaoLuc between @NgayBatDau and @NgayKetThuc", conn);
                cmdGetSoLuongLead.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdGetSoLuongLead.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                solieu.SoLuongLead = int.Parse(cmdGetSoLuongLead.ExecuteScalar().ToString());
                cmdGetSoLuongLead.Dispose();


                SqlCommand cmdGetSoLuongKhachHang = new SqlCommand("Select count (*) from KhachHang as SoLuongKhachHang where TaoVaoLuc between @NgayBatDau and @NgayKetThuc", conn);
                cmdGetSoLuongKhachHang.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdGetSoLuongKhachHang.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                solieu.SoLuongKhachHang = int.Parse(cmdGetSoLuongKhachHang.ExecuteScalar().ToString());
                cmdGetSoLuongKhachHang.Dispose();

                SqlCommand cmdGetSoLuongKhoaHoc = new SqlCommand("Select count (*) from HoaDon as SoLuongKhoaHoc where TaoVaoLuc between @NgayBatDau and @NgayKetThuc", conn);
                cmdGetSoLuongKhoaHoc.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdGetSoLuongKhoaHoc.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                solieu.SoLuongKhoaHocBanRa = int.Parse(cmdGetSoLuongKhoaHoc.ExecuteScalar().ToString());
                cmdGetSoLuongKhoaHoc.Dispose();

                SqlCommand cmdGetDoanhThu = new SqlCommand("Select sum (TongHoaDon) from HoaDon where TaoVaoLuc between @NgayBatDau and @NgayKetThuc", conn);
                cmdGetDoanhThu.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdGetDoanhThu.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                if (double.TryParse(cmdGetDoanhThu.ExecuteScalar().ToString(), out result))
                {
                    solieu.DoanhThu = double.Parse(cmdGetDoanhThu.ExecuteScalar().ToString());
                }
                else solieu.DoanhThu = 0;
                cmdGetDoanhThu.Dispose();

                SqlCommand cmdGetTiLeChuyenDoi = new SqlCommand("select (select cast(count(*) as float) from KhachHang where KhachHang.TaoVaoLuc between @NgayBatDau and @NgayKetThuc)/(select cast(count(*) as float) from Lead) as result", conn);
                cmdGetTiLeChuyenDoi.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdGetTiLeChuyenDoi.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                solieu.TiLeChuyenDoi = double.Parse(cmdGetTiLeChuyenDoi.ExecuteScalar().ToString());
                cmdGetTiLeChuyenDoi.Dispose();

                SqlCommand cmdKhoaHocBanChay = new SqlCommand("SELECT TOP 1 KhoaHoc.TenKhoaHoc, COUNT(*) AS SoLuongBan FROM ChiTietKhoaHocThuocHoaDon INNER JOIN KhoaHoc ON KhoaHoc.MaKhoaHoc = ChiTietKhoaHocThuocHoaDon.MaKhoaHoc WHERE KhoaHoc.TaoVaoLuc between @NgayBatDau and @NgayKetThuc GROUP BY KhoaHoc.TenKhoaHoc ORDER BY SoLuongBan DESC", conn);
                cmdKhoaHocBanChay.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdKhoaHocBanChay.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                SqlDataReader reader = cmdKhoaHocBanChay.ExecuteReader();
                if (reader.HasRows)
                {
                    solieu.KhoaHocBanChay = cmdKhoaHocBanChay.ExecuteScalar().ToString();
                }
                else solieu.KhoaHocBanChay = "_";
                cmdKhoaHocBanChay.Dispose();
                reader.Close();

                SqlCommand cmdMaGiamGiaNhieu = new SqlCommand("SELECT top 1 MaGiamGia.MoTaMaGiamGia, COUNT(ChiTietDoiTuongUuDai.DaApDung) AS SoLanApDung FROM ChiTietDoiTuongUuDai JOIN MaGiamGia ON ChiTietDoiTuongUuDai.MaGiamGia = MaGiamGia.MaGiamGia WHERE (ChiTietDoiTuongUuDai.DaApDung = N'Có') and (MaGiamGia.TaoVaoLuc between @NgayBatDau and @NgayKetThuc) GROUP BY MaGiamGia.MoTaMaGiamGia ORDER BY SoLanApDung DESC", conn);
                cmdMaGiamGiaNhieu.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdMaGiamGiaNhieu.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                SqlDataReader reader1 = cmdMaGiamGiaNhieu.ExecuteReader();
                if (reader1.HasRows)
                {
                    solieu.MaGiamGiaNhieu = cmdMaGiamGiaNhieu.ExecuteScalar().ToString();
                }
                else solieu.MaGiamGiaNhieu = "_";
                cmdMaGiamGiaNhieu.Dispose();
                reader1.Close();

                SqlCommand cmdNhanVienTuVanNhieu = new SqlCommand("SELECT top 1 NhanVien.HoTenNV, COUNT(*) AS SoLuongTuVan FROM Lead JOIN NhanVien ON NhanVien.MaNV = Lead.MaNVPhuTrachLead where NhanVien.TaoVaoLuc between @NgayBatDau and @NgayKetThuc GROUP BY Lead.MaNVPhuTrachLead,NhanVien.HoTenNV ORDER BY SoLuongTuVan DESC", conn);
                cmdNhanVienTuVanNhieu.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = solieu.NgayBatDau;
                cmdNhanVienTuVanNhieu.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = solieu.NgayKetThuc;
                SqlDataReader reader2 = cmdNhanVienTuVanNhieu.ExecuteReader();
                if (reader2.HasRows)
                {
                    solieu.NhanVienTuVanNhieu = cmdNhanVienTuVanNhieu.ExecuteScalar().ToString();
                }
                else solieu.NhanVienTuVanNhieu = "_";
                cmdNhanVienTuVanNhieu.Dispose();
                reader2.Close();

                return true;
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
