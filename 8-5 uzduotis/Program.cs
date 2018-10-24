using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite reziu pradzia: ");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite reziu pabaiga: ");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    Console.WriteLine("{0} {1}", i, Math.Pow(i, 2));
                }
            }
            else {

                Console.WriteLine("Klaida. Neteisingi reziai");
            }
            
        }
    }
}
