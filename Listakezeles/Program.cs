using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listakezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.setNev();
            lista.getNevek();
            lista.getVan();
            lista.delNev();
            Console.ReadKey();
        }
    }
}
