using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziuSarasas1 = new List<string> { "Koloradas", "stalas", "automobilis", "suo", "orangutangas" };
            var zodziuSarasas2 = new List<string> { "Liepa", "Rugpjutis", "Rugsejis", "Sausis"};

            p.TrumpiausiasZodis(zodziuSarasas1);
            p.TrumpiausiasZodis(zodziuSarasas2);
        }

        public void TrumpiausiasZodis(List<string> sarasas)
        {
            var minLength = 100;
            string minZodis = "";

            foreach (var zodis in sarasas)
            {
                if (zodis.Length < minLength)
                {
                    minLength = zodis.Length;
                    minZodis = zodis;
                }
            }

            foreach (var zodis in sarasas)
            {
                if (zodis == minZodis)
                {
                    Console.WriteLine("--{0}--", zodis);
                }
                else Console.WriteLine(zodis + " ");
            }
            Console.WriteLine();
        }
    }
}
