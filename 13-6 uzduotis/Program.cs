using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciuMasyvas = new int[] {15,3,65,74,8,96,24,6,3};
            Console.WriteLine(p.grazintiDidziausia(skaiciuMasyvas));
        }

        public int grazintiDidziausia(int[] masyvas)
        {
            int max = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                }
            }
            return max;
        }
    }
}
