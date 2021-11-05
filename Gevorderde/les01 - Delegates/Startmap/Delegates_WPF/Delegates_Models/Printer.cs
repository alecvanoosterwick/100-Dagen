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
            tekst.AppendLine("Winkel de bolle");
            tekst.AppendLine("Kruidenierszaak van samson");
            tekst.AppendLine("Geholpen door octaaf");
            tekst.AppendLine("");
            winkelkar.WinkelkarItems.ForEach(x => tekst.AppendLine(x.Aantal + "x" + x.Product +" "+ x.Subtotaal()));
            return "";
        }
        public string PrintMethod2(Winkelkar winkelkar)
        {
            return "";
        }

        
        public string TotaalAfdrukken(decimal totaal, decimal korting)
        {
            return "";

        }


      
    }
}
