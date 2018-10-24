using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Pasisveikinimas();
        }

        public void Pasisveikinimas()
        {
            Console.Write("Iveskite savo varda: ");
            var vardas = Console.ReadLine();
 
            Console.WriteLine("Sveiki, " + vardas);
            Console.WriteLine();
        }
    }
}
