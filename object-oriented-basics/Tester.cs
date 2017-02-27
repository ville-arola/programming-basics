using System;

namespace car
{
    public class Tester
    {
        static void Main(string[] args)
        {
            var testCar1 = new Car();
            var testCar2 = new Car("VW");
            var testCar3 = new Car("Toyota");

            Console.WriteLine("Autot ohjelman alussa:");
            Console.WriteLine(testCar1);
            Console.WriteLine(testCar2);
            Console.WriteLine(testCar3);

            Console.WriteLine("\nTestCar1 kiihdyttää 12 km/h ja jarruttaa.");
            testCar1.Accelerate(12);
            testCar1.Brake();

            Console.WriteLine("\nTestCar2 jarruttaa kaksi kertaa ja kiihdyttää 4,3 km/h.");
            testCar2.Brake();
            testCar2.Brake();
            testCar2.Accelerate(4.3f);

            Console.WriteLine("\nTestCar3 kiihdyttää 10 km/h ja jarruttaa.");
            testCar3.Accelerate(10);
            testCar3.Brake();

            Console.WriteLine("\nAutot ohjelman lopussa:");
            Console.WriteLine(testCar1.ToString());
            Console.WriteLine(testCar2.ToString());
            Console.WriteLine(testCar3.ToString());
            Console.ReadKey();
        }
    }
}
