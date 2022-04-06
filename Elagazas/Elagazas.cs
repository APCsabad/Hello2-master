using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagazas
    {
        public void lista()
        {
            List<int> szamok = new List<int>();
            Console.Write("Hány darab szám legyen?");
            int a = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                szamok.Add(random.Next(10, 99));
            }

            foreach (int x in szamok)
                if (x%2 ==0)
                {
                    Console.WriteLine(x);
                }
                



        }
    }
}
