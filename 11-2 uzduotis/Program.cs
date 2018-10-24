using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Policininkas();
        }

        public void Policininkas()
        {
            var vardas = "Algis";
            var pavarde = "Algiauskas";
            var amzius = 33;
            var alga = 900;
            var etatas = 0.5;
            var specializacija = "Patrulis";

            Console.WriteLine("POLICININKO DUOMENYS");
            Console.WriteLine("--------------------");
            Console.WriteLine("Vardas: " + vardas);
            Console.WriteLine("Pavarde: " + pavarde);
            Console.WriteLine("Amzius: " + amzius);
            Console.WriteLine("Alga: " + alga);
            Console.WriteLine("Etatas: " + etatas);
            Console.WriteLine("Specializacija: " + specializacija);
        }
    }
}
