using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(String pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }

        public void Isvedimas()
        {
            Console.WriteLine("INFORMACIJA APIE KNYGYNA");
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Turimu knygu sarasas: ");
            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }

            Console.WriteLine("Brangiausia kyga: ");
            BrangiausiaKnyga().Isvedimas();

        }

        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();

            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai > didziausia.Puslapiai)
                {
                    didziausia = knyga;
                }
            }
            return didziausia;
        }

        public double BendraApyvarta()
        {
            double bendraApyvarta = 0;

            foreach (var knyga in Knygos)
            {
                bendraApyvarta += knyga.Apyvarta();
            }

            return bendraApyvarta;
        }

        public Knyga BrangiausiaKnyga()
        {
            var brangiausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Kaina > brangiausia.Kaina)
                {
                    brangiausia = knyga;
                }
            }
            return brangiausia;
        }


    }
}
