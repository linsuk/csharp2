using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Sarasas();
        }

        public void Sarasas()
        {
            var sarasas = new List<string> {"Liepa", "Kovas", "Balandis", "Gruodis"};

            foreach (var zodis in sarasas)
            {
                Console.Write(zodis + " ");
            }
            Console.WriteLine();
        }
    }
}
