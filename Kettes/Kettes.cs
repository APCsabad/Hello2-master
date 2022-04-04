using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        public void kettess() {
            Console.WriteLine("Írj be egy számot!");

            int a = Convert.ToInt32(Console.ReadLine());

            string binaris = Convert.ToString(a, 2);

            Console.WriteLine(binaris);


        }
    }
}
