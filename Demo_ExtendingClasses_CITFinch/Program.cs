using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace Demo_ExtendingClass_MyFinch
{
    class Program
    {
        static void Main(string[] args)
        {
            CITFinch myFinch = new CITFinch();

            Console.ReadKey();

            myFinch.disConnect();
        }
    }
}
