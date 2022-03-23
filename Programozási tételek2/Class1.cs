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
        private int a;
        public Tetelek()
        {
            Console.WriteLine("Adja meg hány elem szerepeljen? A megadható érték nem lehet nagyobb, mint 200! Ha ennél nagyobbat ad meg, akkor a program meghatároz véletlen szerűen egy értéket 100 és 200 között.  ");
            a = Convert.ToInt32(Console.ReadLine());
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
        public void kivalogatas()
        {
            Console.WriteLine("Adjon meg egy számot.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg egy relációs jelet.");
            string a = Console.ReadLine();


            if (a == "<")
            {
                for (int i = 0; i < tomb.Length; i++)
                {

                    if (b < tomb[i])
                    {
                        Console.WriteLine(tomb[i]);
                    }
                }
            }
            if (a == ">")
            {
                for (int i = 0; i < tomb.Length; i++)
                {

                    if (b > tomb[i])
                    {
                        Console.WriteLine(tomb[i]);
                    }
                }
            }
            if (a == "=")
            {
                for (int i = 0; i < tomb.Length; i++)
                {

                    if (b == tomb[i])
                    {
                        Console.WriteLine(tomb[i]);
                    }
                }
            }
        }

        public void szetvalogatas()
        {
            Console.WriteLine("Adjon meg egy számot.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg egy relációs jelet.");
            string jel = Console.ReadLine();
            int[] tomb1 = new int[a]; //nagyobb elemek
            int[] tomb2 = new int[a]; //kisebb elemek
            int tomb1_i = 0, tomb2_i = 0;


            if (jel == "<")
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (b < tomb[i])
                    {
                        tomb1[tomb1_i++] = tomb[i];
                    }
                    else
                    {
                        tomb2[tomb2_i++] = tomb[i];
                    }
                }
            }
            Console.WriteLine("A megadott relációs jel és szám alapján ezek a számok nagyobbak mint a szám:");

            for (int i = 0; i < tomb1.Length; i++)
            {
                Console.WriteLine(tomb1[i]);
            }
           
            Console.WriteLine("A megadott relációs jel és szám alapján ezek a számok kisebbek mint a szám:");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine(tomb2[i]);
            }
        }
        public void osszehasonlitas()
        {
            Console.WriteLine("Adjon meg egy számot és a program megnézi, hogy benne van e a tömbbe és hogy hanyadik helyen szerepel.");
            int b = Convert.ToInt32(Console.ReadLine());
            bool van = false;
            int index = 0;

            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] == b)
                {
                    index = i;
                    van = true;
                    Console.WriteLine("A szám szerepel a tömbben és a {0}. helyen szerepel.", index);
                    break;
                }
            }

            
            
        }


    }
}
