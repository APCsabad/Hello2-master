using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listakezeles
{
    class Lista
    {
        private string db;
        private List<string> varos = new List<string>();
        public string setDB()
        {
            Console.WriteLine("Mennyi várost akarsz eltárolni? ha 0-t írsz be akkor addig tudsz várost beírni míg nem írsz be semmit. ");
            db = Console.ReadLine();
            return db;

        }
        public void setNev() {
            string darab = setDB();
                if (db == "" || db=="0")
                {

                    while (true)
                    {
                        Console.WriteLine("Adja meg a város nevét amit be akar írni a listába!");
                        string input = Console.ReadLine();
                        if (input == "")
                        {
                            break;
                        }
                        varos.Add(input);
                    }
                }else
                    {
                        int num = Convert.ToInt32(db);
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Adja meg a város nevét amit be akar írni a listába!");
                            string input = Console.ReadLine();
                            varos.Add(input);
                        }
                    }
                }              
       
       public void getNevek() {

            for (int i = 0; i < varos.Count; i++) {

                Console.WriteLine(varos[i]+",");
            }
            
              
        }
        public void getVan() {
            Console.WriteLine("Adjon meg egy nevet és a program negnézi hogy benne van-e a listában!");
            string b = Console.ReadLine();
            for (int i = 0; i < varos.Count; i++)
            {
                if (varos[i] == b)
                {
                    Console.WriteLine("van");
                    break;
                }
                
            }

        }
        public void delNev() {
            Console.WriteLine("Adja meg mit szeretne törölni.");
            string c = Console.ReadLine();
            if (varos.Contains(c))
            {
                varos.Remove(c);
            }
            else {
                varos.Add(c);
            }
        
        }
        public void delLast() {
  
            varos.RemoveAt(varos.Count - 1);
        }
    }
}

