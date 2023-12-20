using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThanhToan
    {
        DAL_ThanhToan dAL_ThanhToan = new DAL_ThanhToan();
        
        public bool Insert_ThanhToan(DTO_ThanhToan s)
        {
            return dAL_ThanhToan.InsertThanhToan(s);

        }
        public bool UpdateThanhToan(DTO_ThanhToan s)
        {
            return dAL_ThanhToan.UpdateThanhToan(s);
        }
        public bool UpdateTrangThaiLead( DTO_ThanhToan s)
        {
            return dAL_ThanhToan.UpdateTrangThaiLead(s);
        }
        public bool TimThongTinThanhToan(ref DTO_ThanhToan s)
        {
            return dAL_ThanhToan.TimThongTinThanhToan(ref s);
        }
    }
}
