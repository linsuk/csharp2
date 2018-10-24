using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.asmensDuomenys("Jonas", "Jonauskas",33,"stalius");
            p.asmensDuomenys("Birute", "Petrauskaite", 19, "padaveja");
        }

        public void asmensDuomenys(string vardas, string pavarde, int amzius, string profesija)
        {
            Console.WriteLine("{0} {1} {2} m. amziaus yra {3}.", vardas,pavarde, amzius, profesija);
        }
    }
}
