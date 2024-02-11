using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Zadatak1
    {
        public static void zadatak1()
        {
            //V03 - While: Unesite ispravnu ocjenu(1 - 5)
            //Samo while

            int ocjena;
            do
            {
                Console.WriteLine("Unesite ocjenu: ");
                ocjena = Int32.Parse(Console.ReadLine());
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Niste unijeli ispravnu ocjenu.\n");
                }
                else
                {
                    Console.WriteLine("Unijeli ste ispravnu ocjenu.\n");
                }
            }
            while (ocjena >= 1 && ocjena <= 5);
            

        }
    }
}
