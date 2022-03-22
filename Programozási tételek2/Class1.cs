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
        public Tetelek()
        {
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

        public int kivalasztas()
        {
            {
                Console.WriteLine("Adjon meg egy számot és a program megnézi hogy hanyadik helyen szerepel.");
                int b = Convert.ToInt32(Console.ReadLine());
                bool van = false;
                int index = 0;

                for (int i = 0; i < tomb.Length; i++)
                {

                    if (tomb[i] == b)
                    {
                        index = i;
                        van = true;
                        break;
                    }
                }


                return index;
            }
        }
        public int negativ()
        {
            Console.WriteLine("Adjon meg egy számot.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg egy relációs jelet.");
            string a = Console.ReadLine();
            tomb2 = new int[b];
            if (a == "<")
            {
                for (int i = 0; i < tomb.Length; i++)
                {

                    if (b < tomb[i])
                    {
                       tomb2 index = tombi
                            index++

                        tomb[b] = tomb[i]; b++; 

                    }
                }
            }



            return ;
        }

        public int osszehasonlitas()
        {
            Console.WriteLine("Adjon meg egy számot és a program megnézi hogy hanyadik helyen szerepel.");
            int b = Convert.ToInt32(Console.ReadLine());
            bool van = false;
            int index = 0;

            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] == b)
                {
                    index = i;
                    van = true;
                    break;
                }
            }

            
            return index;
        }


    }
}
