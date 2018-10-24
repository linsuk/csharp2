using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_15_papildoma_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmos dezutes matmenis:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antros dezutes matmenis:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            if (a1 < a2 || b1 < b2 || c1 < c2)
            {
                Console.WriteLine("Pirma dezute telpa antrojoje");
            }
            else if (a1 > a2 || b1 > b2 || c1 > c2)
            {
                Console.WriteLine("Antra dezute telpa pirmojoje");
            }
            else
                Console.WriteLine("Niekas niekur netelpa");
        }
    }
}
