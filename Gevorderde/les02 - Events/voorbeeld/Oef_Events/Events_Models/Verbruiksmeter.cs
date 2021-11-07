using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Models
{
    
   public delegate void VerbruikHandler(int stand);
    public class Verbruiksmeter
    {

        //public event Action<int> TeHoogVerbruikEvent;

        
        public event VerbruikHandler TeHoogVerbruikEvent;

        public int Meterstand { get; set; }

        public void AddVerbruik(int verbruik)
        {
            Meterstand += verbruik;
            if (verbruik > 50)
            {
                TeHoogVerbruikEvent?.Invoke(verbruik);

                //OF
                //if (TeHoogVerbruikEvent != null)
                //{
                //    TeHoogVerbruikEvent.Invoke(verbruik);
                //}
            }

        }
    }
}
