using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKhoaHocThuocBaoGia
    {
        private string _maBaoGia;
        private string _maKhoaHoc;
        private string _tenKhoaHoc;
        private string _giangVien;
        private float _giaTien;

        public string MaBaoGia { get => _maBaoGia; set => _maBaoGia = value; }
        public string MaKhoaHoc { get => _maKhoaHoc; set => _maKhoaHoc = value; }
        public string TenKhoaHoc { get => _tenKhoaHoc; set => _tenKhoaHoc = value; }
        public string GiangVien { get => _giangVien; set => _giangVien = value; }
        public float GiaTien { get => _giaTien; set => _giaTien = value; }
        public DTO_ChiTietKhoaHocThuocBaoGia()
        {

        }
        public DTO_ChiTietKhoaHocThuocBaoGia(string maBaoGia, string maKhoaHoc, string tenKhoaHoc, string giangVien, float giaTien)
        {
            MaBaoGia = maBaoGia;
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            GiangVien = giangVien;
            GiaTien = giaTien;
        }
    }
}
