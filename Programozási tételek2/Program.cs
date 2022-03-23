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
            Tetelek tetel = new Tetelek();

            Console.WriteLine(tetel.kivalasztas());
            //tetel.kivalogatas(); 
            tetel.szetvalogatas();
            //tetel.osszehasonlitas();
            Console.ReadKey();
            

        }


    }
}

