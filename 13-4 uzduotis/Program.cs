using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new string[] {"Liepa", "Vasaris", "Rugpjutis", "Sausis", "Kovas"};
            Console.WriteLine(p.sujungtiZodzius(zodziai));
        }

        public string sujungtiZodzius(string[] masyvas)
        {
            string eilute = "";
            for (int i = 0; i < masyvas.Length; i++)
            {
                eilute += masyvas[i];
            }
            return eilute;
        }
    }
}
