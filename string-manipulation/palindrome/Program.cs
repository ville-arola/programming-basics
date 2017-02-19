using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String manipulation - Task 4.\n");

            Console.Write("Syötä merkkijono: ");
            string tmp, input = Console.ReadLine();
            tmp = Regex.Replace(input, @" ", "").ToLower();
            int splitLen = (int) decimal.Ceiling((tmp.Length-1)/2)+1;
            string endHalfReversed = new string(tmp.Substring(splitLen).ToCharArray().Reverse().ToArray());
            if (tmp.StartsWith(endHalfReversed))
            {
                Console.WriteLine("Sana {0} on palindromi", input.ToUpper());
            }
            else
            {
                Console.WriteLine("Sana {0} ei ole palindromi", input.ToUpper());
            }
            Console.ReadKey();
        }
    }
}
