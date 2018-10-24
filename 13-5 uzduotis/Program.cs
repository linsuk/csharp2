using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.grazintiBetKuri(15,25,36));
        }

        public int grazintiBetKuri(int pirmas, int antras, int trecias)
        {
            Random rand = new Random();

            var sarasiukas = new int[]{pirmas, antras, trecias};

            return sarasiukas[rand.Next(0, 3)];
        }
    }
}
