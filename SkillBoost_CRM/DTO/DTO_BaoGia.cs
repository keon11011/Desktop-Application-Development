using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoGia
    {
        private string _maBaoGia;
        private string _tenBaoGia;
        private string _maLead;
        private string _hoTenLead;
        private float _tongTienTruocGiam;
        private string _maGiamGia;
        private int? _phanTramGiamGia;
        private float _tongTien;
        private string _trangThaiBaoGia;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaBaoGia { get => _maBaoGia; set => _maBaoGia = value; }
        public string TenBaoGia { get => _tenBaoGia; set => _tenBaoGia = value; }
        public string MaLead { get => _maLead; set => _maLead = value; }
        public string HoTenLead { get => _hoTenLead; set => _hoTenLead = value; }
        public float TongTienTruocGiam { get => _tongTienTruocGiam; set => _tongTienTruocGiam = value; }
        public string MaGiamGia { get => _maGiamGia; set => _maGiamGia = value; }
        public int? PhanTramGiamGia { get => _phanTramGiamGia; set => _phanTramGiamGia = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
        public string TrangThaiBaoGia { get => _trangThaiBaoGia; set => _trangThaiBaoGia = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }
        public DTO_BaoGia()
        {

        }
        public DTO_BaoGia(string maBaoGia, string tenBaoGia, string maLead, string hoTenLead, float tongTienTruocGiam, string maGiamGia, int? phanTramGiamGia, float tongTien, string trangThaiBaoGia, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
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
}
