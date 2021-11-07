using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuig
{
    public class Voertuig
    {
        public delegate void AutoHandler(Voertuig sender);
        public event AutoHandler TankOpEvent;
        public event AutoHandler TankBijnaOpEvent;
        public event AutoHandler TankChangeEvent;
        public event AutoHandler AutoGestartEvent;
        public event AutoHandler AutoGestoptEvent;

        private double _LitersInTank { get; set; }
        private int _Snelheid { get; set; }

        public double LitersInTank
        { 
            get { return _LitersInTank; }
            set
            {
                TankChangeEvent?.Invoke(this);
                if (value <= 10 && value > 0)
                {
                    TankBijnaOpEvent?.Invoke(this);
                }
                if (value <= 0)
                {
                    TankOpEvent?.Invoke(this);
                }
            }
        }
        public int Snelheid
        {
            get { return _Snelheid; }
            set
            {
                if (value > 0)
                {
                    AutoGestartEvent?.Invoke(this);
                }
                if (value <= 0)
                {
                    AutoGestoptEvent?.Invoke(this);
                }
            } 
        }

        public string ToString()
        {
            return $"Liters :{LitersInTank} \n {Snelheid}";
        }
        public void VerminderAantalLiters()
        {
            LitersInTank -= 1;
        }
       
    }
}
