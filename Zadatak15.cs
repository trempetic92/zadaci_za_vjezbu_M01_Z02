using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak15
    {
        public static void zadatak15()
        {
            int broj;
            int sumaKubova = 0;
            int suma = 0;

            Console.WriteLine("Unesite broj za provjeru jeli armstrongov broj...");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out broj))
                {
                    char[] znamenkeBroja = broj.ToString().ToCharArray();
                    for (int i = 0; i < znamenkeBroja.Length; i++)
                    {
                        sumaKubova = Int32.Parse(znamenkeBroja[i].ToString()) * Int32.Parse(znamenkeBroja[i].ToString()) * Int32.Parse(znamenkeBroja[i].ToString());
                        suma += sumaKubova;
                    }
                    if (suma == broj)
                    {
                        Console.WriteLine("Uneseni broj je armstrongov broj");
                    }
                    else
                    {
                        Console.WriteLine("Uneseni broj nije armstrongov broj");
                    }
                    suma = 0;
                }
                else
                {
                    Console.WriteLine("Unesite valjani broj...");
                }
            }
        }
    }
}
