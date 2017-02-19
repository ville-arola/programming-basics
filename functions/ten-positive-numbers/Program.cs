using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_positive_numbers
{
    class Program
    {
        static int tenPositiveIntegers()
        {
            int n, i, largest=0, largest_index=0;
            bool res;
            string numbers = string.Empty;
            Console.WriteLine("Syötä 10 lukua");
            for (i=0; i<10; i++)
            {
                while (true)
                {
                    Console.Write("{0}. ", i+1);
                    res = int.TryParse(Console.ReadLine(), out n);
                    if (res && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                    }
                }
                if (n > largest)
                {
                    largest = n;
                    largest_index = i+1;
                }
                numbers += string.Format("{0} ", n);
            }
            Console.WriteLine("Syötit seuraavat luvut");
            Console.WriteLine(numbers);
            Console.WriteLine("Suurin {0} oli {1}. luku", largest, largest_index);
            return largest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 4.\n");

            tenPositiveIntegers();
            Console.ReadKey();
        }
    }
}
