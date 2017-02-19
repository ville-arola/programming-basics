using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_odd_and_even_negative_also
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 5.\n");

            int n;
            string msg = string.Empty;
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            int sumOdd = 0, sumEven = 0;
            int absmult = n < 0 ? -1 : 1;
            for (int i = 1; i <= n * absmult; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i * absmult;
                }
                else
                {
                    sumOdd += i * absmult;
                }
            }
            msg = string.Format("Parittomien summa: {0}, Parillisten summa: {1}", sumOdd, sumEven);
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
