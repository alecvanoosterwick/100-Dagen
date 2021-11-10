using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteratie_oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            string symbool1, symbool2, symbool;
            int lengte, breedte;

            Console.Write("geef symbool 1: ");
            symbool1 = Console.ReadLine();
            Console.Write("geef symbool 2: ");
            symbool2 = Console.ReadLine();

            Console.Write("geef de lengte: ");
            lengte = int.Parse(Console.ReadLine());
            Console.Write("geef de breedte: ");
            breedte = int.Parse(Console.ReadLine());

            symbool = symbool1;
            for (int i = 1; i <= lengte; i++)
            {  
                for (int j = 1; j <= breedte; j++)
                {
                    Console.Write(symbool);
                }
                Console.WriteLine();

                // wissel van symbool
                if (symbool == symbool1)
                {
                    symbool = symbool2;
                }
                else
                {
                    symbool = symbool1;
                }
            }
            Console.ReadLine();
        }
    }
}
