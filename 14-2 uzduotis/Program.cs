using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var knygynas = new Knygynas("Vaga", "Jonavos g. 7, Kaunas", new List<Knyga> {

                new Knyga("Balta drobule", "A. Skema", 300, "romanas", 19.90, 5),
                new Knyga("Knygute", "A. Autorius", 250, "fantastika", 9.90, 10),
                new Knyga("Ana Karenina", "L. Tolstojus", 300, "romanas", 10.0, 7),
                new Knyga("Nusikaltimas ir bausme", "F. Dostojevskis", 260, "romanas", 25.0, 5),
            });

            knygynas.Isvedimas();
            Console.WriteLine("----------------------------------------------");
            Console.Write("BENDRA APYVARTA: " + knygynas.BendraApyvarta());
            Console.WriteLine("----------------------------------------------");
            Console.Write("Storiausia knyga: " + knygynas.DidziausiaKnyga());
            Console.WriteLine();

        }
    }
}
