using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziuMasyvas = new string[] { "Koloradas", "stalas", "automobilis", "suo", "orangutangas" };
            var p = new Program();
            Console.WriteLine(p.TrumpiausiasZodis(zodziuMasyvas));
        }

        public string TrumpiausiasZodis(string[] masyvas)
        {
            string minZodis = masyvas[0];

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i].Length < minZodis.Length)
                {
                    minZodis = masyvas[i];
                }
            }
            return minZodis;
        }
    }
}
