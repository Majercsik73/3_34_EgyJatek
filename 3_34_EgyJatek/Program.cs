using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_34_EgyJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat: Két játékos felváltva mond számokat. Az első mond 1-et, 2-t, vagy 3-at. A következő az előzőnél 1-el, 2-vel, vagy 3-al többet mondhat. Az nyer, aki kimondja a 21-et. Készítsünk programot melyben a számítógéppel játsszuk ezt a játékot!

            //Algoritmusok a modern élet szabályai 2015

            //én: 1 5 9 13 17 21
            //te: 3 8 11 16 19
            int osszeg = 0;
            int nyertes = 1;
            do
            {
                Console.Write("játékos 1: ");
                int szam1;
                do
                {
                    szam1 = Convert.ToInt32(Console.ReadLine());
                    if (szam1 > 3 || szam1 < 1)
                    {
                        Console.WriteLine("Nem jó szám!");
                    }
                } while (szam1 > 3 || szam1 < 1);

                osszeg = osszeg + szam1;
                Console.WriteLine(osszeg);
                int szam2 = 0;
                nyertes = 1;
                if (osszeg != 21)
                {
                    Console.Write("játékos 2: ");
                    do
                    {
                        szam2 = Convert.ToInt32(Console.ReadLine());
                        if (szam2 > 3 || szam2 < 1)
                        {
                            Console.WriteLine("Nem jó szám!");
                        }
                    } while (szam2 > 3 || szam2 < 1);
                    nyertes = 2;
                }
                osszeg = osszeg + szam2;
                Console.WriteLine(osszeg);
            } while (osszeg < 21);

            if (nyertes == 1)
            {
                Console.WriteLine($"{nyertes} játékos nyert!");
            }
            else
            {
                Console.WriteLine($"{nyertes} játékos nyert!");
            }
            Console.ReadKey();



            //Feladat: Két játékos felváltva mond számokat. Az első mond 1-et, 2-t, vagy 3-at. A következő az előzőnél 1-el, 2-vel, vagy 3-al többet mondhat. Az nyer, aki kimondja a 21-et. Készítsünk programot melyben a számítógéppel játsszuk ezt a játékot!

            //Algoritmusok a modern élet szabályai 2015

            //én: 1 5 9 13 17 21
            //te: 3 8 11 16 19
            int osszeg2 = 0;
            int jatekos = 0; //0 -1 játékos 1 - 2 játékos
            do
            {
                Console.Write($"játékos {jatekos + 1}: ");
                int szam;
                do
                {
                    szam = Convert.ToInt32(Console.ReadLine());
                    if (szam > 3 || szam < 1)
                    {
                        Console.WriteLine("Nem jó szám!");
                    }
                } while (szam > 3 || szam < 1);

                osszeg2 = osszeg2 + szam;
                jatekos = (jatekos + 1) % 2;
                Console.WriteLine(osszeg);
            } while (osszeg2 < 21);

            Console.WriteLine($"{jatekos} játékos nyert!");

            Console.ReadKey();

        }
    }
}

