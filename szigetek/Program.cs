using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    class Program
    {
        static void Main(string[] args)
        {
            int szigetössz = 0;
            int szigethossz = 0;
            int i = 0;
            string szarazfold = "10011110010";


            while (i < szarazfold.Length);
            {
                if (szarazfold[i].Equals("1"))
                {
                    szigethossz++;
                }
                else
                {
                    Console.WriteLine(szigethossz);
                    szigethossz = 0;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
