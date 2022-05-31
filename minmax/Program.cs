using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax {
    public class Program {
        public static void Main(string[] args) {

            Adat adat = new Adat();

            Console.WriteLine("Min: " + adat.min());
            Console.WriteLine("Max: " + adat.max());

            Console.ReadKey();
        }
    }
}
