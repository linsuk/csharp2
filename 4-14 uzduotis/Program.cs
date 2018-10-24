using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norima simboli:");
            var simbolis = Console.Read();

            Console.WriteLine("  {0} ", (char)simbolis);
            Console.WriteLine(" {0}{0}{0}", (char)simbolis);
            Console.WriteLine("{0}{0}{0}{0}{0}", (char)simbolis);
        }
    }
}
