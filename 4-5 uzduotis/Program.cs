using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda ir amziu");
            var vardas = Console.ReadLine();
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}, {1}", vardas, amzius);
        }
    }
}
