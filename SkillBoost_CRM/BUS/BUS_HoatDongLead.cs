using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_HoatDongLead
    {
        DAL_HoatDongLead dalHoatDongLead = new DAL_HoatDongLead();
        public DataTable SelectHoatDongLead(string MaLead)
        {
            return dalHoatDongLead.SelectHoatDongLead(MaLead);
        }
        public bool ThemHoatDongLead(HoatDongLead hoatDongLead)
        {
            return dalHoatDongLead.ThemHoatDongLead(hoatDongLead);
        }

        public DataTable TimHoatDongLead(string input_TuKhoa)
        {
            return dalHoatDongLead.TimHoatDongLead(input_TuKhoa);
        }

        public DataTable LocHoatDongLead(string MaLead, string loaiHDLead, string HDLeadDuocTaoBoi)
        {
            return dalHoatDongLead.LocHoatDongLead(MaLead, loaiHDLead, HDLeadDuocTaoBoi);
        }
    }
}
