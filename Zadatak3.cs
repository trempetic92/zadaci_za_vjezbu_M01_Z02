using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak3
    {
        public static void zadatak3()
        {
            //Samo for

            Console.WriteLine("Unesite popis 10 polaznika: ");
            string[] polaznici = new string[10];

            //Punjenje niza polaznicima
            for (int i = 0; i < polaznici.Length; i++)
            {
                Console.Write($"Unesite {i + 1}. polaznika: ");
                polaznici[i] = Console.ReadLine();
            }

            //ispis polaznika po redu upisanih
            Console.WriteLine("ispis polaznika po redu upisanih");

            for (int i = 0; i < polaznici.Length; i++)
            {
                Console.WriteLine(polaznici[i]);
            }

            Console.WriteLine("Ispis polaznika od zadnjeg prema prvom");

            for (int i = polaznici.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(polaznici[i]);
            }
        }
    }
}
