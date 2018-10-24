using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite gerima:\n1 - vanduo\n2 - limonadas\n3 - arbata\n4 - kava");
            var k = Convert.ToInt32(Console.ReadLine());

            switch (k)
            {
                case 1: 
                    Console.WriteLine("Jus pasirinkote vandeni.");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote limonada.");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote arbata.");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava.");
                    break;

                default:
                    Console.WriteLine("Blogas pasirinkimas.");
                    break;
            }
        }
    }
}
