using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Lead
    {
        DAL_Lead dAL_Lead = new DAL_Lead();
        DAL_KhoaHoc dAL_KhoaHoc = new DAL_KhoaHoc();
        DTO_KhoaHoc dTO_KhoaHoc = new DTO_KhoaHoc();
        
        public bool LayThongTinKhoaHocChonThem(ref DTO_KhoaHoc dTO_KhoaHoc)
        {
            return dAL_KhoaHoc.LayThongTinKhoaHocChonThem(ref dTO_KhoaHoc);
        }
        public string SuaThongTinLead(DTO_Lead dTO_Lead)            // Chỉnh sửa thông tin Lead
        {
            return dAL_Lead.SuaThongTinLead(dTO_Lead);
        }
        public string HuyTheoDoiTuVan(DTO_Lead dTO_Lead)            // Ngừng theo dõi Lead
        {
            return dAL_Lead.HuyTheoDoiTuVan(dTO_Lead);
        }
        public string XoaMemLead(DTO_Lead dTO_Lead)                      // Xóa mềm Lead
        {
            return dAL_Lead.XoaMemLead(dTO_Lead);
        }
        public DataSet DanhSachKhoaHoc(DTO_Lead dTO_Lead)           // Danh sách khóa học quan tâm 
        {
            return dAL_Lead.DanhSachKhoaHoc(dTO_Lead);
        }
        public DataSet SelectNgheNghiep()                           // Chọn nghề nghiệp
        {
            return dAL_Lead.SelectNgheNghiep();
        }
        public DataSet SelectKhoaHoc()                              // Chọn khóa học    
        {
            return dAL_Lead.SelectKhoaHoc();
        }
        public void SelectLead(ref DTO_Lead dTO_Lead)                 // Hiển thị thông tin Lead 
        {

            dAL_Lead.SelectLead(ref dTO_Lead);
        }

    }
}
