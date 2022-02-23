using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szambekeres_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("írj be számokat, ha 0-t írsz akkor megáll a program és kiírja a legnagyobbat közülük.");
            int max = 0;
            int valtozo = -1;
            do
            {
                valtozo=Convert.ToInt32(Console.ReadLine());
                if (max < valtozo) max = valtozo;
                
            } while (valtozo != 0);
            Console.WriteLine("A legnagyobb szám: {0}", max);
            Console.ReadKey();
        }

        }
    }

