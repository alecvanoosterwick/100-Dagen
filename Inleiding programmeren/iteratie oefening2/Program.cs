using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace iteratie_oefening2
{
    class Program
    {
        static void Main(string[] args)
        {// kleuren
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //variablen
            string naam,resultaat;
            int geluksgetal;

            //lezen
            Console.Write("Geef je geluksgetal: ");
            geluksgetal = int.Parse(Console.ReadLine());
            resultaat = geluksgetal.ToString() + " " ;
            Console.Write("Geef je naam: ");
            naam = Console.ReadLine();

            for (int i = 1; i <= geluksgetal; i++) 
            {
                resultaat = resultaat + naam + " ";
                

            }
            Console.Write( resultaat);
            Console.ReadLine();
        }
    }
}
