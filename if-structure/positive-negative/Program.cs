using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-structure - Task 1.\n");

            int a;
            while (true)
            {
                Console.Write("Anna luku: ");
                //a = Convert.ToInt32(Console.ReadLine());
                a = int.Parse(Console.ReadLine()); // näin
                if (a > 0)
                {
                    Console.WriteLine("Luku {0} on positiivinen.", a);
                }
                else if (a < 0)
                {
                    Console.WriteLine("Luku {0} on negatiivinen.", a);
                }
                else
                {
                    Console.WriteLine("Luku on nolla.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
