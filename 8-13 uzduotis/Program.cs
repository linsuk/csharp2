using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas = 1;
            int antras = 1;
            int suma = 0;

            Console.WriteLine("Iveskite norima kieki: ");
            var kiekis = Convert.ToInt32(Console.ReadLine());

            Console.Write(pirmas + " ");
            Console.Write(antras + " ");

            for (int i = 2; i < kiekis; i++)
            {
                suma = pirmas + antras;
                Console.Write(suma + " ");
                pirmas = antras;
                antras = suma;
            }

        }
    }
}
