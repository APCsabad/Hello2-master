using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az igazolatlan hiányzásait!");
            int hianyzas = Convert.ToInt32(Console.ReadLine());
            if (hianyzas < 0)
            {
                Console.WriteLine("Kérem adjon meg egy valós értéket!");
            }
            else if (hianyzas == 10)
            {
                Console.WriteLine("Kérem a születési dátumát!");
                int szul = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("jelenleg {0} igazolatlan hiányzásod van.", hianyzas);
            }
            else if (hianyzas > 10 && hianyzas < 20)
            {
                Console.WriteLine("Kérem a születési dátumát!");
                int szul = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Egy osztályfőnöki figyelmeztetést írtunk jóvá ön számára.");
            }
            else if (hianyzas >= 20 && hianyzas < 30)
            {
                Console.WriteLine("Kérem a születési dátumát!");
                int szul = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Egy osztályfőnöki intőt írtunk jóvá ön számára.");
            }
            else if (hianyzas >= 30 && hianyzas < 40)
            {
                Console.WriteLine("Kérem a születési dátumát!");
                int szul = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Egy igazgatói intőt írtunk jóvá ön számára.");
            }
            else if (hianyzas >= 40)
            {
                Console.WriteLine("Kérem a születési dátumát!");
                int szul = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Önt azonnali hatájal felfüggesztettük.");
            }
            else if (hianyzas > 1000)
            {
                Console.WriteLine("Kérem adjon meg egy valós értéket!");
            }
            Console.ReadKey();
        }
    }
}
