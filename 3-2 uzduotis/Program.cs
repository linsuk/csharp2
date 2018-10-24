using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 1.5;
            var c = -15;

            var suma = a + b + c;
            var sandauga = a * b * c;

            Console.WriteLine("Suma yra: " + suma);
            Console.WriteLine("Skaiciaus {0}, {1} ir {2} sandauga yra {3}", a, b, c, sandauga);
        }
    }
}
