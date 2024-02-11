using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak16
    {
        public static void zadatak16()
        {
            int broj;        
            int suma = 0;

            Console.WriteLine("Unesite broj za provjeru je li broj savršen...");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out broj))
                {
                    for (int i = 1; i <= broj / 2; i++)
                    {
                        if (broj % i == 0)
                        {
                            suma += i;
                        }
                    }
                    if (suma == broj && broj != 0)
                    {
                        Console.WriteLine($"Uneseni broj {broj} je savršen broj");
                    }
                    else
                    {
                        Console.WriteLine($"Uneseni broj {broj} nije savršen broj");
                    }
                    
                    suma = 0;
                }
                else
                {
                    Console.WriteLine($"Unesite prirodni broj...");
                }
            }
        }
    }
}
