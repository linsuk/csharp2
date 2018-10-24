using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vardas: ");
            var vardas = Console.ReadLine();

            Console.Write("Pavarde: ");
            var pavarde = Console.ReadLine();

            Console.Write("Gruper kodas: ");
            var grupesKodas = Console.ReadLine();
            
            Console.Write("Aukstoji mokykla: ");
            var mokykla = Console.ReadLine();

            Console.WriteLine("Iveskite 3 pazymius: ");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            double vidurkis = (a + b + c) / 3;

            Console.WriteLine("Studento {0} {1}, studijuojancio {2} {3}, pazymiu vidurkis yra {4}.", vardas, pavarde, mokykla, grupesKodas, vidurkis);
        }
    }
}
