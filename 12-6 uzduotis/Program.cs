using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Kiek skaiciu noretumet sugeneruoti?");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            p.Generatorius(kiekis);
            
        }

        public void Generatorius(int k)
        {
            Random rand = new Random();
            Console.Write("Sugeneruoti skaiciai: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(rand.Next(0,100) + " ");
            }
            Console.WriteLine();
            
        }
    }
}
