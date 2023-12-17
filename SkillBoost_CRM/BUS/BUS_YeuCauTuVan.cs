using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_YeuCauTuVan
    {
        DAL_YeuCauTuVan dAL_YeuCauTuVan = new DAL_YeuCauTuVan();

        public DataTable SelectYCTV()
        {
            return dAL_YeuCauTuVan.SelectYCTV();
        }
        public DataTable SelecKhoaHoc()
        {
            return dAL_YeuCauTuVan.SelectKhoaHoc();
        }
        public DataTable TimYCTV(string tenYCTV)
        {
            return dAL_YeuCauTuVan.TimYCTV(tenYCTV);
        }
        public DataTable LocYCTV(string trangthailocYCTV)
        {
            return dAL_YeuCauTuVan.LocYCTV(trangthailocYCTV);
        }

        public bool InsertLeadcuaYCTV(DTO_YeuCauTuVan tt_yctv)
        {
            return dAL_YeuCauTuVan.InsertLeadcuaYCTV(tt_yctv);
        }
        public bool InsertChiTietKhoaHoc(DTO_YeuCauTuVan khoahoc_yctv)
        {
            return dAL_YeuCauTuVan.InsertChiTietKhoaHoc(khoahoc_yctv);
        }
    }

}
