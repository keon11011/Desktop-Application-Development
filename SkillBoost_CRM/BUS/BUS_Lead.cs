using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Lead
    {
        DAL_Lead dAL_Lead = new DAL_Lead(); 
        public bool InsertYCTVcuaLeadNew(DTO_Lead tt_yctv)
        {
            
            return dAL_Lead.InsertYCTVcuaLeadNew(tt_yctv);
        }

        public void InsertYCTVcuaLeadOld()
        {

        }

    }
}
