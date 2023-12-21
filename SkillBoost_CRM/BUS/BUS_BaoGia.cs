using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_BaoGia
    {
        DAL_BaoGia dalBaoGia = new DAL_BaoGia();
        DAL_QuyDinhGiamGia dalqdGiamGia = new DAL_QuyDinhGiamGia();
        public DataTable SelectBaoGiaCuaLead(DTO_BaoGia baoGiaLead)
        {
            return dalBaoGia.SelectBaoGiaCuaLead(baoGiaLead);
        }
        public DataTable SelectAllKhoaHoc()
        {
            return dalBaoGia.SelectAllKhoaHoc();
        }
        public DataTable Select1KhoaHoc(DTO_KhoaHoc khoaHoc)
        {
            return dalBaoGia.Select1KhoaHoc(khoaHoc);
        }
        public DataTable SortQDGiamGia(DataTable dt_qdGiamGia)
        {
            dt_qdGiamGia = dalqdGiamGia.SelectQuyDinhGiamGia();
            dt_qdGiamGia.DefaultView.Sort = "PhanTramGiamGiaToiDa DESC, PhanTramGiamGiaMacDinh DESC";
            dt_qdGiamGia = dt_qdGiamGia.DefaultView.ToTable();

            return dt_qdGiamGia;
        }
        public DataTable SelectNgheNghiepCuaLead(DTO_Lead lead)
        {
            return dalBaoGia.SelectNgheNghiepCuaLead(lead);
        }
        public string TaoMaGiamGia(DTO_MaGiamGia maGiamGia)
        {
            return dalBaoGia.TaoMaGiamGia(maGiamGia);
        }
        public DataTable SelectMaGiamGiaMoiTao()
        {
            return dalBaoGia.SelectMaGiamGiaMoiTao();
        }
        public string TaoBaoGia(DTO_BaoGia baoGia)
        {
            return dalBaoGia.TaoBaoGia(baoGia);
        }
        public DataTable SelectBaoGiaMoiTao()
        {
            return dalBaoGia.SelectBaoGiaMoiTao();
        }
        public string ThemChiTietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            return dalBaoGia.ThemChiTietKhoaHocThuocBaoGia(khThuocBaoGia);
        }
        public string XoaBaoGia(DTO_BaoGia baoGia)
        {
            return dalBaoGia.XoaBaoGia(baoGia);
        }
        public DataTable SelectChiTietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            return dalBaoGia.SelectChiTietKhoaHocThuocBaoGia(khThuocBaoGia);
        }
        public DataTable SelectBaoGiaCuThe(DTO_BaoGia baoGia)
        {
            return dalBaoGia.SelectBaoGiaCuThe(baoGia);
        }
        public string SuaBaoGia(DTO_BaoGia baoGia)
        {
            return dalBaoGia.SuaBaoGia(baoGia);
        }
        public string SuaTrangThaiBaoGia(DTO_BaoGia baoGia)
        {
            return dalBaoGia.SuaTrangThaiBaoGia(baoGia);
        }
        public string XoaChiTietKhoaHocThuocBaoGia(DTO_ChiTietKhoaHocThuocBaoGia khThuocBaoGia)
        {
            return dalBaoGia.XoaChiThietKhoaHocThuocBaoGia(khThuocBaoGia);
        }

    }
}
