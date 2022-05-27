using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Minmax min = new Minmax();
            min.minmax();
            Console.ReadKey();
        }
    }
}
