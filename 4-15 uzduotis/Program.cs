using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vardas: ");
            var vardas = Console.ReadLine();

            Console.Write("Pavarde: ");
            var pavarde = Console.ReadLine();

            Console.Write("Gimimo metai: ");
            var metai = Convert.ToInt32(Console.ReadLine());
            var amzius = 2018 - metai;

            Console.Write("Kuo dirba: ");
            var specialybe = Console.ReadLine();

            Console.Write("Etatas: ");
            var etatas = Console.ReadLine();

            Console.Write("Gaunama alga: ");
            var alga = Console.ReadLine();

            Console.WriteLine("{0} {1} ({2} m.) dirba {3} {4} etatu ir uzdirba {5} eur/men.", vardas, pavarde, amzius, specialybe, etatas, alga);
        }
    }
}
