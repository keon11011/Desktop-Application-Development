using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKhoaHocThuocYCTV
    {
        private string _maTuVan;
        private string _maKhoaHoc;
        private string _tenKhoaHoc;
        private string _giangVien;
        private float _giaTien;

        public string MaTuVan { get => _maTuVan; set => _maTuVan = value; }
        public string MaKhoaHoc { get => _maKhoaHoc; set => _maKhoaHoc = value; }
        public string TenKhoaHoc { get => _tenKhoaHoc; set => _tenKhoaHoc = value; }
        public string GiangVien { get => _giangVien; set => _giangVien = value; }
        public float GiaTien { get => _giaTien; set => _giaTien = value; }
        public DTO_ChiTietKhoaHocThuocYCTV()
        {

        }
        public DTO_ChiTietKhoaHocThuocYCTV(string maTuVan, string maKhoaHoc, string tenKhoaHoc, string giangVien, float giaTien)
        {
            MaTuVan = maTuVan;
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            GiangVien = giangVien;
            GiaTien = giaTien;
        }
    }
}
