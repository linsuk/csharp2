using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.kurisDidesnis(11,7);
            p.kurisDidesnis(15, 9);
        }

        public void kurisDidesnis(int pirmas, int antras)
        {
            if (pirmas == antras)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus", pirmas, antras);
            }
            else if (pirmas > antras)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}", pirmas, antras);
            }
            else Console.WriteLine("Skaicius {0} yra didesnis uz {1}", antras, pirmas);
        }
    }
}
