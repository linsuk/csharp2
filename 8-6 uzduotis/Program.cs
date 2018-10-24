using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
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
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {

                Console.WriteLine("Klaida. Neteisingi reziai");
            }
        }
    }
}
