using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace körclass
{
    class kör
    {
        // Osztályváltozók (properties) körs sugár  beolvasás majd kör terület kerület
        private double körsugar;


      
        public void setSugar() { körsugar = Convert.ToDouble(Console.ReadLine()); }
        public double getSugar() { return körsugar; }
        public double getTerület() { return  Math.PI * (körsugar * körsugar); }
       
        public double getKerület() { return 2*Math.PI * körsugar; }
      
    }

    class Program
        {
            static void Main(string[] args)
        {
            kör kör1 = new kör();
            Console.WriteLine("Adja meg a kör sugarát");
            kör1.setSugar();
            Console.WriteLine("A kör sugara: {0}", kör1.getSugar());
            Console.WriteLine("A kör kerülete: {0}", kör1.getKerület());
            Console.WriteLine("A kör területe: {0}", kör1.getTerület());
            Console.ReadKey();
        }
        }
    }

