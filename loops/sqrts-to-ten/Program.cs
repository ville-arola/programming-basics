using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqrts_to_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 6.\n");

            Console.WriteLine("Luku\tNeliöjuuri");
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0}\t{1:0.00}", i, Math.Sqrt(i));
            }
            Console.ReadKey();
        }
    }
}
