using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String manipulation - Task 5.\n");

            Console.Write("Syötä merkkijono: ");
            string input = Console.ReadLine().ToUpper();
            string vowels = "AEIOUYÅÄÖ";
            int count = 0;
            for (int i=0; i<input.Length; i++)
            {
                if (!(vowels.IndexOf(input.ElementAt(i)) < 0))
                {
                    count++;
                }
            }
            Console.WriteLine("Sanassa {0} on {1} vokaalia.", input, count);
            Console.ReadKey();
        }
    }
}
