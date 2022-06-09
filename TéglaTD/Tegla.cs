using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TéglaTD
{
    public class Tegla
    {
        private int szel, hossz, magas;
        public Tegla(int szel,int hossz, int magas) {
            this.szel = szel;
            this.hossz = hossz;
            this.magas = magas;
        }
        public int getFelszin() {

            return 2 * (szel * magas + szel * hossz + magas * szel); }

        public int getTerfogat() {

            return magas * szel * hossz;
        }
    
    
    }

    }

