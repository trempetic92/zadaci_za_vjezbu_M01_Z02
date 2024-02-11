using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak14
    {
        public static void zadatak14()
        {
            //3.	Izračunaj sumu znamenki nekog broja. 

            Console.WriteLine("Unesite broj kako bi izračunali sumu svih znamenki tog broja:");
            int broj;
            int suma = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out broj))
                {
                    char[] znamenkeBroja = broj.ToString().ToCharArray();
                    Console.Write($"Suma znamenki broja {broj} je:");                   
                    for (int i = 0;i<znamenkeBroja.Length;i++)
                    {
                        suma += Int32.Parse(znamenkeBroja[i].ToString());
                    }
                    Console.Write(suma);
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
