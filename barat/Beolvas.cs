using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barat
{
    internal class BaratLista
    {
        private class Barat {
            private string nev;
            private DateTime szuletett;
            private char nem;
            private int bulis;
            

            public Barat() { }
            public Barat(String nev, DateTime szuletett, char nem, int bulis)
            {
                this.nev = nev;
                this.szuletett = szuletett;
                this.nem = nem;
                this.bulis = bulis;
            }
            public void printBarat() {

                Console.WriteLine("{0, 20} {1, 10} {2, 1} {3}", nev, szuletett.ToShortDateString(), nem, bulis);

            }
        }
        private List<Barat> baratLista;
        private string fajlNev;
        private int index=0;
        public BaratLista() {
            baratLista = new List<Barat>();
        }

        public void Beolvas() {

            string sor;
            string[] mezok;
            Console.WriteLine("Adja meg a szövegfájl nevét és elérési útvonalát!");
            fajlNev = Console.ReadLine();
            if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";

            using(StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                while (sr.EndOfStream == false) {

                sor = sr.ReadLine();
                if (sor.Trim().Length == 0) continue;
                mezok = sor.Split(',');
                baratLista.Add(new Barat(mezok[0], DateTime.Parse(mezok[1]), char.Parse(mezok[2]), int.Parse(mezok[3])));
            }
        }
        public void kiir() {

        
        }
        public void keys() {

            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.PageUp)
            {
                index ++;
            }
            if (keys.Key == ConsoleKey.PageDown)
            {
                index--;
            }
            if (keys.Key == ConsoleKey.Home)
            {
                index = 0;
            }
            if (keys.Key == ConsoleKey.End)
            {
                index = baratLista.Count - 20;
            }

        }


    }
}
