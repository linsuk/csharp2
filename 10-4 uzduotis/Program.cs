using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai1 = {-1, 5, 6, 15, 24, 32, 69};
            int[] skaiciai2 = {5, 6, 9, 1, 32, 78, 99, 14, 0, -16};
            int[] skaiciai3 = {7, 8, 1, -2, 13, 77};

            Random rand = new Random();
            int indeksas1 = rand.Next(0, skaiciai1.Length);
            int indeksas2 = rand.Next(0, skaiciai2.Length);
            int indeksas3 = rand.Next(0, skaiciai3.Length);

            Console.WriteLine("Skaiciai {0}, {1}, {2}", skaiciai1[indeksas1], skaiciai2[indeksas2], skaiciai3[indeksas3]);

            if (skaiciai1[indeksas1] == skaiciai2[indeksas2] && skaiciai1[indeksas1] == skaiciai3[indeksas3])
            {
                Console.WriteLine("skaiciai {0}, {1} ir {2} yra lygus", skaiciai1[indeksas1], skaiciai2[indeksas2], skaiciai3[indeksas3]);
            }
            else if (skaiciai1[indeksas1] > skaiciai2[indeksas2] && skaiciai1[indeksas1] > skaiciai3[indeksas3])
            {
                Console.WriteLine("Skaicius {0} yra didziausias", skaiciai1[indeksas1]);
            }
            else if (skaiciai2[indeksas2] > skaiciai1[indeksas1] && skaiciai2[indeksas2] > skaiciai3[indeksas3])
            {
                Console.WriteLine("Skaicius {0} yra didziausias", skaiciai2[indeksas2]);
            }
            else Console.WriteLine("Skaicius {0} yra didziausias", skaiciai3[indeksas3]);

        }
    }
}
