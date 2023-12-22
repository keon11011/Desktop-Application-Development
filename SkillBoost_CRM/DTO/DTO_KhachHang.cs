using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string _maKH;
        private string _hoTenKH;
        private string _gioiTinhKH;
        private DateTime? _ngaySinhKH;
        private string _soDienThoaiKH;
        private string _emailKH;
        private string _maNgheNghiep;
        private string _tenNgheNghiep;
        private string _maNVPhuTrachKH;
        private string _tenNVPhuTrachKH;
        private string _trangThaiKH;
        private string _lyDoTrangThaiKH;
        private string _ghiChuKH;
        private string _chuyenDoiTuMaLeadKH;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string HoTenKH { get => _hoTenKH; set => _hoTenKH = value; }
        public string GioiTinhKH { get => _gioiTinhKH; set => _gioiTinhKH = value; }
        public DateTime? NgaySinhKH { get => _ngaySinhKH; set => _ngaySinhKH = value; }
        public string SoDienThoaiKH { get => _soDienThoaiKH; set => _soDienThoaiKH = value; }
        public string EmailKH { get => _emailKH; set => _emailKH = value; }
        public string MaNgheNghiep { get => _maNgheNghiep; set => _maNgheNghiep = value; }
        public string TenNgheNghiep { get => _tenNgheNghiep; set => _tenNgheNghiep = value; }
        public string MaNVPhuTrachKH { get => _maNVPhuTrachKH; set => _maNVPhuTrachKH = value; }
        public string TrangThaiKH { get => _trangThaiKH; set => _trangThaiKH = value; }
        public string LyDoTrangThaiKH { get => _lyDoTrangThaiKH; set => _lyDoTrangThaiKH = value; }
        public string GhiChuKH { get => _ghiChuKH; set => _ghiChuKH = value; }
        public string ChuyenDoiTuMaLeadKH { get => _chuyenDoiTuMaLeadKH; set => _chuyenDoiTuMaLeadKH = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }
        public string TenNVPhuTrachKH { get => _tenNVPhuTrachKH; set => _tenNVPhuTrachKH = value; }

        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string maKH, string hoTenKH, string gioiTinhKH, DateTime? ngaySinhKH, string soDienThoaiKH, string emailKH, string maNgheNghiep, string tenNgheNghiep, string maNVPhuTrachKH, string tenNVPhuTrachKH, string trangThaiKH, string lyDoTrangThaiKH, string ghiChuKH, string chuyenDoiTuMaLeadKH, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaKH = maKH;
            HoTenKH = hoTenKH;
            GioiTinhKH = gioiTinhKH;
            NgaySinhKH = ngaySinhKH;
            SoDienThoaiKH = soDienThoaiKH;
            EmailKH = emailKH;
            MaNgheNghiep = maNgheNghiep;
            TenNgheNghiep = tenNgheNghiep;
            MaNVPhuTrachKH = maNVPhuTrachKH;
            TenNVPhuTrachKH = tenNVPhuTrachKH;
            TrangThaiKH = trangThaiKH;
            LyDoTrangThaiKH = lyDoTrangThaiKH;
            GhiChuKH = ghiChuKH;
            ChuyenDoiTuMaLeadKH = chuyenDoiTuMaLeadKH;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
}
