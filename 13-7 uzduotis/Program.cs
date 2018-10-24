using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciai = new int[] {0,15,21,47,89,63,65,11};
            p.Isvedimas(skaiciai);
            p.Skaiciavimai(skaiciai, 34,5);
        }

        public int grazintiMin(int[] masyvas)
        {
            return masyvas.Min();
        }

        public int grazintiMax(int[] masyvas)
        {
            return masyvas.Max();
        }
        public int grazintiSuma(int[] masyvas)
        {
            return masyvas.Sum();
        }
        public double SumaIrVidurkis(int suma, int kiekis)
        {
            return suma / kiekis;
        }

        public void Skaiciavimai(int[] masyvas, int suma, int kiekis)
        {
            Console.WriteLine("Maziausias masyvo elementas yra: " + grazintiMin(masyvas));
            Console.WriteLine("Didziausias masyvo elementas yra: " + grazintiMax(masyvas));
            Console.WriteLine("Masyvo elementu suma yra: " + grazintiSuma(masyvas));
            Console.WriteLine("{0} / {1} = {2}", suma, kiekis, SumaIrVidurkis(suma, kiekis));
        }

        public void Isvedimas(int[] masyvas)
        {
            Console.Write("Masyvo elementai: ");
            foreach (var skaicius in masyvas)
            {
                Console.Write(skaicius + " ");
            }
            Console.WriteLine();
        }
 
    }
}
