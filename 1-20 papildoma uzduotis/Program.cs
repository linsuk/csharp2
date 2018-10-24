using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_20_papildoma_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite trizenkli skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            var sk1 = skaicius / 100;
            var sk2 = (skaicius / 10) % 10;
            var sk3 = skaicius % 10;

            Console.WriteLine("{0},{1},{2}",sk1, sk2,sk3);
            if (Math.Pow(sk1, 3) + Math.Pow(sk2, 3) + Math.Pow(sk3, 3) == skaicius)
            {
                Console.WriteLine("Skaicius {0} yra Amstrongo", skaicius);
            }
            else {
                Console.WriteLine("Skaicius {0} nera Amstrongo", skaicius);
            }
        }
    }
}
