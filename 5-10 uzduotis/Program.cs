using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis.", sk);
            }
            else
            {
                Console.WriteLine("Skaicius {0} yra nelyginis.", sk);
            }
        }
    }
}
