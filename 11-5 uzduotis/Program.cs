using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Program.Lentele();
        }

        public static void Lentele()
        {
            Random rand = new Random();
            var a = rand.Next(0,10);
            var b = rand.Next(0, 10);
            var c = rand.Next(0, 10);
            var d = rand.Next(0, 10);
            var e = rand.Next(0, 10);
            var f = rand.Next(0, 10);

            Console.WriteLine("{0} {1} {2}", a, b, a+b);
            Console.WriteLine("{0} {1} {2}", c, d, c + d);
            Console.WriteLine("{0} {1} {2}", e, f, e + f);



        }
    }
}
