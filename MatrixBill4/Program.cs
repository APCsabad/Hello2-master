using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sor = 0;
            int oszlop = 0;

            Console.WriteLine("Adja meg hány soros legyen a mátrixa");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány oszlopos legyen a mátrixa");
            oszlop = Convert.ToInt32(Console.ReadLine());
             
            int[,] mátrix = new int[sor, oszlop];
            Console.WriteLine("Írja be vesszővel elválasztva, hogy a maga által megadott sor, oszlop, milyen értéket adjon. Formátum: sorszám,oszlopszám,érték");
            string bekeres = Console.ReadLine();
            string[] beker = bekeres.Split(',');
            sor = Convert.ToInt32(beker[0]);
            oszlop = Convert.ToInt32(beker[1]);
            int ertek = Convert.ToInt32(beker[2]);
            string a = " ";

            while (a == "esc")
            {

            
            if (mátrix[sor, oszlop] == 0)
            {
                mátrix[sor, oszlop] = ertek;
            }
            else {
                Console.WriteLine("Ez a hely már foglalt.");

            }
            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                for (int j = 0; j < mátrix.GetLength(1); j++)
                {
                    Console.Write(mátrix[i, j]+ " ");

                }
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
