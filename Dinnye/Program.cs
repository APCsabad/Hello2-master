using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinnye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a dinnye átmérőjét!(cm)");
            double csomag = 0;
            double testtomeg = int.Parse(Console.ReadLine());
            csomag = Math.PI *testtomeg*2 + 60;
            Console.WriteLine("Önnek {0}cm szalagra van szüksége.",csomag);
            Console.ReadKey();

        }
    }
}
