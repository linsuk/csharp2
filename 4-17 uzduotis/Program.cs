using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            // PIRMO AUTOMOBILIO DUOEMNYS
            Console.WriteLine("IVESKITE PIRMOJO AUTOMOBILIO DUOMENIS");
            Console.Write("Marke: ");
            var marke1 = Console.ReadLine();

            Console.Write("Modelis: ");
            var modelis1 = Console.ReadLine();

            Console.Write("Gamybos metai: ");
            var metai1 = Console.ReadLine();

            Console.Write("Darbinis turis: ");
            var turis1 = Console.ReadLine();

            Console.Write("Rida: ");
            var rida1 = Console.ReadLine();

            Console.Write("Ar galioja technine apziura? (true/false): ");
            var tech1 = Convert.ToBoolean(Console.ReadLine());

            // ANTRO AUTOMOBILIO DUOEMNYS
            Console.WriteLine("IVESKITE ANTROJO AUTOMOBILIO DUOMENIS");
            Console.Write("Marke: ");
            var marke2 = Console.ReadLine();

            Console.Write("Modelis: ");
            var modelis2 = Console.ReadLine();

            Console.Write("Gamybos metai: ");
            var metai2 = Console.ReadLine();

            Console.Write("Darbinis turis: ");
            var turis2 = Console.ReadLine();

            Console.Write("Rida: ");
            var rida2 = Console.ReadLine();

            Console.Write("Ar galioja technine apziura? (true/false): ");
            bool tech2 = Convert.ToBoolean(Console.ReadLine());
            

            // DUOMENU ISVEDIMAS

            Console.WriteLine("+-------+------------+------------------+--------------+-------------+--------------+");
            Console.WriteLine("| Marke | Modelis    | Gambybos metai   | Darb. turis  | Rida        |Technine apz. |");
            Console.WriteLine("+-------+------------+------------------+--------------+-------------+--------------+");
            Console.WriteLine("|{0,7}|{1,12}|{2,18}|{3,14}|{4,13}|{5,14}|", marke1, modelis1, metai1, turis1, rida1, tech1);
            Console.WriteLine("+-------+------------+------------------+--------------+-------------+--------------+");
            Console.WriteLine("|{0,7}|{1,12}|{2,18}|{3,14}|{4,13}|{5,14}|", marke2, modelis2, metai2, turis2, rida2, tech2);
            Console.WriteLine("+-------+------------+------------------+--------------+-------------+--------------+");
        }
    }
}
