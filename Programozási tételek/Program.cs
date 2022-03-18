using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    class Program
    {
        static void Main(string[] args)
        {
            Tetelek tetel = new Tetelek();

            Console.WriteLine("A tömb elemeinek összege: {0} ", tetel.osszeg());
            Console.WriteLine("A tömbben {0} negatív szám van.", tetel.negativ());
            Console.WriteLine(tetel.osszehasonlitas());
            Console.ReadKey();

        }


        }
}

