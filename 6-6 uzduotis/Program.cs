using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 pazymius:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int sk3 = Convert.ToInt32(Console.ReadLine());

            double vidurkis = (sk1 + sk2 + sk3) / 3;

            if (vidurkis >=8 && vidurkis <= 10)
            {
                Console.WriteLine("Vidurkis {0} papuola i [8;10]", vidurkis);
            }
            else if (vidurkis >= 5 && vidurkis <= 8)
            {
                Console.WriteLine("Vidurkis {0} papuola i [5;8]", vidurkis);
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("Vidurkis {0} mazesnis uz 5", vidurkis);
            }
        }
    }
}
