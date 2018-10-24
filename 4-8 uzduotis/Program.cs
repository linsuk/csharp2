using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite laispnius Celsijais: ");
            var laipsniai = Convert.ToDouble(Console.ReadLine());
            double kelvinai = laipsniai + 273.16;
            double fahrenheitai = 1.80 * laipsniai + 32;

            Console.WriteLine("{0}, {1}", kelvinai, fahrenheitai);
        }
    }
}
