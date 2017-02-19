using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_positive_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-structure - Task 3.\n");

            string message = string.Empty;
            int number = 0;
            Console.Write("Give a number: ");
            while (true)
            {
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (!result)
                {
                    message = "Not a number";
                }
                message = string.Format("Number {0} is ", number);

                if (number < 0)
                {
                    message += "Negative and ";
                }
                else if (number > 0)
                {
                    message += "Positive and ";
                }
                else
                {
                    Console.WriteLine("Number is zero.");
                    break;
                }

                if (number % 2 == 0)
                {
                    message += "Even.";
                }
                else
                {
                    message += "Odd.";
                }

                // Same with ternary operator.
                //message = string.Format("Number {0} is {1} and {2}.", number, (number>0) ? "Positive" : (number<0) ? "Negative" : "Zero", (number%2==0) ? "Even" : "Odd");

                Console.WriteLine(message);
            }
        }
    }
}
