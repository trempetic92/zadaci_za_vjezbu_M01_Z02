using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak17
    {
        public static void zadatak17()
        {

            Console.WriteLine("Unesite broj redova: ");
            int brojRedova = Int32.Parse(Console.ReadLine());
            int duljinaNajvecegBroja = (brojRedova * (brojRedova + 1) / 2).ToString().Length + 1;
            int duzinaZadnjegReda = brojRedova * duljinaNajvecegBroja;
            int broj = 1;

            for (int i = 0; i < brojRedova; i++)
            {
                int pocetniRazmak = (duzinaZadnjegReda / 2) - (i * duljinaNajvecegBroja / 2);

                Console.Write(new string(' ', pocetniRazmak));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(broj++.ToString().PadRight(duljinaNajvecegBroja, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
