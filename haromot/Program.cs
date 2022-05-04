using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromot
{
    public class Program
    {
        public class Szam {
            try
            {
                int a = 0;
                Console.WriteLine("Adjon meg egy számot, ha osztható öttel vagy hárommal akkor a szám kiírja hogy 'öt' vagy 'három', ha nem akkor kiírja a számot");
                a = Convert.ToInt32(Console.ReadLine());

                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                
            }


        }


        public void getszam() {
            Szam szam = new Szam();
            if (a%3==0)
            {
                Console.WriteLine("Három");
            }
            else if (a%5==0)
            {
                Console.WriteLine("Öt");
            }
            else
            {
                Console.WriteLine(a);
            }
        }


        public static void Main()
        {
            
           
            
            Console.ReadKey();




        }
    }
}
