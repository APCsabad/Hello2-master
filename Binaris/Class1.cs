using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {
        private string a;
        private int c;
        public Binaris()
        {


        }
        public void binariis() {
            Console.WriteLine("Adjon meg egy bináris számot és a program megnézi hány 1-es szerepel benne!");
            a = Console.ReadLine();
            int b = 0;
            foreach (char t in a)
                if (t == '1') b++;
            Console.WriteLine("Ebben a bináris számban:{0} egyes van.",b );
        }
    }
}
