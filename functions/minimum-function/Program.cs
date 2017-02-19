using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_function
{
    class Program
    {
        static int minimi(int a, int b)
        {
            return a < b ? a : b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 2.\n");

            int a, b;
            Console.Write("Anna luku: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Anna toinen luku: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Minimi: {0}", minimi(a, b));
            Console.ReadKey();
        }
    }
}
