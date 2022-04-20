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


        }
    }
}
