using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 5 == 0)
            {
                Console.WriteLine("{0} * 1 = {1}", sk, sk * 1);
                Console.WriteLine("{0} * 2 = {1}", sk, sk * 2);
                Console.WriteLine("{0} * 3 = {1}", sk, sk * 3);
                Console.WriteLine("{0} * 4 = {1}", sk, sk * 4);
                Console.WriteLine("{0} * 5 = {1}", sk, sk * 5);
            }

            if (sk % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis. Jo 5-as laipsnis yra {1}", sk, Math.Pow(sk,5));
            }

            if (sk % 4 != 0)
            {
                Console.WriteLine("Iveskite dar viena skaiciu:");
                var sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skaiciaus {0} ir {1} suma yra {2}, sandauga {3}", sk, sk2, sk+sk2, sk*sk2);
            }
        }
    }
}
