using System;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 15;
            var b = 77;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
        }
    }
}
