using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak5
    {
        public static void zadatak5()
        {
            Console.WriteLine("Unesite rečenicu kojoj želite sortirati znakove po redu:");
            string recenica = Console.ReadLine();

            recenica = recenica.Replace(" ", "").Trim();

            char[] c = recenica.ToCharArray();

            for (int i = 0; i < c.Length - 1; i++)
            {
                for (int j = 0; j < c.Length - i - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        (c[j], c[j + 1]) = (c[j + 1], c[j]);
                    }
                }
            }

            Console.WriteLine("Sortirani znakovi recenice:");
            for (int i = 0;i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

        }
    }
}
