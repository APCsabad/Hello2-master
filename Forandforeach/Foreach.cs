using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forandforeach
{
    class Foreach
    {
        public void lista() {
            List<int> szamok = new List<int>();
            Console.WriteLine("Milyen hosszú legyen a lista?");
            Random random = new Random();
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a ; i++)
            {
                szamok.Add(random.Next(1,99));
            }
            Console.WriteLine("Ez forciklussal van kiírva: ");
            for (int i = 0; i < a; i++)
            {
                
                Console.WriteLine(szamok[i]);
            }
            Console.WriteLine("Ez foreach-el van kiírva: ");
            foreach (int b in szamok)
                Console.WriteLine(b);
                
        }
    }
}
