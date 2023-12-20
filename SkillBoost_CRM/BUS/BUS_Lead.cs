using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class BUS_Lead
    {
        DAL_Lead dAL_Lead = new DAL_Lead(); 
        public bool InsertLead(DTO_Lead tt_yctv)
        {
            return dAL_Lead.InsertLead(tt_yctv);
        }
        public DataSet SelectNgheNghiep()
        {
            return dAL_Lead.SelectNgheNghiep();
        }

        public void SelectLead(ref DTO_Lead dTO_Lead)
        {
            dAL_Lead.SelectLead(ref dTO_Lead);
        }
       
        public string LayMaPIC(string MaLead)
        {
            return dAL_Lead.LayMaPIC(MaLead);
        }

        public string LayTenPIC(string MaLead)
        {
            return dAL_Lead.LayTenPIC(MaLead);
        }
        public string SuaThongTinLead(DTO_Lead dTO_Lead)            // Chỉnh sửa thông tin Lead
        {
            return dAL_Lead.SuaThongTinLead(dTO_Lead);
        }
        public string HuyTheoDoiTuVan(DTO_Lead dTO_Lead)            // Ngừng theo dõi Lead
        {
            return dAL_Lead.HuyTheoDoiTuVan(dTO_Lead);
        }
        public DataSet DanhSachKhoaHoc(DTO_Lead dTO_Lead)           // Danh sách khóa học quan tâm 
        {
            return dAL_Lead.DanhSachKhoaHoc(dTO_Lead);
        }
        public DataSet SelectKhoaHoc()                              // Chọn khóa học    
        {
            return dAL_Lead.SelectKhoaHoc();
        }
    }
}
