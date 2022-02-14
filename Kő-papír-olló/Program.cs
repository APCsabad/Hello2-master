using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kő_papír_olló
{
    class Program
    {
        static void Main(string[] args)
        {
            string folytatas = "igen";
            while (folytatas == "igen")
            {
                string[] tömb = { "kő", "papír", "olló" };
                Random random = new Random();
                int pc_random = random.Next(0, 3);
                string pc_választás = tömb[pc_random];

                string felhasznalo = Console.ReadLine();
                Console.WriteLine(pc_választás);

                if (pc_választás == "kő" && felhasznalo == "kő")
                {
                    Console.WriteLine("Döntetlen");
                }
                else if (pc_választás == "kő" && felhasznalo == "olló")
                {
                    Console.WriteLine("Vesztettél");
                }
                else if (pc_választás == "kő" && felhasznalo == "papír")
                {
                    Console.WriteLine("Nyertél");
                }
                else if (pc_választás == "papír" && felhasznalo == "papír")
                {
                    Console.WriteLine("Döntetlen");
                }
                else if (pc_választás == "kő" && felhasznalo == "papír")
                {
                    Console.WriteLine("Nyertél");
                }
                else if (pc_választás == "olló" && felhasznalo == "papír")
                {
                    Console.WriteLine("Vesztettél");
                }
                else if (pc_választás == "olló" && felhasznalo == "olló")
                {
                    Console.WriteLine("Döntetlen");
                }
                else if (pc_választás == "kő" && felhasznalo == "olló")
                {
                    Console.WriteLine("Vesztettél");
                }
                else if (pc_választás == "papír" && felhasznalo == "olló")
                {
                    Console.WriteLine("Nyertél");
                }
                Console.WriteLine("Akarsz -e még játszani?");
                folytatas = Console.ReadLine();
            }
        }
    }
}
