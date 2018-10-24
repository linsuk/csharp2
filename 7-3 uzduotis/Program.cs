using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    if (a == 1)
                    {
                        var suma = a + b + c;
                        Console.WriteLine("Suma {0}", suma);
                    }
                    break;
                case 2:
                    if (a == 2)
                    {
                        var sandauga = b * c;
                        Console.WriteLine("Sandauga {0}", sandauga);
                    }
                    break;
                case 3:
                    if (a == 3)
                    {
                        var kvadratas = Math.Pow(a,2);
                        Console.WriteLine("Kvadratas {0}", kvadratas);
                    }
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }

        }
    }
}
