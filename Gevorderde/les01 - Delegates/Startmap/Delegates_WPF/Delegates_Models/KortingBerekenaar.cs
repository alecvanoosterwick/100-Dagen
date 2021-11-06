using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Models
{
    public class KortingBerekenaar
    {
        public decimal Korting1(decimal bedrag)
        {
            decimal korting = 0 ;
            decimal resultaat;
            if (bedrag > 250)
            {
                return 15m;
            }
            else if (bedrag > 100 || bedrag <= 250)
            {
                return 10m;
            }
            else if (bedrag > 50 || bedrag <= 100)
            {
                return 0.95m;
            }
            else
            {
                return 0;
            }

        }

        public decimal Korting2(decimal bedrag)
        {
            if (bedrag > 50)
            {
                return 0.1m * bedrag;
            }
            else
            {
                return 0;
            }
        }
    }
}
