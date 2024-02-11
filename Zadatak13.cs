using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak13
    {
        public static void zadatak13()
        {
            Console.WriteLine("Unesite raspon za sumu prirodnih brojeva...");
            Console.Write("Unesite donju granicu za sumu prirodnih brojeva: ");
            uint donjaGranica;
            uint gornjaGranica;


            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out donjaGranica))
                {
                    Console.WriteLine($"Unesena donja granica: {donjaGranica}");
                    break;
                }
                else
                {
                    Console.WriteLine("Niste unijeli prirodni broj, unesite ponovo: ");
                }
            }

            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out gornjaGranica))
                {
                    Console.WriteLine($"Unesena gornja granica: {gornjaGranica}");
                    break;
                }
                else
                {
                    Console.WriteLine("Niste unijeli prirodni broj, unesite ponovo: ");
                }
            }

            if (donjaGranica > gornjaGranica)
            {
                Console.WriteLine("Donja je veća od gornje, mjenjam pozicije....");
                (donjaGranica,gornjaGranica) = (gornjaGranica,donjaGranica);
            }

            uint suma = 0;
            for (uint i = donjaGranica; i < gornjaGranica; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Suma pridornih brojeva u rasponu od {donjaGranica} - {gornjaGranica} je: {suma}");

        }
    }
}
