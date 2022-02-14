using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int szam1;
            int szam2;
            char muvjel;
            float eredm = 0;
            string uzen = "A művelet eredménye: ";

            // Beolvasások
            szam1 = int.Parse(Console.ReadLine());
            szam2 = int.Parse(Console.ReadLine());
            muvjel = Convert.ToChar(Console.Read());

            switch (muvjel)
            {
                case '+':
                    eredm = szam1 + szam2;
                    break;

                case '-':
                    eredm = szam1 + szam2;
                    break;

                case '*':
                    eredm = szam1 + szam2;
                    break;

                case '/':
                    eredm = szam1 + szam2;
                    break;

                default:
                    uzen = "Hibás műveleti jel";
                    break;
            }

            Console.WriteLine(uzen + eredm);
            Console.ReadKey();
        }
    }
}
