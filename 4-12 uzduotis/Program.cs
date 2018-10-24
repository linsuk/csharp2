using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu {0}, {1}, {2} kvadratai yra: {3}, {4}, {5}", a, b, c, Math.Pow(a, 2), Math.Pow(b, 2), Math.Pow(c, 2));
            Console.WriteLine("Skaiciu {0}, {1}, {2} kubai yra: {3}, {4}, {5}", a, b, c, Math.Pow(a,3), Math.Pow(b, 3), Math.Pow(c, 3));
            Console.WriteLine("Skaiciu {0}, {1}, {2} dalmuo is 2 yra: {3}, {4}, {5}", a, b, c, a / 2, b / 2, c / 2);
        }
    }
}
