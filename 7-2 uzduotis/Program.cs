using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite role: vartotojas, moderatorius arba administratorius.");
            var role = Console.ReadLine();

            switch (role.ToLower())
            {
                case "vartotojas":
                    Console.WriteLine("Jusu role yra 'vartotojas'.");
                    break;
                case "moderatorius":
                    Console.WriteLine("Jusu role yra 'moderatorius'");
                    break;
                case "administratorius":
                    Console.WriteLine("Jusu role yra \"administratorius\".");
                    break;
                default:
                    Console.WriteLine("Tokios roles nera.");
                    break;
            }
        }
    }
}
