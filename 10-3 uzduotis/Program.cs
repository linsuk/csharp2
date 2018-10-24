using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai1 = {"Jonas", "Petras", "Algis", "Audrius"};
            string[] vardai2 = { "Birute", "Angele", "Agota", "Beata", "Maryte"};

            Console.WriteLine(vardai1[0]);
            Console.WriteLine(vardai2[vardai2.Length-1]);

        }
    }
}
