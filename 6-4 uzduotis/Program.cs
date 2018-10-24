using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 == sk2 && sk2 == sk3 && sk1 == sk3)
            {
                Console.WriteLine("Skaiciai lygus");
            }
            else if (sk2 >= sk1 && sk2 >= sk3)
            {
                Console.WriteLine("Skaicius {0} yra didziausias", sk2);
            }
            else if (sk3 >= sk1 && sk3 >= sk2)
            {
                Console.WriteLine("Skaicius {0} yra didziausias", sk3);
            }
            else if (sk1 >= sk2 && sk1 >= sk3)
            {
                Console.WriteLine("Skaicius {0} yra didziausias", sk1);
            }

        }
    }
}
