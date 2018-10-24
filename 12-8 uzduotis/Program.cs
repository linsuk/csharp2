using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var sarasas1 = new List<int>{3,5,10,4,87,32,1};
            p.MaziausiasSkaicius(sarasas1);
        }

        public void MaziausiasSkaicius(List<int> sarasas)
        {

            int min = sarasas[0];
            foreach (var skaicius in sarasas)
            {
                Console.Write(skaicius + " ");
                if (skaicius < min)
                {
                    min = skaicius;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maziausias skaicius yra: " + min);
        }
    }
}
