using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());

            double vidurkis = (a + b + c + d + e) / 5;

            Console.WriteLine("Skaiciu {0}, {1}, {2}, {3}, {4} vidurkis yra {5}", a, b, c, d, e, vidurkis);

        }
    }
}
