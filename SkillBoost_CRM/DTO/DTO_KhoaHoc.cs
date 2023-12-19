using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        private string _maKhoaHoc;
        private string _tenKhoaHoc;
        private string _moTaKhoaHoc;
        private string _thoiLuongKhoaHoc;
        private string _giangVien;
        private string _mucDoKhoaHoc;
        private Int32 _soLuongHocVienToiDa;
        private double _giaTien;
        private DateTime _ngayKhaiGiang;
        private DateTime _ngayBeGiang;
        private double _danhGiaKhoahoc;
        private string _trangThaiKhoaHoc;
        private string _maLoaiKhoaHoc;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaKhoaHoc { get => _maKhoaHoc; set => _maKhoaHoc = value; }
        public string TenKhoaHoc { get => _tenKhoaHoc; set => _tenKhoaHoc = value; }
        public string MoTaKhoaHoc { get => _moTaKhoaHoc; set => _moTaKhoaHoc = value; }
        public string ThoiLuongKhoaHoc { get => _thoiLuongKhoaHoc; set => _thoiLuongKhoaHoc = value; }
        public string GiangVien { get => _giangVien; set => _giangVien = value; }
        public string MucDoKhoaHoc { get => _mucDoKhoaHoc; set => _mucDoKhoaHoc = value; }
        public Int32 SoLuongHocVienToiDa { get => _soLuongHocVienToiDa; set => _soLuongHocVienToiDa = value; }
        public double GiaTien { get => _giaTien; set => _giaTien = value; }
        public DateTime NgayKhaiGiang { get => _ngayKhaiGiang; set => _ngayKhaiGiang = value; }
        public DateTime NgayBeGiang { get => _ngayBeGiang; set => _ngayBeGiang = value; }
        public double DanhGiaKhoahoc { get => _danhGiaKhoahoc; set => _danhGiaKhoahoc = value; }
        public string TrangThaiKhoaHoc { get => _trangThaiKhoaHoc; set => _trangThaiKhoaHoc = value; }
        public string MaLoaiKhoaHoc { get => _maLoaiKhoaHoc; set => _maLoaiKhoaHoc = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }

        public KhoaHoc()
        {

        }

        public KhoaHoc(string maKhoaHoc, string tenKhoaHoc, string motaKhoaHoc, string thoiLuongKhoaHoc, string giangVien, string mucDoKhoaHoc, Int32 soLuongHocVienToiDa, double giaTien, DateTime ngayKhaiGiang, DateTime ngayBeGiang, double danhGiaKhoaHoc, string trangThaiKhoaHoc, string maLoaiKhoaHoc, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            MoTaKhoaHoc = motaKhoaHoc;
            ThoiLuongKhoaHoc = thoiLuongKhoaHoc;
            GiangVien = giangVien;
            MucDoKhoaHoc = mucDoKhoaHoc;
            SoLuongHocVienToiDa = soLuongHocVienToiDa;
            GiaTien = giaTien;
            NgayKhaiGiang = ngayKhaiGiang;
            NgayBeGiang = ngayBeGiang;
            DanhGiaKhoahoc = danhGiaKhoaHoc;
            TrangThaiKhoaHoc = trangThaiKhoaHoc;
            MaLoaiKhoaHoc = maLoaiKhoaHoc;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
}

