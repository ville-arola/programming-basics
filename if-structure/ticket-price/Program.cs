using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_price
{
    class Program
    {
        private static int getNumber(string query)
        {
            int number = 0;
            bool result = false;
            while (!result)
            {
                Console.Write(query + ": ");
                result = int.TryParse(Console.ReadLine(), out number);
                if (!result)
                {
                    Console.WriteLine("Not a number");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("If-structure - Task 5.\n");

            float ticketPrice = 16.0f;
            int age, mtkMembership, militaryService, student;

            age = getNumber("Ostajan ikä");
            mtkMembership = getNumber("Mtk:n jäsenyys (1=kyllä, 0=ei)");
            militaryService = getNumber("Asepalveluksessa (1=kyllä, 0=ei)");
            student = getNumber("Opiskelija (1=kyllä, 0=ei)");

            if (age < 7)
            {
                ticketPrice = 0;
            }
            else if (age >= 65 || militaryService > 0 || (age >= 7 && age <= 15))
            {
                ticketPrice *= 0.5f;
            }
            else if (student > 0 && mtkMembership > 0)
            {
                ticketPrice *= 1 - (0.45f + 0.15f);
            }
            else if (student > 0)
            {
                ticketPrice *= 1 - 0.45f;
            }
            else if (mtkMembership > 0)
            {
                ticketPrice *= 1 - 0.15f;
            }

            Console.WriteLine("Alennettu hinta on {0}", ticketPrice);

            Console.ReadKey();
        }
    }
}
