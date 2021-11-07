using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Models
{
    public class WinkelkarExtended : Winkelkar
    {
        public KortingHandler KortingMethod { get; set; }
        public PrintHandler PrintMethod { get; set; }
        public string DrukAf()
        {
            return PrintMethod.Invoke(this);

        }
        public decimal Korting()
        {
            decimal som = Totaal();
            decimal korting = KortingMethod.Invoke(som);
            return korting;

        }
    }
}
