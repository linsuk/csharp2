using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pazymi");
            var paz = Convert.ToInt32(Console.ReadLine());
 
            if (paz == 10)
            {
                Console.WriteLine("Puiku");
            }
            else if (paz >= 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (paz >= 7)
            {
                Console.WriteLine("Gerai");
            }
            else if (paz >= 5)
            {
                Console.WriteLine("Patenkinamas");
            }
            else if (paz < 5)
            {
                Console.WriteLine("Egzaminas neislaikytas");
            }
        }
    }
}
