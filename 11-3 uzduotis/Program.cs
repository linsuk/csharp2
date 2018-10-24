using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Isvedimas();
        }
        public void Isvedimas()
        {
            Console.WriteLine("Kiek zodziu norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var sarasas = new List<string>();

            Console.WriteLine("Pradekite vesti");

            for (int i = 0; i < kiek; i++)
            {
                sarasas.Add(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Rezultatas:");

            foreach (var zodis in sarasas)
            {
                Console.WriteLine("-" + zodis);
            }

        }
    }
}
