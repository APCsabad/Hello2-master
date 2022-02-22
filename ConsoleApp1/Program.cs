using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a búza mennyiségét tonnában!");
            int buza = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int szorzo = random.Next(5, 16);
            int szam = 0;

            szam = buza * szorzo;

            Console.WriteLine("A várható terményed: {0}", szam);
            Console.WriteLine("{0} szorzóval számolva ", szorzo);
            if (szorzo > 4 && szorzo <= 8)
            {
                Console.WriteLine("Átlag alatti");
            }
            if (szorzo > 8 && szorzo <= 12)
            {
                Console.WriteLine("Átlagos");
            }
            if (szorzo > 12)
            {
                Console.WriteLine("Átlag feletti");
            }

            Console.ReadKey();
        }
    }
}