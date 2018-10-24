using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            var suma = 0;
            for (int i = 1; i <=a; i++)
            {
                suma = suma + b;
            }
            Console.WriteLine(suma);
        }
    }
}
