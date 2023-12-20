using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_YCTVKhachHang
    {
        private string _maTuVan;
        private string _tenLeadYeuCau;
        private DateTime _ngaySinhLeadYeuCau;
        private string _emailLeadYeuCau;
        private string _sdtLeadYeuCau;
        private string _ghiChuYCTV;
        private string _trangThaiYCTV;
        private DateTime _taoVaoLuc;
        private string _taoBoiLead;

        public string MaTuVan { get => _maTuVan; set => _maTuVan = value; }
        public string TenLeadYeuCau { get => _tenLeadYeuCau; set => _tenLeadYeuCau = value; }
        public DateTime NgaySinhLeadYeuCau { get => _ngaySinhLeadYeuCau; set => _ngaySinhLeadYeuCau = value; }
        public string EmailLeadYeuCau { get => _emailLeadYeuCau; set => _emailLeadYeuCau = value; }
        public string SdtLeadYeuCau { get => _sdtLeadYeuCau; set => _sdtLeadYeuCau = value; }
        public string GhiChuYCTV { get => _ghiChuYCTV; set => _ghiChuYCTV = value; }
        public string TrangThaiYCTV { get => _trangThaiYCTV; set => _trangThaiYCTV = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoiLead { get => _taoBoiLead; set => _taoBoiLead = value; }

        public DTO_YCTVKhachHang()
        {

        }
        public DTO_YCTVKhachHang(string maTuVan, string tenLeadYeuCau, DateTime ngaySinhYeuCau, string emailLeadYeuCau, string sdtLeadYeuCau, string ghiChuYCTV, string trangThaiYCTV, DateTime taoVaoLuc, string taoBoiLead)
        {
            MaTuVan = maTuVan;
            TenLeadYeuCau = tenLeadYeuCau;
            NgaySinhLeadYeuCau = ngaySinhYeuCau;
            EmailLeadYeuCau = emailLeadYeuCau;
            SdtLeadYeuCau = sdtLeadYeuCau;
            GhiChuYCTV = ghiChuYCTV;
            TrangThaiYCTV = trangThaiYCTV;
            TaoVaoLuc = taoVaoLuc;
            TaoBoiLead = taoBoiLead;


        }
    }
}
