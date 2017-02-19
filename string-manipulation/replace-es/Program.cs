using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_es
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String manipulation - Task 2.\n");

            Console.Write("Syötä merkkijono: ");
            Console.WriteLine(Console.ReadLine().Replace('e', '@'));
            Console.ReadKey();
        }
    }
}
