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
        public bool InsertYCTVcuaLeadNew(DTO_Lead tt_yctv)
        public DataSet SelectNgheNghiep()
        {
            
            return dAL_Lead.InsertYCTVcuaLeadNew(tt_yctv);
            return dAL_Lead.SelectNgheNghiep();
        }

        public void InsertYCTVcuaLeadOld()
        public void SelectLead(ref DTO_Lead dTO_Lead)
        {

            dAL_Lead.SelectLead(ref dTO_Lead);
        }
        public bool InsertHDLead(DTO_Lead lead)
        {
            return dAL_Lead.InsertHDLead(lead);
        }


    }
}
