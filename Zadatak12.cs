using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak12
    {
        public static void zadatak12()
        {
            //1.	Ispisati tablicu množenja 

            Console.WriteLine("Unesite do kojeg broja će raditi tablica množenja:");

            int broj = Int32.Parse(Console.ReadLine());

            int[][] tablicaMnozenja = new int[broj][];

            for (int i = 0; i < tablicaMnozenja.Length; i++)
            {
                tablicaMnozenja[i] = new int[broj];
                for (int j = 0; j < broj; j++)
                {
                    tablicaMnozenja[i][j] = (i + 1) * (j + 1);
                }
            }

            
            for (int i = 0; i < tablicaMnozenja.Length; i++)
            {
                for (int j = 0; j < broj; j++)
                {
                    Console.Write($"{tablicaMnozenja[i][j]}\t");
                }
                Console.WriteLine();            
            }
        }
    }
}
