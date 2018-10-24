using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2 || sk1 == 0)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1} arba lygus 0.", sk1, sk2);
            }
            if (sk2 > sk1 || sk2 == 5)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1} arba lygus 5.", sk2, sk1);
            }
            if (sk1 > sk2 && sk1 == 20)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1} ir lygus 20.", sk1, sk2);
            }
            if (sk2 > sk1 && sk2 < 100)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1} ir mazesnis uz 100.", sk2, sk1);
            }

        }
    }
}
