using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozat
{
    class Sorozat
    {
        private int[] szam = new int[4];

        public void szamolas()
        {
            Console.WriteLine("Adjon meg 4 számot és a program eldönti hogy mértani vagy számatni sorozat.");
            for (int i = 0; i < szam.Length; i++)
            {
                szam[i] = Convert.ToInt32(Console.ReadLine());
            }
            mertani();
            szamtani();
        }

        public void mertani()
        {

            int elsomertan = szam[szam.Length - 1] / szam[szam.Length - 2];
            bool jo = true;
            for (int i = szam.Length - 1; i > 0; i--)
            {
                int hanyados1 = szam[i] / szam[i - 1];

                if (hanyados1 != elsomertan)
                {
                    Console.WriteLine("Nem mértani!");
                    jo = false;
                    break;
                }
            }
            if (jo)
            {
                Console.WriteLine("Mértanin sorozat");
            }

        }
        public void szamtani()
        {

            int elsoszamtan = szam[szam.Length - 1] - szam[szam.Length - 2];
            bool jo2 = true;
            for (int i = szam.Length - 1; i > 0; i--)
            {
                int hanyados2 = szam[i] - szam[i - 1];

                if (hanyados2 != elsoszamtan)
                {
                    Console.WriteLine("Nem számtani!");
                    jo2 = false;
                    break;
                }
            }
            if (jo2)
            {
                Console.WriteLine("Számtani sorozat");
            }
        }
    }
}
