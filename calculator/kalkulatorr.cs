using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Kalkulatorr
    {
        
        private int szam1 = 0;
        private int szam2 = 0;
        private char muvjel;
        private int eredm = 0;
        private string uzen = "A művelet eredménye: ";

        public Kalkulatorr()
        {
        }

        public Kalkulatorr(int szam1, int szam2, char muvjel, int eredm, string uzen)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muvjel = muvjel;
            this.eredm = eredm;
            this.uzen = uzen;
        }
        public void beker()
        {

            Console.WriteLine("Adja meg az első számot");
            szam1 = 4; //int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a második számot");
            szam2 = 4; //int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a műveleti jelet");
            muvjel = '+'; //Convert.ToChar(Console.Read());
        }
        public int kiir()
        {

            switch (muvjel)
            {
                case '+':
                    eredm = szam1 + szam2;
                    break;

                case '-':
                    eredm = szam1 +-szam2;
                    break;

                case '*':
                    eredm = szam1 * szam2;
                    break;

                case '/':
                    eredm = szam1 / szam2;
                    break;

                default:
                    uzen = "Hibás műveleti jel";
                    break;

            }
            Console.WriteLine(uzen + eredm);
            
            Console.ReadKey();
            return eredm;

        }
    }
}
