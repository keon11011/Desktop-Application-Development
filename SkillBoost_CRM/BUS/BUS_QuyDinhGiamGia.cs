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
        public string ThemQuyDinhGiamGia(DTO_QuyDinhGiamGia qdGiamGia)
        {   
            return dalQuyDinhGiamGia.ThemQuyDinhGiamGia(qdGiamGia);
        }
    }
}
