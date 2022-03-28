using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool szam = true;
            Console.WriteLine("Adj meg egy számot!");
            while (szam)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    szam = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Adj meg egy számot!");
                    szam = true;
                }
            }

            Console.ReadKey();
        }
    }
}