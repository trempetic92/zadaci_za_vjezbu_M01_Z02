using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak7
    {
        public static void zadatak7()
        {
            //V16 - For: Unijeti broj redaka pa u svakom retku ispisati broj onoliko puta na kojem smo retku: 


            Console.WriteLine("Unesite broj redaka za ispis:");
            int brojRedaka = Int32.Parse(Console.ReadLine());
            int duljinaNajvecegBroja = brojRedaka.ToString().Length;
            int a = 1;

            for (int i = 0; i < brojRedaka; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"{a.ToString().PadLeft(duljinaNajvecegBroja + 1)}");
                }
                Console.WriteLine();
                a++;
            }

        }
    }
}
