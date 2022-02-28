using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Állat {
        //osztály változó
        private string nev;
        private string fajta;
        private string szín;
        private int kor;

        public Állat(string nev, string fajta, string szín) {

            this.nev = nev;
            this.fajta = fajta;
            this.szín = szín;
        }
        public string getnev() {
            return this.nev;
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            Állat allat1 = new Állat("Bodri", "Puli", "fekete");
            Állat allat2 = new Állat("Csicska", "Németjuhász", "barna");
            Console.WriteLine("Az állta neve: {0}", allat1.getnev());
            Console.WriteLine("Az állta neve: {0}", allat2.getnev());
            Console.ReadKey();
        }
    }
}
