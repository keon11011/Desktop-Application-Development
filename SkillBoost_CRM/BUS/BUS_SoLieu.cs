using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SoLieu
    {
        DAL_SoLieu dAL_SoLieu = new DAL_SoLieu();
        
        public bool TaoSoLieu(ref DTO_SoLieu solieu)
        {
            return dAL_SoLieu.TaoSoLieu(ref solieu);
        }
    }
}
