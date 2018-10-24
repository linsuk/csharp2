using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciaus {0} kvadratas yra {1}", skaicius, arg1: Math.Pow(skaicius,2));

        }
    }
}
