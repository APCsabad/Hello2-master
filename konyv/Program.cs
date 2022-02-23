using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            string vege = "0";
            int konyvo = 0;
            while (vege == "0")
            {
                Console.WriteLine("Adj meg a könyv címét!");
                string konyvc = Console.ReadLine();
                if (konyvc == "") break;
                Console.WriteLine("Add meg a könyv oldalszámait!");
                if(konyvc != "")  konyvo = Convert.ToInt32(Console.ReadLine());
                if (konyvo > 150)
                {
                    Console.WriteLine("A(z) {0} hosszú terjedelmű könyv.", konyvc);
                }
                else
                {
                    Console.WriteLine("A(z) {0} rövid terjedelmű könyv.", konyvc);
                }
                if (konyvc =="")
                {
                    vege = "";
                }

            }
            Console.ReadKey();
        }
    }
}
