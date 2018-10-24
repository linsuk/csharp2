using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 15;
            var b = 7;
            var c = -8;
            var d = 1;

            double vidurkis = (a + b + c + d) / 4;
            Console.WriteLine("Skaiciu {0}, {1}, {2}, {3} vidurkis yra {4}", a,b,c,d, vidurkis);
        }
    }
}
