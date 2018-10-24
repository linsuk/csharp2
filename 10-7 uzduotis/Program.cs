using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[10];
            Random rand = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {
                int elementas = rand.Next(0,100);
                skaiciai[i] = elementas;
                Console.WriteLine("Indekse {0} yra {1}", i, skaiciai[i]);
            }


        }
    }
}
