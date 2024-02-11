using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak6
    {
        public static void zadatak6()
        {
            //V15 - For: Ispis neparnih brojevi koji su veći od 1, a manji od 20. Ispis brojeva iz intervala [1, 300] koji su djeljivi s 5.

            Console.WriteLine("Ispis neparnih brojeva između 1 i 20");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"[{i}]");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Ipis brojeva dijeljivih sa 5 u intervalu [1, 300]");

            for(int i = 1;i <= 300; i++)
            {
                if(i % 5 == 0)
                {
                    Console.Write($"[{i}]");
                }
            }



        }
    }
}
