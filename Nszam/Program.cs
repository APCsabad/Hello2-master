using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nszam
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Kérjünk be N darab természetes számot. Az N értékét véletlen szerűen az 5-10 tartományból válasszuk ki. Az adatokbeolvasása után a program írja ki a páros és páratlan számok darabszámát, és a páratlanszámok összegét a megadott N-ig!

           */
            Console.WriteLine("Írj be random számokat. A program random meg fog állítani és elmondja hány páros, hány páratlan van köztük illetve a páratlanokat összeadja.");
            Random random = new Random();
            int N = random.Next(5, 10);
            int[] tomb = new int[N];
            int paros = 0;
            int paratlan = 0;
            int paratlanok = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = int.Parse(Console.ReadLine());
                if (tomb[i] % 2 == 0)
                {
                    paros++;
                }
                else {
                    paratlan++;
                    paratlanok += tomb[i];
                }
            }
            Console.WriteLine("Páratlanok száma: {0}", paratlan);
            Console.WriteLine("Párosak száma: {0}", paros);
            Console.WriteLine("Páratlanok összege: {0}", paratlanok);
            Console.ReadKey();

        }
    }
}
