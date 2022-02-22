using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sziget_sorozat = 0;
            int sziget_sorozat_max = 0;
            int sziget_sum = 0;
            int hely = -1;
            string folytatas = "igen";
            bool sorozat = false;

            while (folytatas == "igen")
            {
                Console.WriteLine("Sziget 1 | Tenger 0");
                hely = Convert.ToInt32(Console.ReadLine());

                if (hely == 1)
                {
                    sziget_sum++;
                    sorozat = true;
                    if (sorozat)
                    {
                        sziget_sorozat++;
                    }
                }
                else
                {
                    sorozat = false;
                    sziget_sorozat_max = sziget_sorozat;
                    sziget_sorozat = 0;
                }

                Console.WriteLine("Akarsz meg megadni adatot? (igen/nem)");
                folytatas = Console.ReadLine();

                if (folytatas != "igen")
                {
                    if (sziget_sorozat_max < sziget_sorozat)
                    {
                        sziget_sorozat_max = sziget_sorozat;

                    }
                }
            }

            Console.WriteLine("Szigetek szama: {0}", sziget_sum);
            Console.WriteLine("Legtobb osszefuggo szigetek szama: {0}", sziget_sorozat_max);
            Console.ReadKey();
        }
    }
}
