using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtable3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Parancssori paraméterek száma lehet: 0, 1, 2*/
            int param = args.Length; //Paraméterek száma
            int szam1 = 0; // 1. paraméter értéke
            int szam2 = 0; // 2. paraméter értéke

            Random rnd = new Random(); // véletlenszám generáló objektum példányosítása

            // A számolás tagjainak beállítása
            switch (param)
            {
                case 0: // Paraméterek száma: 0
                    szam1 = rnd.Next(1, 100);
                    szam2 = rnd.Next(1, 100);
                    break;

                case 1: // Paraméterek száma: 1
                    szam1 = int.Parse(args[0]); // A stringként kapott paramétert átalakítjuk egésszé
                    szam2 = rnd.Next(1, 100);
                    break;

                case 2: // Paraméterek száma: 2
                    szam1 = int.Parse(args[0]);
                    szam2 = int.Parse(args[1]);
                    break;
            }

            // Kiíratom az eredményt
            Console.WriteLine(szam1 * szam2);
            Console.ReadKey();
        }
    }
}