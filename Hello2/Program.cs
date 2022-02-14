using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konstansok
            const string FEJLESZTO = "Farkas Tamás";
            //Ez eg egysoros comment
            /*
             Ez többsoros
            //Ez így jó
             */
            // Változók
            string uzenet = "Helló Világ";
            int szam = 10;
            double szam2 = 10.3;
            bool gender = true;
            char karakter = 's';
            string szoveg = "szöveg";

            // Program törzse
            Console.WriteLine(uzenet);
            Console.WriteLine(szam);
            Console.WriteLine(szam2);
            Console.WriteLine(gender);
            Console.WriteLine(karakter);
            Console.WriteLine(szoveg);
            Console.ReadKey();
        }
    }
}
