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
    public class BUS_QuyDinhGiamGia
    {
        DAL_QuyDinhGiamGia dalQuyDinhGiamGia = new DAL_QuyDinhGiamGia();
        DAL_NgheNghiep dalNgheNghiep = new DAL_NgheNghiep();
        public DataTable SelectQuyDinhGiamGia()
        {
            return dalQuyDinhGiamGia.SelectQuyDinhGiamGia();
        }
        public DataTable SelectNgheNghiep()
        {
            return dalNgheNghiep.SelectNgheNghiep();
        }
        public string ThemQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia, string MaPIC, string tenPIC)
        {   
            return dalQuyDinhGiamGia.ThemQuyDinhGiamGia(qdGiamGia, MaPIC, tenPIC);
        }
        public string SuaQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia, string MaPIC)
        {
            return dalQuyDinhGiamGia.SuaQuyDinhGiamGia(qdGiamGia, MaPIC);
        }
        public string XoaQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia, string MaPIC)
        {
            return dalQuyDinhGiamGia.XoaQuyDinhGiamGia(qdGiamGia, MaPIC);
        }
        public bool SelectQuyDinhGiamGiaAfterClick(ref DTO_QuyDinhGiamGia dTO_QuyDinhGiamGia)
        {
            return dalQuyDinhGiamGia.SelectQuyDinhGiamGiaAfterClick(ref dTO_QuyDinhGiamGia);
        }
        
    }
}
