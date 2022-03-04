using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace körclass
{
    class Kör
    {   //henger osztály be kell kérni a magasságát, metódust írni a térfogatra az alapterületre
        // Osztályváltozók (properties) körs sugár  beolvasás majd kör terület kerület
        protected double körsugar;
        public Kör() { } 

      
        public void setSugar() { this.körsugar = Convert.ToDouble(Console.ReadLine()); }
        public double getSugar() { return this.körsugar; } 
        public double getTerület() { return  Math.PI * (this.körsugar * this.körsugar); }
       
        public double getKerület() { return 2*Math.PI * this.körsugar; }
      
    }
    class Henger : Kör {
        
        private double magassag;
        public Henger() : base() { }
        public void Magasság() 
        { 
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
        public double getMagasság() { return this.magassag; }

        public double getTérfogat() { return Math.PI * (this.körsugar * this.körsugar) * this.magassag; }
        public double getalapterület() { return 2 * Math.PI * this.körsugar * this.magassag; }


    }

    class Program
        {
            static void Main(string[] args)
        {
            Kör kör1 = new Kör();
            Henger henger1 = new Henger();
            Console.WriteLine("Adja meg a kör sugarát!");
            henger1.setSugar();
            Console.WriteLine("Adja meg a henger magasságát!");
            henger1.Magasság();
            Console.WriteLine("A kör sugara: {0}", henger1.getSugar());
            Console.WriteLine("A kör kerülete: {0}", henger1.getTerület());
            Console.WriteLine("A henger magassága: {0}", henger1.getMagasság());
            Console.WriteLine("A henger térfogata: {0}", henger1.getTérfogat());
            Console.WriteLine("A henger alapterülete: {0}", henger1.getalapterület());
            Console.ReadKey();
        }
        }
    }

