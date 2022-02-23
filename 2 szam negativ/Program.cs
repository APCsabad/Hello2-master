using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_szam_negativ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Írjon programot negativ.py néven! A program kérjen be két nullától különböző számot a felhasználótól, majd írja ki, hogy a két szám közül melyik a negatív! A program üzeneteinek megfogalmazásában kövesse az alábbi példát! Azokat a részeket, amiket a felhasználó gépel be, a mintában vastagított és döntött betűkkel emeltük ki.
             */
            Console.WriteLine("Adj meg egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a második számot!");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 && b < 0)
            {
                Console.WriteLine("Mind a két szám negatív");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("A két szám közül az első negatív.");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("A két szám közül a második negatív.");
            }
            else if (a == 0)
            {
                Console.WriteLine("Kérem nullától különböző számot adjon meg!");
            }
            else if (b == 0)
            {
                Console.WriteLine("Kérem nullától különböző számot adjon meg!");
            }
            else
            {
                Console.WriteLine("Mind két szám pozitív.");
            }
            Console.ReadKey();
        }
    }
}
