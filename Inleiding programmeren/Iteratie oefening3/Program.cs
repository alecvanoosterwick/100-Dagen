using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteratie_oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            // kleuren
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //variablen
            int getal, kwadraat, teller;

            //lezen
            Console.Write("geef je getal: ");
            getal = int.Parse(Console.ReadLine());
            kwadraat = 0;
            
                for(int i = getal; i >= 1; i--)
            {
                teller = getal--;
                kwadraat = teller * teller;
                Console.WriteLine(kwadraat);

            }
            Console.ReadLine();
        }
    }
}
