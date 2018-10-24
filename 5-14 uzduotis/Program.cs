using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1}", sk1, sk2);
            }
            else if (sk1 < sk2)
            {
                Console.WriteLine("Skaicius {0} didesnis uz {1}", sk2, sk1);
            }
            else
            {
                Console.WriteLine("Skaiciai {0} ir {1} lygus", sk1, sk2);
            }

        }
    }
}
