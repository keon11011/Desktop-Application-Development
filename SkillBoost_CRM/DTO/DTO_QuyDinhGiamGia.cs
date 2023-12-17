using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuyDinhGiamGia
    {
        private string _maQuyDinhGiamGia;
        private string _moTaLoaiGiamGia;
        private int _soLuongKhoaHocDangKy;
        private string _maNgheNghiep;
        private string _tenNgheNghiep;
        private DateTime _ngayBatDau;
        private DateTime _ngayKetThuc;
        private int _phanTramGiamGiaMacDinh;
        private int _phanTramGiamGiaToiDa;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaQuyDinhGiamGia { get => _maQuyDinhGiamGia; set => _maQuyDinhGiamGia = value; }
        public string MoTaLoaiGiamGia { get => _moTaLoaiGiamGia; set => _moTaLoaiGiamGia = value; }
        public int SoLuongKhoaHocDangKy { get => _soLuongKhoaHocDangKy; set => _soLuongKhoaHocDangKy = value; }
        public string MaNgheNghiep { get => _maNgheNghiep; set => _maNgheNghiep = value; }
        public string TenNgheNghiep { get => _tenNgheNghiep; set => _tenNgheNghiep = value; }
        public DateTime NgayBatDau { get => _ngayBatDau; set => _ngayBatDau = value; }
        public DateTime NgayKetThuc { get => _ngayKetThuc; set => _ngayKetThuc = value; }
        public int PhanTramGiamGiaMacDinh { get => _phanTramGiamGiaMacDinh; set => _phanTramGiamGiaMacDinh = value; }
        public int PhanTramGiamGiaToiDa { get => _phanTramGiamGiaToiDa; set => _phanTramGiamGiaToiDa = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }

        public DTO_QuyDinhGiamGia()
        {

        }
        public DTO_QuyDinhGiamGia(string maQuyDinhGiamGia, string moTaLoaiGiamGia, int soLuongKhoaHocDangKy, string maNgheNghiep, string tenNgheNghiep, DateTime ngayBatDau, DateTime ngayKetThuc, int phanTramGiamGiaMacDinh, int phanTramGiamGiaToiDa, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaQuyDinhGiamGia = maQuyDinhGiamGia;
            MoTaLoaiGiamGia = moTaLoaiGiamGia;
            SoLuongKhoaHocDangKy = soLuongKhoaHocDangKy;
            MaNgheNghiep = maNgheNghiep;
            TenNgheNghiep = tenNgheNghiep;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            PhanTramGiamGiaMacDinh = phanTramGiamGiaMacDinh;
            PhanTramGiamGiaToiDa = phanTramGiamGiaToiDa;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
}
