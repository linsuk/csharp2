using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Skaiciavimai(15,4);

        }

        public void Skaiciavimai(int pirmas, int antras)
        {
            Suma(pirmas, antras);
            Skirtumas(pirmas, antras);
            Daugyba(pirmas, antras);
            Dalyba(pirmas, antras);
            Console.WriteLine();
        }

        public void Suma(int pirmas, int antras)
        {
            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, pirmas + antras);
        }
        public void Skirtumas(int pirmas, int antras)
        {
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, pirmas - antras);
        }
        public void Daugyba(int pirmas, int antras)
        {
            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, pirmas * antras);
        }
        public void Dalyba(int pirmas, int antras)
        {
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, (Double) pirmas / antras);
        }

    }
}
