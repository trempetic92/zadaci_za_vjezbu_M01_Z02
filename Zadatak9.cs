using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak9
    {
        public static void zadatak9()
        {
            /*
             V19 - Foreach: ispisati proizvoljni niz pomoću foreach "normalnim" redoslijedom pa koristeći metodu niza Reverse().
            */


            int[] brojevi = new int[5] {1,2,3,4,5};

            

            Console.WriteLine("Ispisano normalnim redosljedom:");
            foreach (int broj in brojevi)
            {
                Console.Write($"[{broj}]");
            }
            Console.WriteLine();
            Console.WriteLine("Ispisano obrnutim redosljedom:");

            foreach (int broj in brojevi.Reverse())
            {
                Console.Write($"[{broj}]");
            }

        }
    }
}
