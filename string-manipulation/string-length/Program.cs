using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String manipulation - Task 1.\n");

            Console.Write("Syötä merkkijono: ");
            Console.WriteLine("Syötteessä oli {0} merkkiä.", Console.ReadLine().Length);
            Console.ReadKey();
        }
    }
}
