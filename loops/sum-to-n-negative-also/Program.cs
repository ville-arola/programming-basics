using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_to_n_negative_also
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 4.\n");

            int n;
            string msg = string.Empty;
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            int sum = 0;
            int absmult = n < 0 ? -1 : 1;
            for (int i = 1; i <= n*absmult; i++)
            {
                sum += i*absmult;
            }
            msg = string.Format("{0}", sum);
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
