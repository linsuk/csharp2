using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var vidurkis = (a + b + c) / 3;

            Console.WriteLine("Ivestu skaiciu {0}, {1}, {2} vidurkis: {3}", a, b, c, Math.Round(vidurkis, 1));
        }
    }
}
