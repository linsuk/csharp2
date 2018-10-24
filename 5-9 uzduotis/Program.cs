using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk > 0)
            {
                Console.WriteLine("Saunuolis!");

            }
            else
            {
                Console.WriteLine("Ka tu cia ivedineji??!!");
            }
        }
    }
}
