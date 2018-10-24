using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk > 0 && sk % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra teigiamas ir lyginis", sk);
            }
            else Console.WriteLine("Skaicius {0} nelyginis arba neigiamas", sk);
        }
    }
}
