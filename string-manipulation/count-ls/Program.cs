using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_ls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String manipulation - Task 3.\n");

            Console.Write("Syötä merkkijono: ");
            string input = Console.ReadLine().ToUpper();
            int count = 0;
            char c;
            for (int i=0; i<input.Length; i++)
            {
                c = input.ElementAt(i);
                if (c == 'L')
                {
                    count++;
                }
            }
            Console.WriteLine("Syötteessä {0} on {1} L-kirjainta.", input, count);
            Console.ReadKey();
        }
    }
}
