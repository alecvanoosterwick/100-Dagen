using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teller_Models
{
    public class Teller
    {

        private int _waarde;


        public int Waarde
        {
            get
            {
                return this._waarde;
            }
            private set
            {
                this._waarde = value;
            }
        }

        public Teller()
        {
        }


        public void Resetten()
        {
            Waarde = 0;
        }

        public string ToonGegevens()
        {
            string resultaat = "De waarde van teller is " + Waarde.ToString();
            return resultaat;
        }

        public void Verhoog()
        {
            Waarde += 1;
        }

        public void Verlagen()
        {
            Waarde -= 1;
        }
    }
}
