using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoatDongLead
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
        public string HDLeadDuocTaoBoi { get => _hdLeadDuocTaoBoi; set => _hdLeadDuocTaoBoi = value; }
        public string MaNVPhuTrachHDLead { get => _maNVPhuTrachHDLead; set => _maNVPhuTrachHDLead = value; }
        public string TenNVPhuTrachHDLead { get => _tenNVPhuTrachHDLead; set => _tenNVPhuTrachHDLead = value; }
        public string MaEmailDenLead { get => _maEmailDenLead; set => _maEmailDenLead = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }

        public HoatDongLead()
        {

        }

        public HoatDongLead(string hoatDongLead, string maLead, string tenHDLead, string loaiHDLead, string hdLeadDuocTaoBoi, string maNVPhuTrachHDLead, string tenNVPhuTrachHDLead, string maEmailDenLead, DateTime taoVaoLuc)
        {
            MaHDLead = hoatDongLead;
            MaLead = maLead;
            TenHDLead = tenHDLead;
            LoaiHDLead = loaiHDLead;
            HDLeadDuocTaoBoi = hdLeadDuocTaoBoi;
            MaNVPhuTrachHDLead = maNVPhuTrachHDLead;
            TenNVPhuTrachHDLead = tenNVPhuTrachHDLead;
            MaEmailDenLead = maEmailDenLead;
            TaoVaoLuc = taoVaoLuc;
        }
    }
}
