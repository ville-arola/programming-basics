using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-structure - Task 2.\n");

            while (true)
            {
                string message = string.Empty;
                int number = 0;
                Console.Write("Give a number: ");
                bool result = int.TryParse(Console.ReadLine(), out number);

                if (!result)
                {
                    message = "not a number";
                    break;
                }

                else if (number % 2 == 0)
                {
                    message = string.Format("number {0} is even", number);
                }
                else
                {
                    message = string.Format("number {0} is odd", number);
                }
                Console.WriteLine(message);
            }
        }
    }
}
