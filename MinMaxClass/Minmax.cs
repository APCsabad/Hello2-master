using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxClass
{
    public class Minmax
    {
        public void minmax()
        {
            Random random = new Random();

            int[] arr = new int[Int32.MaxValue / 8];

             
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }


            int min = Int32.MaxValue;
            int min_i = -1;
            int max = Int32.MinValue;
            int max_i = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    min_i = i;
                }
                if (max < arr[i])
                {
                    max = arr[i];
                    max_i = i;
                }
            }

            Console.WriteLine("Min ertek: {0}, helye: {1}", min, min_i);
            Console.WriteLine("Max ertek: {0}, helye: {1}", max, max_i);


        }

    }
}
