using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThanhToan
    {
        private string _maBaoGia;
        private string _tenBaoGia;
        private string _maLead;
        private string _hoTenLead;
        private double _tongTienTruocGiam;
        private string _maGiamGia;
        private int _phanTramGiamGia;
        private string _tongTien;
        private string _trangThaiBaoGia;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaBaoGia { get => _maBaoGia; set => _maBaoGia = value; }
        public string TenBaoGia { get => _tenBaoGia; set => _tenBaoGia = value; }
        public string MaLead { get => _maLead; set => _maLead = value; }
        public string HoTenLead { get => _hoTenLead; set => _hoTenLead = value; }
        public double TongTienTruocGiam { get => _tongTienTruocGiam; set => _tongTienTruocGiam = value; }
        public string MaGiamGia { get => _maGiamGia; set => _maGiamGia = value; }
        public int PhanTramGiamGia { get => _phanTramGiamGia; set => _phanTramGiamGia = value; }
        public string TongTien { get => _tongTien; set => _tongTien = value; }
        public string TrangThaiBaoGia { get => _trangThaiBaoGia; set => _trangThaiBaoGia = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }

        public DTO_ThanhToan()
        {

        }
        public DTO_ThanhToan(string maBaoGia, string tenBaoGia, string maLead, string hoTenLead, double tongTienTruocGiam, string maGiamGia, int phanTramGiamGia, string tongTien, string trangThaiBaoGia, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaBaoGia = maBaoGia;
            TenBaoGia = tenBaoGia;
            MaLead = maLead;
            HoTenLead = hoTenLead;
            TongTienTruocGiam = tongTienTruocGiam;
            MaGiamGia = maGiamGia;
            PhanTramGiamGia = phanTramGiamGia;
            TongTien = tongTien;
            TrangThaiBaoGia = trangThaiBaoGia;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
    public class DTO_ThanhToan1
    {
        private string maLead;
        private string hoTenLead;
        private string gioiTinhLead;
        private DateTime ngaySinhLead;
        private string soDienThoaiLead;
        private string emailLead;
        private string maNgheNghiep;
        private string tenNgheNghiep;
        private string maNVPhuTrachLead;
        private string tenNVPhuTrachLead;
        private string trangThaiLead;
        private string lyDoTrangThaiLead;
        private string nguonLead;
        private string ghiChuLead;
        private string leadTuKHCu;
        private DateTime taoVaoLuc;
        private string taoBoi;
        private DateTime chinhSuaLanCuoiVaoLuc;
        private string chinhSuaLanCuoiBoi;

        public string MaLead { get => maLead; set => maLead = value; }
        public string HoTenLead { get => hoTenLead; set => hoTenLead = value; }
        public string GioiTinhLead { get => gioiTinhLead; set => gioiTinhLead = value; }
        public DateTime NgaySinhLead { get => ngaySinhLead; set => ngaySinhLead = value; }
        public string SoDienThoaiLead { get => soDienThoaiLead; set => soDienThoaiLead = value; }
        public string EmailLead { get => emailLead; set => emailLead = value; }
        public string MaNgheNghiep { get => maNgheNghiep; set => maNgheNghiep = value; }
        public string TenNgheNghiep { get => tenNgheNghiep; set => tenNgheNghiep = value; }
        public string MaNVPhuTrachLead { get => maNVPhuTrachLead; set => maNVPhuTrachLead = value; }
        public string TenNVPhuTrachLead { get => tenNVPhuTrachLead; set => tenNVPhuTrachLead = value; }
        public string TrangThaiLead { get => trangThaiLead; set => trangThaiLead = value; }
        public string LyDoTrangThaiLead { get => lyDoTrangThaiLead; set => lyDoTrangThaiLead = value; }
        public string NguonLead { get => nguonLead; set => nguonLead = value; }
        public string GhiChuLead { get => ghiChuLead; set => ghiChuLead = value; }
        public string LeadTuKHCu { get => leadTuKHCu; set => leadTuKHCu = value; }
        public DateTime TaoVaoLuc { get => taoVaoLuc; set => taoVaoLuc = value; }
        public string TaoBoi { get => taoBoi; set => taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => chinhSuaLanCuoiVaoLuc; set => chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => chinhSuaLanCuoiBoi; set => chinhSuaLanCuoiBoi = value; }

        public DTO_ThanhToan1()
        {

        }
        public DTO_ThanhToan1(string maLead, string hoTenLead, string gioiTinhLead, DateTime ngaySinhLead, string soDienThoaiLead, string emailLead, string maNgheNghiep, string tenNgheNghiep, string maNVPhuTrachLead, string tenNVPhuTrachLead, string trangThaiLead, string lyDoTrangThaiLead, string nguonLead, string ghiChuLead, string leadTuKHCu, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaLead = maLead;
            HoTenLead = hoTenLead;
            GioiTinhLead = gioiTinhLead;
            NgaySinhLead = ngaySinhLead;
            SoDienThoaiLead = soDienThoaiLead;
            EmailLead = emailLead;
            MaNgheNghiep = maNgheNghiep;
            TenNgheNghiep = tenNgheNghiep;
            MaNVPhuTrachLead = maNVPhuTrachLead;
            TenNVPhuTrachLead = tenNVPhuTrachLead;
            TrangThaiLead = trangThaiLead;
            LyDoTrangThaiLead = lyDoTrangThaiLead;
            NguonLead = nguonLead;
            GhiChuLead = ghiChuLead;
            LeadTuKHCu = leadTuKHCu;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }


    }
    public class DTO_ThanhToan2
    {
        private string _maHDLead;
        private string _maLead;
        private string _tenHDLead;
        private string _loaiHDLead;
        private string _hdLeadDuocTaoBoi;
        private string _maNVPhuTrachHDLead;
        private string _tenNVPhuTrachHDLead;
        private string _maEmailDenLead;
        private DateTime _taoVaoLuc;

        public string MaHDLead { get => _maHDLead; set => _maHDLead = value; }
        public string MaLead { get => _maLead; set => _maLead = value; }
        public string TenHDLead { get => _tenHDLead; set => _tenHDLead = value; }
        public string LoaiHDLead { get => _loaiHDLead; set => _loaiHDLead = value; }
        public string HdLeadDuocTaoBoi { get => _hdLeadDuocTaoBoi; set => _hdLeadDuocTaoBoi = value; }
        public string MaNVPhuTrachHDLead { get => _maNVPhuTrachHDLead; set => _maNVPhuTrachHDLead = value; }
        public string TenNVPhuTrachHDLead { get => _tenNVPhuTrachHDLead; set => _tenNVPhuTrachHDLead = value; }
        public string MaEmailDenLead { get => _maEmailDenLead; set => _maEmailDenLead = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }

        public DTO_ThanhToan2()
        {

        }
        public DTO_ThanhToan2(string maHDLead, string maLead, string tenHDLead, string loaiHDLead, string hdLeadDuocTaoBoi, string maNVPhuTrachHDLead, string tenNVPhuTrachHDLead, string maEmailDenLead, DateTime taoVaoLuc)
        {
            MaHDLead = maHDLead;
            MaLead = maLead;
            TenHDLead = tenHDLead;
            LoaiHDLead = loaiHDLead;
            HdLeadDuocTaoBoi = hdLeadDuocTaoBoi;
            MaNVPhuTrachHDLead = maNVPhuTrachHDLead;
            TenNVPhuTrachHDLead = tenNVPhuTrachHDLead;
            MaEmailDenLead = maEmailDenLead;
            TaoVaoLuc = taoVaoLuc;
        }
    }


}
