using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SzigetekUT
{
    public class Sziget
    {
        int sziget_sorozat = 0;
        int sziget_sorozat_max = 0;
        int sziget_sum = 0;
        string hely;
        bool sorozat = false;
       
        public void beker() {

            Console.WriteLine("Adjon meg egy sziget sorozatot. Sziget = 1 tenger = 0.");
            hely = Console.ReadLine();
        }
        public int[] forsziget() {

            for (int index = 0; index < hely.Length; index++)
            {


                if (hely[index] == '1')
                {
                    sziget_sum++;
                    sorozat = true;
                    if (sorozat)
                    {
                        sziget_sorozat++;

                        StringReader sw = new StringReader("1000111");
                        Console.SetIn(sw);
                    }
                }
                else
                {
                    sorozat = false;
                    sziget_sorozat_max = sziget_sorozat;
                    sziget_sorozat = 0;
                }



                if (index == hely.Length - 1)
                {
                    if (sziget_sorozat_max < sziget_sorozat)
                    {
                        sziget_sorozat_max = sziget_sorozat;

                    }
                }
            }
            int[] tomb = { sziget_sum, sziget_sorozat_max};
            return tomb;
        }
 
        public void kiir() {

            Console.WriteLine("Szigetek szama: {0}", sziget_sum);
            Console.WriteLine("Legtobb osszefuggo szigetek szama: {0}", sziget_sorozat_max);
            Console.ReadKey();
        }
    }
}
