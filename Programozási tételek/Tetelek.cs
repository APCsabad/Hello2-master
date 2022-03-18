using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    class Tetelek
    {
        private int[] tomb;
        public Tetelek() {
            Console.WriteLine("Adja meg hány elem szerepeljen? A megadható érték nem lehet nagyobb, mint 200! Ha ennél nagyobbat ad meg, akkor a program meghatároz véletlen szerűen egy értéket 100 és 200 között.  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            if (a > 200)
            {
                a = random.Next(100, 200);
            }

            tomb = new int[a];

            for (int i = 0; i < a; i++)
            {
                tomb[i] = random.Next(-100, 100);              
            }
            
        }

        public int osszeg()
        {
            int tombossz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tombossz = tombossz + tomb[i];
            }

            return tombossz;
        }
        public int negativ()
        {
            int negativak = 0;
            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] < 0)
                {
                    negativak++;
                }
            }

            return negativak;
        }
        public bool osszehasonlitas()
        {
            Console.WriteLine("Adjon meg egy számot és a program megnézi hogy szerepel-e a tömbben.");
            int b = Convert.ToInt32(Console.ReadLine());
            bool van = false;
            
            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] == b)
                {
                    van = true;
                    break;
                }
            }

            return van;
        }


    }
}
