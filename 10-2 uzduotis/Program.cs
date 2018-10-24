using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = { "Jonas", "Antanas", "Juozas", "Agne", "Ruta", "Marius", "Mantas"};
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int indeksas = rand.Next(0,vardai.Length);
                Console.WriteLine("Vardas {0} su indeksu {1}", vardai[indeksas], indeksas);
            }


        }
    }
}
