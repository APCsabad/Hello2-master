using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuű
{
    class Menu
    {
        public void menupont()
        {
            int a = 0;
           
            while (a != 5)
            {
                Console.WriteLine("Kérem válasszon az a menüpontok közt 1-4 ig, az ötös menüpontal kilép a programból.");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 5)
                {
                    Console.WriteLine("Kérem valós menüpontot adjon meg!");
                }
                else if (a == 1)
                {
                    Console.WriteLine("Ön az első menüpontot választotta");
                }
                else if (a == 2)
                {
                    Console.WriteLine("Ön az második menüpontot választotta");
                }
                else if (a == 3)
                {
                    Console.WriteLine("Ön az harmadik menüpontot választotta");
                }
                else if (a == 4)
                {
                    Console.WriteLine("Ön az negyedik menüpontot választotta");
                }
                else if (a == 5)
                {
                    Console.WriteLine("Ön kilépett a programból.");
                    break;
                }

            }
        }
    }
   
}
