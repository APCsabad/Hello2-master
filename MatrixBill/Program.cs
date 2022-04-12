using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    internal class Program
    {
        public static void kiir(int[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.WriteLine(tomb[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Adja meg hány soros legyen a mátrixa!");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány oszlopos legyen a mátrixa!");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            int[,] t = new int[sor, oszlop];
            double bekeres = 0;


            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.WriteLine("Adja meg a kovetkezo elemet ({0})",index++);
                    bekeres = Convert.ToDouble(Console.ReadLine());
                    t[i, j] = Convert.ToInt32(Math.Round(bekeres));
                }
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}