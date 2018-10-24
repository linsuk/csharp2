using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 7 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 7.", sk);
            }
            else
            {
                Console.WriteLine("Ivyko klaida");
            }
        }
    }
}
