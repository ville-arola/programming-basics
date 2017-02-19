using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_tosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 9.\n");

            Random rnd = new Random();
            int n;
            Console.Write("Anna heittojen lukumäärä: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Virheellinen syöte.");
            }
            int nHeads = 0, nTails = 0;
            for (int i=0; i<n; i++)
            {
                if (rnd.Next(2)>0)
                {
                    nHeads++;
                }
                else
                {
                    nTails++;
                }
            }
            Console.WriteLine("Rahaa on heitetty {0} kertaa.", n);
            Console.WriteLine("Klaavoja tuli {0} ja kruunuja {1}.", nTails, nHeads);
            Console.ReadKey();
        }
    }
}
