using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DUOMENU SUVEDIMAS

            Console.WriteLine("Kiek dienu temperaturu norite suvesti?");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            int[] temperatura = new int[kiekis];

            Console.WriteLine("Pradekite vesti duomenis: ");
            for (int i = 0; i < temperatura.Length; i++)
            {
                var temp = Convert.ToInt32(Console.ReadLine());
                temperatura[i] = temp;
                Console.WriteLine("Ivedete {0}-os dienos temperatura.", i+1);
            }
            Console.WriteLine();

            // DUOMENU ISVEDIMAS

            Console.Write("Suvesti duomenys: ");
            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.Write("{0}, ", temperatura[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // SKAICIAVIMAI

            int suma = 0;
            int min = temperatura[kiekis-1];
            int max = 0;
            int maxDiena = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] < min)
                {
                    min = temperatura[i];
                }
                if (temperatura[i] > max)
                {
                    max = temperatura[i];
                    maxDiena = i;
                }
                suma += temperatura[i];
            }

            var vidurkis = suma / temperatura.Length;

            Console.WriteLine("Suvestu duomenu vidurkis: " + vidurkis);
            Console.WriteLine("Zemiausia temperatura: " + min);
            Console.WriteLine("{0} diena buvo auksciausia temperatura, ji sieke {1} laipsnius.", maxDiena+1, max);

            int dienos = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] < vidurkis)
                {
                    dienos++;
                }
            }
            Console.WriteLine("{0} dienos(-u) temperatura buvo zemesne uz vidurki {1}", dienos, vidurkis);

            //PIRMOS IR PASKUTINES DIENOS TEMPERATURU SKIRTUMAI

            if (temperatura[0] == temperatura[kiekis - 1])
            {
                Console.WriteLine("Pirmos ir paskutines dienos temperaturos buvo lygios");
            }
            else if (temperatura[0] > temperatura[kiekis-1])
            {
                Console.WriteLine("Pirmos dienos temperatura buvo {0} laipsniais aukstesne nei paskutines.", temperatura[0] - temperatura[kiekis-1]);
            }
            else
            {
                Console.WriteLine("Paskutines dienos temperatura buvo {0} laipsniais aukstesne nei pirmos.", temperatura[kiekis-1] - temperatura[0]);
            }

            // ATRINKIMAS I NAUJA MASYVA

            int[] temperatura2 = new int[kiekis];
            Console.Write("Naujas masyvas: ");

            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] - vidurkis == 1 || temperatura[i] - vidurkis == -1 || temperatura[i] == vidurkis)
                {
                    temperatura2[i] = temperatura[i];
                    Console.Write("{0}, ", temperatura2[i]);
                }
            }
            Console.WriteLine();

        }
    }
}
