using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_14_papildoma_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu [1-4]:");
            var k = Convert.ToInt32(Console.ReadLine());

            if (k == 1 || k == 2)
            {
                Console.WriteLine("Pyragas patiks mamai ir dukrai");
            }
            else if (k == 3 || k == 4)
            {
                Console.WriteLine("Pyragas patiks teciui ir sunui");
            }
            else Console.WriteLine("Klaida pasirinkime");
        }
    }
}
