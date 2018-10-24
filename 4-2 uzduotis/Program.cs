using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda: ");
            var vardas = Console.ReadLine();

            Console.WriteLine("Iveskite pavarde: ");
            var pavarde = Console.ReadLine();

            Console.WriteLine("Labas, {0} {1}", vardas, pavarde);
        }
    }
}
