using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolist

{ internal class AutoLista
{
    private class Auto
    {
            private string rendszam;
            private string gyartmany;
            private string tipus;
            private DateTime gyartasev;
            private DateTime muszaki;
            private string tulajdonos;

        public Auto() { }
        public Auto(String rendszam, string gyartmany, string tipus, DateTime gyartasev, DateTime muszaki,string tulajdonos)
        {
                this.rendszam = rendszam;
                this.gyartmany = gyartmany;
                this.tipus = tipus;
                this.gyartasev = gyartasev;
                this.muszaki = muszaki;
                this.tulajdonos = tulajdonos;
        }
        public void printAuto()
        {

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", rendszam, gyartmany, tipus, gyartasev.ToShortDateString(), muszaki.ToShortDateString(), tulajdonos);

        }
    }
    private List<Auto> autoLista;
    private string fajlNev;
    public AutoLista()
    {
        autoLista = new List<Auto>();
    }

    public void Beolvas()
    {

        string sor;
        string[] mezok;
        Console.WriteLine("Adja meg a szövegfájl nevét és elérési útvonalát!");
        fajlNev = Console.ReadLine();
        if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";

        using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
            while (sr.EndOfStream == false)
            {

                sor = sr.ReadLine();
                if (sor.Trim().Length == 0) continue;
                mezok = sor.Split(',');
                autoLista.Add(new Auto(mezok[0], mezok[1], mezok[2], DateTime.Parse(mezok[3]), DateTime.Parse(mezok[4]), mezok[5]));
            }
    }
    public void kiir()
    {

        foreach (Auto p in autoLista)
        {
            p.printAuto();
        }
        Console.ReadKey();
    }


}
}