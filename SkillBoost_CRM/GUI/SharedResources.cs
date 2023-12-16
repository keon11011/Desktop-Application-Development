using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SharedResources
    {
        private static string _maPIC;
        public SharedResources() 
        {
            
        }

        public static string MaPIC { get => _maPIC; set => _maPIC = value; }
    }
}
