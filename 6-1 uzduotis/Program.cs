using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pradzia = 0;
            int pabaiga = 5;

            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk >= pradzia && sk <= pabaiga)
            {
                Console.WriteLine("Skaicius {0} telpa i rezius", sk);
            }
            else Console.WriteLine("Skaicius {0} netelpa i rezius", sk);

        }
    }
}
