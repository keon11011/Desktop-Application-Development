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
        public DataTable SelectKhachHang(string maPIC) 
        {
            return dAL_KhachHang.SelectKhachHang(maPIC);
        }
    }
}
