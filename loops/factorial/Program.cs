using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Task 1.\n");

            int n;
            string msg = string.Empty;
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            if (!(n < 0))
            {
                ulong factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= (ulong) i;
                }
                msg = string.Format("{0}", factorial);
            }
            else
            {
                msg = string.Format("Määrittelemätön");
            }
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
