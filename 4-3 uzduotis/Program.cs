using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite duomenis apie gyvuna");

            Console.Write("Pavadinimas: ");
            string pavadinimas = Console.ReadLine();

            Console.Write("Seima, kuriai priklauso: ");
            string seima = Console.ReadLine();

            Console.Write("Regionas, kuriame galima sutikti: ");
            string regionas = Console.ReadLine();

            Console.WriteLine("Gyvunas {0} priklauso {1} seimai ir yra randamas {2}", pavadinimas, seima, regionas);
        }
    }
}
