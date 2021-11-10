using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ieteratie_oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kleuren 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //variablen
            int getal, som;
            som = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("geef het getal weer: ");
                getal = int.Parse(Console.ReadLine());
                som = som + getal;

            }
            Console.WriteLine("de som van de getallen is: {0}", som);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadLine();
            


        }
    }
}
