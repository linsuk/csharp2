using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pavadinimas = "lokys";
            var amzius = 3;
            var kailioSpalva = "ruda";
            var svoris = 780; //kg

            Console.WriteLine("Gyvunas - " + pavadinimas + " (" + amzius + "m.) " + "turi " + kailioSpalva + " kaili ir sveria " + svoris + " kg.");
        }
    }
}
