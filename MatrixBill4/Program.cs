using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill4
{
    class Program
    {
        public static void kiir(int[,] tömb ) {
            for (int i = 0; i < tömb.GetLength(0); i++)
            {
                for (int j = 0; j < tömb.GetLength(1); j++)
                {
                    Console.Write(tömb[i, j] + " ");

                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int sor = 0;
            int oszlop = 0;
            string folytatas = "igen";
            
                Console.WriteLine("Adja meg hány soros legyen a mátrixa");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány oszlopos legyen a mátrixa");
            oszlop = Convert.ToInt32(Console.ReadLine());
             
            int[,] mátrix = new int[sor, oszlop];
            while (folytatas == "igen")
            {
                Console.WriteLine("Írja be vesszővel elválasztva, hogy a maga által megadott sor, oszlop, milyen értéket adjon. Formátum: sorszám,oszlopszám,érték");
            string bekeres = Console.ReadLine();
            string[] beker = bekeres.Split(',');
            sor = Convert.ToInt32(beker[0]);
            oszlop = Convert.ToInt32(beker[1]);
            int ertek = Convert.ToInt32(Math.Round(Convert.ToDouble(beker[2])));



                if (mátrix[sor, oszlop] == 0)
                {
                    mátrix[sor, oszlop] = ertek;
                }
                else
                {
                    Console.WriteLine("Ez a hely már foglalt.");

                }

                Console.WriteLine("Akarod emég folytatni?");
                folytatas = Console.ReadLine();

            }
                

            
            Console.ReadKey();
        }
    }
}
