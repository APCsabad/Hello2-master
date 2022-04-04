using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class Szamrendszer
    {
        public void szamolas()
        {
            Console.WriteLine("Írj be egy számot amitát szeretnél váltattni!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Írd meg hanyas számrendszerben akarod átváltani!");
            int b = Convert.ToInt32(Console.ReadLine());

            string szamrendszer = Convert.ToString(a, b);

            Console.WriteLine(szamrendszer);


        }
    }
}
