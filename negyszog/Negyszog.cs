using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    public class Negyszog
    {
        public double oldal { get; set; }

        public Negyszog(double oldal) {
            this.oldal = oldal;
        
        }

        public double kerulet() {
            return 4 * oldal;
        
        }

        public double terulet() {
            return oldal * oldal;
        
        }

        public double atlo()
        {

            return Math.Round(Math.Sqrt(oldal * oldal + oldal * oldal), 2);

        }
        public double oszlop()
        {

            return 

        }

    }
}
