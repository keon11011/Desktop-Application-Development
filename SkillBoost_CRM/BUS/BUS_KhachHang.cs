using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dAL_KhachHang = new DAL_KhachHang();
        public DataTable SelectKhachHang(string maPIC, string ChucVu) 
        {
            return dAL_KhachHang.SelectKhachHang(maPIC, ChucVu);
        }
        public DataTable LocKhachHang(DTO_KhachHang dTO_KhachHang, string ChucVu, string MaPIC)
        {
            return dAL_KhachHang.LocKhachHang(dTO_KhachHang, ChucVu, MaPIC);
        }
        public DataTable TimKhachHang(string input_TuKhoa, string ChucVu, string MaPIC)
        {
            return dAL_KhachHang.TimKhachHang(input_TuKhoa.Trim(), ChucVu, MaPIC);
        }
    }
}
