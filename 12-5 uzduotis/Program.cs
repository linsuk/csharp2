using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.StudentoInformacija("Jonas", "Jonaitis","IFM-4/1", 7,9,10);
        }

        public void Informacija(string vardas, string pavarde, string grupe)
        {
            Console.WriteLine("Studentas {0} {1} mokosi {2} grupeje.", vardas, pavarde,grupe);
        }

        public void Vidurkis(int a, int b, int c)
        {
            double vidurkis = (a + b + c) / 3;
            Console.WriteLine("Vidurkis yra: " + Math.Round(vidurkis,2));
        }

        public void StudentoInformacija(string vardas, string pavarde, string grupe, int a, int b, int c)
        {
            Informacija(vardas, pavarde, grupe);
            Vidurkis(a, b, c);
        }
    }
}
