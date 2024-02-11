using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak8
    {
        public static void zadatak8()
        {
            /*
            V18 - Foreach: Ispisati niz znakova pomoću foreach i for petlje: 
                char[] niz_znakova = {
                                        'A', 'l', 'g', 'e', 'b',
                                        'r', 'a', 'i', 'A', 'S',
                                        'P', '.', 'N', 'E', 'T'
                                    };

            */
            char[] niz_znakova = {'A', 'l', 'g', 'e', 'b',
                                  'r', 'a', 'i', 'A', 'S',
                                  'P', '.', 'N', 'E', 'T'
                                 };
            Console.WriteLine("Ispis for petljom:");
            for (int i = 0; i < niz_znakova.Length; i++)
            {
                Console.Write(niz_znakova[i]);
            }

            Console.WriteLine("\n\nIspis foreach petljom:");
            foreach (char znak in niz_znakova)
            {
                Console.Write(znak);
            }

        }
    }
}
