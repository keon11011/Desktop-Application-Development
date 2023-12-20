using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class DTO_SoLieu
    {
        
        private DateTime _ngayBatDau;
        private DateTime _ngayKetThuc;
        private int _soLuongLead;
        private int _soLuongKhachHang;
        private int _soLuongKhoaHocBanRa;
        private double _doanhThu;
        private double _tiLeChuyenDoi;
        private string _khoaHocBanChay;
        private string _maGiamGiaNhieu;
        private string _nhanVienTuVanNhieu;
        

        public DateTime NgayBatDau { get => _ngayBatDau; set => _ngayBatDau = value; }
        public DateTime NgayKetThuc { get => _ngayKetThuc; set => _ngayKetThuc = value; }
        public int SoLuongLead { get => _soLuongLead; set => _soLuongLead = value; }
        public int SoLuongKhachHang { get => _soLuongKhachHang; set => _soLuongKhachHang = value; }
        public int SoLuongKhoaHocBanRa { get => _soLuongKhoaHocBanRa; set => _soLuongKhoaHocBanRa = value; }
        public double DoanhThu { get => _doanhThu; set => _doanhThu = value; }
        public double TiLeChuyenDoi { get => _tiLeChuyenDoi; set => _tiLeChuyenDoi = value; }
        public string KhoaHocBanChay { get => _khoaHocBanChay; set => _khoaHocBanChay = value; }
        public string MaGiamGiaNhieu { get => _maGiamGiaNhieu; set => _maGiamGiaNhieu = value; }
        public string NhanVienTuVanNhieu { get => _nhanVienTuVanNhieu; set => _nhanVienTuVanNhieu = value; }

        public DTO_SoLieu()
        {

        }
        public DTO_SoLieu(DateTime ngayBatDau, DateTime ngayKetThuc, int soLuongLead, int soLuongKhachHang, int soLuongKhoaHocBanRa, double doanhthu, double tilechuyendoi, string khoahocbanchay, string magiamgianhieu, string nhanvientuvannhieu)
        {
            
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLuongLead = soLuongLead;
            SoLuongKhachHang = soLuongKhachHang;
            SoLuongKhoaHocBanRa = soLuongKhoaHocBanRa;
            DoanhThu = doanhthu;
            TiLeChuyenDoi = tilechuyendoi;
            KhoaHocBanChay = khoahocbanchay;
            MaGiamGiaNhieu = magiamgianhieu;
            NhanVienTuVanNhieu = nhanvientuvannhieu;
            
        }
       
    }
    

}
