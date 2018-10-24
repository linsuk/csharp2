using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int skaicius = 0;

            while (skaicius < 1000)
            {
                if (skaicius % 3 == 0 || skaicius % 5 == 0)
                {
                    suma += skaicius;
                }
                skaicius++;
            }
            Console.WriteLine(suma);
        }
    }
}
