using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk < 0)
            {
                Console.WriteLine("Tai ka tu cia ivedineji??!!");
            }

            if (sk > 0)
            {
                Console.WriteLine("Saunuolis!");
            }

            if (sk % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", sk);
            }

            if (sk % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 4", sk);
            }

            if (sk > 10)
            {
                Console.WriteLine("Skaicius {0} didesnis uz 10", sk);
            }
        }
    }
}
