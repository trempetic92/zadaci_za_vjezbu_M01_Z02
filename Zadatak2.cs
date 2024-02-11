using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak2
    {
        public static void zadatak2()
        {
            //Samo while

            Console.WriteLine("Koliko elemenata želite unijeti u niz?");
            int brojElemenata = Int32.Parse(Console.ReadLine());
            string[] niz1 = new string[brojElemenata];

            Console.WriteLine("Unesite elemente, za kraj unesite 'kraj'");

            int i = 0;
            while (i < brojElemenata)
            {
                Console.Write($"Unesite {i + 1}. element niza: ");
                string unos = Console.ReadLine();

                if (unos.ToLower() == "kraj")
                {
                    Console.WriteLine("Završetak unosa.");
                    break;
                }
                else
                {
                    niz1[i] = unos;
                    i++;
                }
            }
            //Ispis prvog niza

            i = 0;
            Console.WriteLine("Uneseni elementi niza su:");
            while (i < brojElemenata)
            {
                Console.Write("[" + niz1[i] + "] ");
                i++;
            }

            //Kopiranje iz jednog niza u drugi

            string[] niz2 = new string[brojElemenata];
            i = 0;
            while (i < brojElemenata)
            {
                niz2[i] = niz1[i];
                i++;
            }


            //Ispis drugog niza

            i = 0;
            Console.WriteLine("\n\nElementi drugog niza kopirani iz prvog su:\n");
            while (i < brojElemenata)
            {
                Console.Write("[" + niz2[i] + "] ");
                i++;
            }
        }
    }
}
