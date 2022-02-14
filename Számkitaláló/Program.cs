using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számkitaláló
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFelhasznalo = false;
            Console.WriteLine("Ki jatszik ha jatekos akkor 1");
            short ki_jatszik = Convert.ToInt16(Console.ReadLine());
            if(ki_jatszik == 1)
            {
                isFelhasznalo = true;
            }

            if (isFelhasznalo)
            {
                Console.WriteLine("adj meg egy szamot fiam");
                int user_random = Convert.ToInt32(Console.ReadLine());
                
                int rand_min = 1;
                int rand_max = 100;
                Random random = new Random();
                
                int pc_random = 0;
                while (user_random != pc_random)
                {
                    pc_random = random.Next(rand_min, rand_max);
                    Console.WriteLine("Pc tipp {0}", pc_random);
                    if (user_random > pc_random)
                    {
                        Console.WriteLine("Tul kicsi");
                        rand_min += 10;
                        if (rand_min > user_random)
                        {
                            rand_min = user_random;
                        }
                    }
                    else if (user_random < pc_random)
                    {
                        Console.WriteLine("Tul nagy");
                        rand_max -= 10;
                        if (rand_max < user_random)
                        {
                            rand_max = user_random;
                        }
                    }
                    else if (user_random == pc_random)
                    {
                        Console.WriteLine("Pc nyert");
                        break;
                    }
                }
             }
            else
            {
                Random random = new Random();
                int pc_random = random.Next(1, 100);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Tippeljél");
                    int tipp = Convert.ToInt32(Console.ReadLine());
                    if (tipp > pc_random)
                    {
                        Console.WriteLine("túl nagy fiam...");
                    }
                    else if (tipp == pc_random)
                    {
                        Console.WriteLine("szép meló");
                        Console.WriteLine(pc_random);
                        break;
                    }
                    else if (tipp < pc_random)
                    {
                        Console.WriteLine("kevés lesz fiam");
                    }

                    if(i == 4)
                    {
                        Console.WriteLine("Pc szam {0}",pc_random);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
