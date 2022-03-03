
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

        public Állat(string nev, string fajta, string szín)
        {

            this.nev = nev;
            this.fajta = fajta;
            this.szín = szín;
        }
        public Állat()
        {

            this.nev = "Anonim";
            this.fajta = "ismeretlen";
            this.szín = "Fekete";
            this.kor = 0;
        }
        public string getnev()
        {
            return this.nev;
        }
        public int getkor()
        {
            return this.kor;
,        }
        public string getfajta()
        {
            return this.fajta;
        }
        public string getszín()
        {
            return this.szín;
        }
        public void setkor(int p) {
            if (p > 0 && p < 50) {
                this.kor = p;
            }
            
        }
     }
    class home {
        List<Állat> szobák = new List<Állat>;   
        public home() { 
        }
        public void allatadd(allat p) {C
            public szobak add(p);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Állat allat1 = new Állat("Bodri", "Puli", "fekete");
            Állat allat2 = new Állat("Csicska", "Németjuhász", "barna");
            Console.WriteLine("Az állta neve: {0}, kora: {1} Fajtája: {2} Színe: {3}", allat1.getnev(), allat1.getkor(), allat1.getfajta(), allat1.getszín());
            Console.WriteLine("Az állta neve: {0}, kora: {1} Fajtája: {2} Színe: {3}", allat2.getnev(), allat2.getkor(), allat2.getfajta(), allat2.getszín());
            Console.ReadKey();
        }
    }
}
