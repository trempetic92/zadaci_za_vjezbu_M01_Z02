using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak10
    {
        public static void zadatak10()
        {
            //V20 - Foreach: pronađite broj pojavljivanja unesenog znaka u unesenoj rečenici

            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            char[] c = recenica.Trim().ToCharArray();

            Console.WriteLine("Unesite traženi znak: ");

            char znak = char.Parse(Console.ReadLine());
            int brojac = 0;
            foreach (char c2 in c)
            {
                if (c2 == znak)
                {
                    brojac++;
                }
            }

            Console.WriteLine($"Traženi znak se koristi {brojac} puta.");
        }
    }
}
