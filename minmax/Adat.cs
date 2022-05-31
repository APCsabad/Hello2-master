using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax {
    public class Adat {
        private int[] numbers = new int[Int32.MaxValue/8];
        
        public Adat() {
            Console.WriteLine("Akarsz e megadni adatot? (Igen/Nem)");
            string user = Console.ReadLine();

            if (user.Equals("Igen") || user.Equals("igen")) {
                Console.WriteLine("Adja meg hany elemet akar bevinni");
                int number = Convert.ToInt32(Console.ReadLine());

                numbers = new int[number];
                setNumber(false);
            } else {
                setNumber(true);
            }
        }   

        public void setNumber(bool rand, int[] numbers = null) {
            if (!rand) {
                if(numbers != null) {
                    this.numbers = numbers;
                } else {
                    Console.WriteLine("Adja meg az elemeket!");
                    for (int i = 0; i<this.numbers.Length; i++) {
                        this.numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } else {
                Random random = new Random();
                //random elemek hozzaadasa a tombhoz
                for (int i = 0; i < this.numbers.Length; i++) {
                    this.numbers[i] = random.Next(Int32.MinValue / 2, Int32.MaxValue / 2);
                }
            }
        }
        

        public int min() {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < min) {
                    min = numbers[i];
                }
            }
            return min;
        }

        public int max() {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > max) {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
