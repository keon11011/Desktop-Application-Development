﻿using System;
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
        {
            return dAL_Lead.SelectNgheNghiep();
        }

        public void SelectLead(ref DTO_Lead dTO_Lead)
        {

            dAL_Lead.SelectLead(ref dTO_Lead);
        }

    }
}
