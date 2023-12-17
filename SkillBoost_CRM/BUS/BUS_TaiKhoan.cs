using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        //DAL_SanPham dalSanPham = new DAL_SanPham();
        //public DataTable SelectSanPham()
        //{
        //    return dalSanPham.SelectSanPham();
        //}

        //public bool InsertSanPham(SanPham sanPham)
        //{
        //    return dalSanPham.InsertSanPham(sanPham);
        //}
        //public bool UpdateSanPham(SanPham sanPham)
        //{
        //    return dalSanPham.UpdatetSanPham(sanPham);
        //}

        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        public bool DangNhap(DTO_TaiKhoan dTO_TaiKhoan, ref string maPIC)
        {
            return dal_TaiKhoan.DangNhap(dTO_TaiKhoan, ref maPIC);
        }
    }
}