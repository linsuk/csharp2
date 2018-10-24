using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 21;
            int k = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    k++;
                }
               
            }

            if (k == 2)
            {
                Console.WriteLine("Pirminis");
            }

            else Console.WriteLine("Nera pirminis");

        }
    }
}
