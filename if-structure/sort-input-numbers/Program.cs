using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_input_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-structure - Task 4.\n");

            Console.Write("Syötä 1. luku: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Syötä 2. luku: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Syötä 3. luku: ");
            int c = Convert.ToInt32(Console.ReadLine());

            string output;

            if (a < b)
            {
                if (b < c)
                {
                    output = string.Format("{0}, {1}, {2}", a, b, c);
                }
                else if (a < c)
                {
                    output = string.Format("{0}, {1}, {2}", a, c, b);
                }
                else
                {
                    output = string.Format("{0}, {1}, {2}", c, a, b);
                }
            }
            else
            {
                if (a < c)
                {
                    output = string.Format("{0}, {1}, {2}", b, a, c);
                }
                else if (b < c)
                {
                    output = string.Format("{0}, {1}, {2}", b, c, a);
                }
                else
                {
                    output = string.Format("{0}, {1}, {2}", c, b, a);
                }
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
