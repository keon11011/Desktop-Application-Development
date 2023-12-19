using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_YCTVKhachHang
    {
        DAL_YCTVKhachHang dAL_YCTVKhachHang = new DAL_YCTVKhachHang();
        public bool Insert_YCTVKhachHang (DTO_YCTVKhachHang s)
        {
            return dAL_YCTVKhachHang.InsertYCTVKhachHang(s);
        }
    }
}
