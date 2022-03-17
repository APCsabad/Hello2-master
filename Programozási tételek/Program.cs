using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg hány elem szerepeljen? A megadható érték nem lehet nagyobb, mint 200! Ha ennél nagyobbat ad meg, akkor a program meghatároz véletlen szerűen egy értéket 100 és 200 között.  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int negatívak = 0;
            if (a > 200) {
                a = random.Next(100, 200);
            }
            int[] tomb = new int[a];
            for (int i = 0; i < a; i++)
            {
                tomb[i] = random.Next(-100, 100);

                if (tomb[i] < 0) {
                    negatívak++;
                }
            }
            Console.ReadKey();

        }


        }
}

