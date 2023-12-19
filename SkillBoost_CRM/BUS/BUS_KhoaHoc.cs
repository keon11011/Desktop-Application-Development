using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_KhoaHoc
    {
        DAL_KhoaHoc dalKhoaHoc = new DAL_KhoaHoc();

        public DataTable SelectKhoaHoc()
        {
            return dalKhoaHoc.SelectKhoaHoc();
        }

        public DataTable TimKhoaHoc(string input_TuKhoa)
        {
            return dalKhoaHoc.TimKhoaHoc(input_TuKhoa);
        }

        public DataTable LocKhoaHoc(string GiangVien, string TrangThaiKhoaHoc)
        {
            return dalKhoaHoc.LocKhoaHoc(GiangVien, TrangThaiKhoaHoc);
        }
    }
}
