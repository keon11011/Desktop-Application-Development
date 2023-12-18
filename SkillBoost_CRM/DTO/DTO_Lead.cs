using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lead
    {
        private string _maLead;
        private string _hoTenLead;
        private string _gioiTinhLead;
        private DateTime _ngaySinhLead;
        private string _soDienThoaiLead;
        private string _emailLead;
        private string _maNgheNghiep;
        private string _tenNgheNghiep;
        private string _maNVPhuTrachLead;
        private string _tenNVPhuTrachLead;
        private string _trangThaiLead;
        private string _lyDoTrangThaiLead;
        private string _nguonLead;
        private string _ghiChuLead;
        private string _leadTuKhachHangCu;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaLead { get => _maLead; set => _maLead = value; }
        public string HoTenLead { get => _hoTenLead; set => _hoTenLead = value; }
        public string GioiTinhLead { get => _gioiTinhLead; set => _gioiTinhLead = value; }
        public DateTime NgaySinhLead { get => _ngaySinhLead; set => _ngaySinhLead = value; }
        public string SoDienThoaiLead { get => _soDienThoaiLead; set => _soDienThoaiLead = value; }
        public string EmailLead { get => _emailLead; set => _emailLead = value; }
        public string MaNgheNghiep { get => _maNgheNghiep; set => _maNgheNghiep = value; }
        public string TenNgheNghiep { get => _tenNgheNghiep; set => _tenNgheNghiep = value; }
        public string MaNVPhuTrachLead { get => _maNVPhuTrachLead; set => _maNVPhuTrachLead = value; }
        public string TenNVPhuTrachLead { get => _tenNVPhuTrachLead; set => _tenNVPhuTrachLead = value; }
        public string TrangThaiLead { get => _trangThaiLead; set => _trangThaiLead = value; }
        public string LyDoTrangThaiLead { get => _lyDoTrangThaiLead; set => _lyDoTrangThaiLead = value; }
        public string NguonLead { get => _nguonLead; set => _nguonLead = value; }
        public string GhiChuLead { get => _ghiChuLead; set => _ghiChuLead = value; }
        public string LeadTuKhachHangCu { get => _leadTuKhachHangCu; set => _leadTuKhachHangCu = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }


        public DTO_Lead()
        {

        }
        public DTO_Lead( string maLead, string hoTenLead, string gioiTinhLead, DateTime ngaySinhLead, string soDienThoaiLead, string emailLead, string maNgheNghiep, string tenNgheNghiep, string maNVPhuTrachLead, string tenNVPhuTrachLead, string trangThaiLead, string lyDoTrangThaiLead, string nguonLead, string ghiChuLead, string leadTuKhachHangCu, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
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
            LeadTuKhachHangCu = leadTuKhachHangCu;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
            
    }

}
