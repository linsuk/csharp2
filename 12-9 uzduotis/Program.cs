using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziuSarasas = new List<string> {"Koloradas", "stalas", "automobilis", "suo", "orangutangas"};
            p.IlgiausasZodis(zodziuSarasas);
        }

        public void IlgiausasZodis(List<string> sarasas)
        {
            var maxLength = sarasas[0].Length;
            string maxZodis = "";

            Console.Write("Zodziu sarasas: ");

            foreach (var zodis in sarasas)
            {
                if (zodis.Length > maxLength)
                {
                    maxLength = zodis.Length;
                    maxZodis = zodis;
                }
                Console.Write(zodis + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Trumpiausias zodis: " + maxZodis);
        }
    }
}
