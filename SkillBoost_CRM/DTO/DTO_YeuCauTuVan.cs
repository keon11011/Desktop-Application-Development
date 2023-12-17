using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_YeuCauTuVan
    {
        private string _maTuVan;
        private string _tenLeadYeuCau;
        private DateTime _ngaySinhLeadYeuCau;
        private string _emailLeadYeuCau;
        private string _sDTLeadYeuCau;
        private string _ghiChuYCTV;
        private string _trangThaiYCTV;
        private DateTime _taoVaoLuc;
        private string _taoBoiLead;
        private string _maKhoaHoc;
        private string _tenKhoaHoc;
        private string _giangVien;
        private string _giaTien;


        public string MaTuVan { get => _maTuVan; set => _maTuVan = value; }
        public string TenLeadYeuCau { get => _tenLeadYeuCau; set => _tenLeadYeuCau = value; }
        public DateTime NgaySinhLeadYeuCau { get => _ngaySinhLeadYeuCau; set => _ngaySinhLeadYeuCau = value; }
        public string EmailLeadYeuCau { get => _emailLeadYeuCau; set => _emailLeadYeuCau = value; }
        public string SDTLeadYeuCau { get => _sDTLeadYeuCau; set => _sDTLeadYeuCau = value; }
        public string GhiChuYCTV { get => _ghiChuYCTV; set => _ghiChuYCTV = value; }
        public string TrangThaiYCTV { get => _trangThaiYCTV; set => _trangThaiYCTV = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoiLead { get => _taoBoiLead; set => _taoBoiLead = value; }
        public string MaKhoaHoc { get => _maKhoaHoc; set => _maKhoaHoc = value; }
        public string TenKhoaHoc { get => _tenKhoaHoc; set => _tenKhoaHoc = value; }
        public string GiangVien { get => _giangVien; set => _giangVien = value; }
        public string GiaTien { get => _giaTien; set => _giaTien = value; }


        public DTO_YeuCauTuVan()
        {

        }
        public DTO_YeuCauTuVan(string maTuVan, string tenLeadYeuCau, DateTime ngaySinhLeadYeuCau, string emailLeadYeuCau, string sDTLeadYeuCau, string ghiChuYCTV, string trangThaiYCTV, DateTime taoVaoLuc, string taoBoiLead, string maKhoaHoc, string tenKhoaHoc, string giangVien, string giaTien)
        {
            MaTuVan = maTuVan;
            TenLeadYeuCau = tenLeadYeuCau;
            NgaySinhLeadYeuCau = ngaySinhLeadYeuCau;
            EmailLeadYeuCau = emailLeadYeuCau;
            SDTLeadYeuCau = sDTLeadYeuCau;
            GhiChuYCTV = ghiChuYCTV;
            TrangThaiYCTV = trangThaiYCTV;
            TaoVaoLuc = taoVaoLuc;
            TaoBoiLead = taoBoiLead;
            MaTuVan = maTuVan;
            TenLeadYeuCau = tenLeadYeuCau;
            NgaySinhLeadYeuCau = ngaySinhLeadYeuCau;
            EmailLeadYeuCau = emailLeadYeuCau;
            SDTLeadYeuCau = sDTLeadYeuCau;
            GhiChuYCTV = ghiChuYCTV;
            TrangThaiYCTV = trangThaiYCTV;
            TaoVaoLuc = taoVaoLuc;
            TaoBoiLead = taoBoiLead;
            _maKhoaHoc = maKhoaHoc;
            _tenKhoaHoc = tenKhoaHoc;
            _giangVien = giangVien;
            _giaTien = giaTien;
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            GiangVien = giangVien;
            GiaTien = giaTien;
        }
    }
}
