using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var sk = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk > sk2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz skaiciu {1}", sk, sk2);
            }
            else
            {

            }
        }
    }
}
