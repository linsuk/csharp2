using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = { 1, 2, 6, 7, 98, 64, 14, 75, 36, 125 };
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write("[{0}] ", skaiciai[i]);
            }
            Console.WriteLine();
        }
    }
}
