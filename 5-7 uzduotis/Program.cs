using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}", pirmas, antras);
            }
            else if (trecias > pirmas)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}", trecias, pirmas);
            }
            else if (pirmas == antras)
            {
                Console.WriteLine("Skaicius {0} yra lygus skaiciui {1}", pirmas, antras);
            }
            else if (antras == trecias)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}", antras, trecias);
            }
        }
    }
}
