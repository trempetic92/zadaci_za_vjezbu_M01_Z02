using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak4
    {
        public static void zadatak4()
        {

            // Samo for, iako se traži unos while petljom, ali gdje je onda čar :D
            Console.WriteLine("--IZRAČUN PROSJEKA ZA UNESENE KOLEGIJE--\n");

            List<string> kolegiji = new List<string>();
            List<int> ocjeneKolegija = new List<int>();


            Console.WriteLine("Krenite unositi nazive kolegija, za kraj unosa unesite 'kraj'");
            for (int i = 0; i >= 0; i++)
            {
                Console.Write($"Unesite {i + 1} kolegij: ");
                string kolegij = Console.ReadLine();
                if (kolegij == "kraj")
                {
                    Console.WriteLine("\nZavršili ste sa unosom\n");
                    break;
                }
                else
                {
                    kolegiji.Add(kolegij);                 
                    ocjeneKolegija.Add(ispravnaOcjena(kolegij));
                }
            }

            int zbrojOcjena = 0;
            for (int i = 0; i < kolegiji.Count; i++)
            {
                Console.WriteLine($"Unesena ocijena za {kolegiji[i]} je {ocjeneKolegija[i]}");
                zbrojOcjena += ocjeneKolegija[i];
            }

            double prosjek = zbrojOcjena / kolegiji.Count;
            Console.WriteLine($"\nUkupan prosijek ocijena za unešene kolegije je: {prosjek}");

        }

        static int ispravnaOcjena(string kolegij)
        {
            Console.Write($"Unesite ocjenu za kolegij {kolegij} od 1 do 5: ");
            string unosOcjene = Console.ReadLine();
            int ocjena;

            if (int.TryParse(unosOcjene, out ocjena) && (ocjena >= 1 || ocjena <= 5))
            {
                return ocjena;
            }
            else
            {
                Console.WriteLine("Krivi unos, ocjena mora biti od 1 do 5\n");
                return ispravnaOcjena(kolegij);
            }
        }
    }
}
