using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Models
{
    public class Printer
    {
        public string PrintMethod1(Winkelkar winkelkar)
        {
            StringBuilder tekst = new StringBuilder();
            tekst.AppendLine("Winkel de Bolle");
            tekst.AppendLine("Kruidenierszaak van Samson");
            tekst.AppendLine("Geholpen door octaaf");
            tekst.AppendLine("");
            winkelkar.WinkelkarItems.ForEach(x => tekst.AppendLine($"{x.Aantal}x{x.Product} {x.Subtotaal()}"));


            return tekst.ToString();

        }
        public string PrintMethod2(Winkelkar winkelkar)
        {
            StringBuilder tekst = new StringBuilder();
            winkelkar.WinkelkarItems.ForEach(x => tekst.AppendLine($"{x.Aantal} {x.Product.Prijs} {x.Subtotaal()}"));


            return tekst.ToString();
        }

        
        public string TotaalAfdrukken(decimal totaal, decimal korting)
        {
            return "";

        }


      
    }
}
