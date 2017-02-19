using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_from_range
{
    class Program
    {
        static int pyyda_luku_valilta(int a, int b)
        {
            int n;
            bool res = false;
            do
            {
                Console.Write("Anna luku väliltä {0}-{1}: ", a, b);
                res = int.TryParse(Console.ReadLine(), out n);
            } while (!res || n < a || n > b);
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 3.\n");

            Console.WriteLine("Syötit luvun {0}", pyyda_luku_valilta(-2,6));
            Console.ReadKey();
        }
    }
}
