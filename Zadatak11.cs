using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak11
    {
        public static void zadatak11()
        {
            //V21 - Foreach: učitati rečenicu pa je ispisati znak po znak, ali preskočiti razmake.


            Console.WriteLine("Unesite rečenicu:");

            string recenica = Console.ReadLine();

            foreach (char s in recenica.ToCharArray())
            {
                if (s != ' ')
                {
                    Console.Write(s);
                }
                else 
                {
                    continue;
                }
            }
        }
    }
}
