using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        class Lektuvas
        {
            public int SparnuIlgis;
            public string Pavadinimas;
            public int Vietos;
            public string Tipas;
            public int VarikliuSkaicius;
            public string VariklioTipas;


            public Lektuvas(){}

            public Lektuvas(int sparnuIlgis, string pavadinimas, int vietos, string tipas, int varikliuSkaicius, string variklioTipas)
            {
                SparnuIlgis = sparnuIlgis;
                Pavadinimas = pavadinimas;
                Vietos = vietos;
                VariklioTipas = variklioTipas;
                VarikliuSkaicius = varikliuSkaicius;
                Tipas = tipas;
 
            }


            public void Isvedimas()
            {
                Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnu ilgis yra {2}", Pavadinimas, Vietos, SparnuIlgis);
                Console.WriteLine("Jis priskiriamas {0} tipui, turi {1} {2} tipo variklius.", Tipas, VariklioTipas, VarikliuSkaicius);
                Console.WriteLine();
            }
            public double SparnoIlgis()
            {
                return SparnuIlgis / 2;
            }
        }

        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas();
            var lektuvas3 = new Lektuvas(600, "Kukuruznikas", 800, "ukinis", 1, "standartinis");

            lektuvas1.SparnuIlgis = 500;
            lektuvas1.Pavadinimas = "Boeying";
            lektuvas1.Vietos = 600;
            lektuvas1.Tipas = "Tarpatlantinis";
            lektuvas1.VarikliuSkaicius = 2;
            lektuvas1.VariklioTipas = "Turbo";

            lektuvas2.SparnuIlgis = 400;
            lektuvas2.Pavadinimas = "A380";
            lektuvas2.Vietos = 500;
            lektuvas2.Tipas = "Reaktyvinis";
            lektuvas2.VarikliuSkaicius = 4;
            lektuvas2.VariklioTipas = "Super Mega Turbo";

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();
            lektuvas3.Isvedimas();

            Console.WriteLine("Lektuvo {0} vieno sparno ilgis yra: {1}", lektuvas1.Pavadinimas, lektuvas1.SparnoIlgis());
 
        }
    }
}
