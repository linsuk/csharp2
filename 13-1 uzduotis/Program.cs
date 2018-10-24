using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Didesnis yra " + p.KurisDidesnis(21, 21));
        }

        public int KurisDidesnis(int pirmas, int antras)
        {
            if (pirmas > antras)
            {
                return pirmas;
            }
            else if (antras > pirmas)
            {
                return antras;
            }
            else return pirmas;
        }
    }
}
