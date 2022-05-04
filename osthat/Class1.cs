using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osthat
{
    class Class1
    {
        public int a;
        public void setszam()
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e )
            {

                Console.WriteLine(e.Message);
            }
            
            
        }
        public void getszam() {
            if (a % 3 == 0)
            {
                Console.WriteLine("Három");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Öt");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }

}
