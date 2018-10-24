using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p = new Program();
            var sugeneruoti = p.Generatorius();
            p.Isvedimas(sugeneruoti);
            
        }

        public List<int> Generatorius()
        {
            Random rand = new Random();

            var sarasas = new List<int>();
        
            for (int i = 0; i < 100; i++)
            {
                sarasas.Add(rand.Next(0, 100));
            }
            return sarasas;
        }

        public void Isvedimas(List<int> sarasas)
        {
            foreach (var skaicius in sarasas)
            {
                Console.Write("{0} ", skaicius);
            }
            Console.WriteLine();
        }
    }
}
