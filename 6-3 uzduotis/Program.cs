using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 2 == 0 || sk % 5 == 0 || sk % 7 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 2, 5 arba 7", sk);
            }
        }
    }
}
