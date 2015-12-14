using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace Demo_ExtendingClass_MyFinch
{
    public class CITFinch : Finch
    {



        public CITFinch()
        {
            base.connect();
            base.setLED(255, 0, 0);
        }
    }
}
