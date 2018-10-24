using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Isvedimas("Labas");
            p.Isvedimas("vakaras");
            p.Isvedimas("ponios");
            p.Isvedimas("ir");
            p.Isvedimas("ponai");
        }

        public void Isvedimas(string zodis){
            Console.WriteLine("--{0}--", zodis);
        }
    }
}
