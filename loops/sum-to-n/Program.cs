using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 2.\n");

            int n;
            string msg = string.Empty;
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            int sum = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                msg = string.Format("{0}", sum);
            }
            else
            {
                msg = string.Format("Lolwut?");
            }
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
