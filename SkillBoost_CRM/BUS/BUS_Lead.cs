using DAL;
using DTO;
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
        public DataSet SelectNgheNghiep()
        public bool InsertYCTVcuaLeadNew(DTO_Lead tt_yctv)
        {
            return dAL_Lead.SelectNgheNghiep();
            
            return dAL_Lead.InsertYCTVcuaLeadNew(tt_yctv);
        }

        public void SelectLead(ref DTO_Lead dTO_Lead)
        public void InsertYCTVcuaLeadOld()
        {

            dAL_Lead.SelectLead(ref dTO_Lead);
        }

    }
}
