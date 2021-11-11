using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Models
{
    public class Student
    {
        //attributen
        private string _naam;
        private double _wiskunde;
        private double _informatica;

        //properties
        public string Naam
        {
            get { return _naam; }
            set
            {
                int result;
                if (int.TryParse(value, out result) == true)
                {
                    _naam = "...";
                }
                else
                {
                    _naam = value.ToUpper();
                }
            }
        }


        public double Wiskunde
        {
            get { return _wiskunde; }
            set
            {
                if (value < 0 || value > 20)
                    _wiskunde = 0;
                else
                    _wiskunde = value;
            }
        }

        public double Informatica
        {
            get { return _informatica; }
            set
            {
                if (value < 0 || value > 20)
                    _informatica = 0;
                else
                    _informatica = value;
            }
        }

        //constructor
        public Student()
        {
            Naam = "";
            Wiskunde = 0;
            Informatica = 0;
        }

        

        //methodes
        public string ToonGegevens()
        {
            string uitvoer;
            uitvoer = Naam + " heeft " + Wiskunde.ToString() + " op wiskunde en " + Informatica.ToString() + " op informatica behaald";
            return uitvoer;
        }
    }
}
