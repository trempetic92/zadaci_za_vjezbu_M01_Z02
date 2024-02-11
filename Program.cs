using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Zadaci projekata koje smo preskočili:
                V03 - While: Unesite ispravnu ocjenu (1-5)
                V05 - While: Kopiranje niza znakova (stringa) uzimanjem svakog znaka kao string i kopiranje u novi string[].
                V09 - For: ispis popisa polaznika seminara od 1. do 10. uzlazno pa silazno
                V10 - For: Izračunajte prosjek ocjena iz proizvoljnog broja predmeta. Za unos ocjene iz svakog predmeta koristiti while kao u vježbi V03 
                V14 - For: sortirati znakove unesene rečenice (npr: Ovo. => Oov)
                V15 - For: Ispis neparnih brojevi koji su veći od 1, a manji od 20. Ispis brojeva iz intervala [1, 300] koji su djeljivi s 5.
                V16 - For: Unijeti broj redaka pa u svakom retku ispisati broj onoliko puta na kojem smo retku: 
                npr. za 4:
                1
                22
                333
                4444
                V18 - Foreach: Ispisati niz znakova pomoću foreach i for petlje: 
                char[] niz_znakova = {
                                'A', 'l', 'g', 'e', 'b',
                                'r', 'a', 'i', 'A', 'S',
                                'P', '.', 'N', 'E', 'T'
                            };
                V19 - Foreach: ispisati proizvoljni niz pomoću foreach "normalnim" redoslijedom pa koristeći metodu niza Reverse().
                V20 - Foreach: pronađite broj pojavljivanja unesenog znaka u unesenoj rečenici
                V21 - Foreach: učitati rečenicu pa je ispisati znak po znak, ali preskočiti razmake.

            */

            bool nastavi = true;
            while (nastavi)
            {
                Console.WriteLine("\nOdabir zadatka:\n");
                Console.WriteLine("1. Zadatak");
                Console.WriteLine("2. Zadatak");
                Console.WriteLine("3. Zadatak");
                Console.WriteLine("4. Zadatak");
                Console.WriteLine("5. Zadatak");
                Console.WriteLine("6. Zadatak");
                Console.WriteLine("7. Zadatak");
                Console.WriteLine("0. Izlaz\n\n");

                string odabir = Console.ReadLine();
                Console.WriteLine();

                switch (odabir)
                {
                    case "1":
                        Zadatak1.zadatak1();
                        break;
                    case "2":
                        Zadatak2.zadatak2();
                        break;
                    case "3":
                        Zadatak3.zadatak3();
                        break;
                    case "4":
                        Zadatak4.zadatak4();
                        break;
                    case "5":
                        Zadatak5.zadatak5();
                        break;
                    case "6":
                        Zadatak6.zadatak6();
                        break;
                    case "7":
                        Zadatak7.zadatak7();
                        break;
                    case "8":
                        Zadatak8.zadatak8();
                        break;
                    case "9":
                        Zadatak9.zadatak9();
                        break;
                    case "10":
                        Zadatak10.zadatak10();
                        break;
                    case "11":
                        Zadatak11.zadatak11();
                        break;
                    case "12":
                        Zadatak12.zadatak12();
                        break;
                    case "13":
                        Zadatak13.zadatak13();
                        break;
                    case "14":
                        Zadatak14.zadatak14();
                        break;
                    case "15":
                        Zadatak15.zadatak15();
                        break;
                    case "16":
                        Zadatak16.zadatak16();
                        break;
                    case "0":
                        nastavi = false;
                        break;
                    default:
                        Console.WriteLine("\nUnesite valjani broj zadatka.");
                        Console.Write(odabir);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
