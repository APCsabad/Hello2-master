using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezes
{
    class Program
    {
        static void Main(string[] args)
        {
            double szelesseg, hosszusag;
            Console.WriteLine("Ird be a terulet szelesseget:");
            szelesseg = double.Parse(Console.ReadLine());

            Console.WriteLine("Ird be a terulet hosszuság:");
            hosszusag = double.Parse(Console.ReadLine());
            double t = szelesseg * hosszusag;

            double csempe = t / (0.2 * 0.2);
            Console.WriteLine("a helyiség területe {0}", t);
            Console.WriteLine(csempe + (csempe * 0.1));
            Console.ReadKey();
        }
    }
}
