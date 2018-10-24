using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 15;
            var b = 77;
            var suma = a + b;
            var skirtumas = a - b;

            Console.WriteLine("Sumos {0} ir skirtumo {1} sandauga yra {2}", suma, skirtumas, suma*skirtumas);
            Console.WriteLine("Sumos {0} ir skirtumo {1} dalmuo yra {2}", suma, skirtumas, (double)suma / skirtumas);

        }
    }
}
