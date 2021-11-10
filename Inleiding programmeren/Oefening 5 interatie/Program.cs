using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5_interatie
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2;
            Console.Write("geef een getal: ");
            getal1 = int.Parse(Console.ReadLine());
            Console.Write("geef een getal: ");
            getal2 = int.Parse(Console.ReadLine());

            if (getal1 > getal2)
            {
                for (int i = getal1; i >= getal2; i--)
                {

                    Console.WriteLine(getal1);
                    getal1--;
                }
            }
            else
            {
                for (int i = getal2; i >= getal1; i--)
                {

                    Console.WriteLine(getal2);
                    getal2--;
                }
            }
            
            Console.ReadLine();
        }
    }
}
