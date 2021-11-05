using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Models
{
    public delegate string Print(int value);

    public class PrinterHelper
    {
        public static string PrintMethode(Print printDel, int numToPrint)
        {
            return "Print ..." + printDel(numToPrint);
        }

        //public static string PrintMethode(Func<int, string> printDel, int numToPrint)
        //{
        //    return "Print ..." + printDel(numToPrint);
        //}
    }
}
