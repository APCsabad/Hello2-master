using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Szamok
    {
        public void nyeroszamok()
        {
            int[] tomb1 = new int[5];
            Random random = new Random();
            Console.WriteLine("A nyerőszámok a következőek:");
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                s = random.Next(1, 91);
                for (int t = 0; t < tomb1.Length; t++)
                { 
                    if (tomb1[i] != s)
                    {
                        tomb1[i] = s;
                        t++;
                    }
                }

                tomb1[i] = random.Next(1, 91);
                Console.WriteLine(tomb1[i]);
            } 
        }
    }
    
}
