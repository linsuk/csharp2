using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 37;
            var pirmasSkaitmuo = skaicius / 10;
            var antrasSkaitmuo = skaicius % 10;

            Console.WriteLine("{0} -> {1} + {2} = {3}", skaicius, pirmasSkaitmuo, antrasSkaitmuo, pirmasSkaitmuo + antrasSkaitmuo);
        }
    }
}
