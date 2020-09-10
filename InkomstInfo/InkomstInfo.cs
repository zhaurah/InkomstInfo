using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkomstInfo
{
    class InkomstInfo
    {
        public string Namn;
        public int Inkomst;
        public int Timmar;
        public string ShowInkomstInfo()
        {
            return Namn + " med inkomst: "+Inkomst;  
        }

        public string GetNamn()
        {
            return Namn;
        }

    }

}
