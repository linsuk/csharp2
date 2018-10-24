using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 2 == 0)
            {
                Console.WriteLine("Dalinasi is 2");
            }
            else if (sk % 3 == 0)
            {
                Console.WriteLine("Dalinasi is 3");
            }
            else if (sk % 4 == 0)
            {
                Console.WriteLine("Dalinasi is 4");
            }
            else if (sk % 5 == 0)
            {
                Console.WriteLine("Dalinasi is 5");
            }
            else if (sk % 7 == 0)
            {
                Console.WriteLine("Dalinasi is 7");
            }
            else {
                Console.WriteLine("Klaida");
            }

        }
    }
}
