using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus", a, b);
            }

            if (b == c)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus", b, c);
            }

            if (a > b)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1}", a, b);
            }

            if (b > c * 2)
            {
                Console.WriteLine("Skaicius {0} didesnis uz 2x {1}", b, c);
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", a);
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} yra nelyginis", b);
            }

            if (c > 0)
            {
                Console.WriteLine("Skaicius {0} yra teigiamas", c);
            }

            if (a < 0)
            {
                Console.WriteLine("Skaicius {0} yra neigiamas", a);
            }

            if (b % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 4", b);
            }

            if (c % 8 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 8", c);
            }
        }
    }
}
