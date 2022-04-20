using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Listameddigbirja
{
    class Program
    {
        static void Main(string[] args)
        {
           
                List<int> szamok = new List<int>();
                Console.WriteLine("Milyen hosszú legyen a lista?");
                Random random = new Random();
            Stopwatch timer = new Stopwatch();
                int a = Convert.ToInt32(Console.ReadLine());

            timer.Start();
                for (int i = 0; i < a; i++)
                {
                    szamok.Add(random.Next(1, 99));
                }
                
                for (int i = 0; i < a; i++)
                {

                Console.WriteLine("{0}/{1}",szamok[i], i);
                

                }
            timer.Stop();
            Console.WriteLine("Eltelt: "+timer.Elapsed);
            Console.ReadKey();
        }
    }
}
