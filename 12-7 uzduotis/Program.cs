using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Generatorius(5,2,10);

        }

        public void Generatorius(int kiek, int min, int max)
        {
            Random rand = new Random();
            Console.Write("Sugeneruoti skaiciai: ");
            for (int i = 0; i < kiek; i++)
            {
                Console.Write(rand.Next(min, max+1) + ", ");
            }
            Console.WriteLine();
        }
    }
}
