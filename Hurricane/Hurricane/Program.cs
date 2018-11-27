using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            double windSpeed;

            Console.WriteLine("What is the wind speed?");
            windSpeed = double.Parse(Console.ReadLine());

            if (windSpeed >= 157)
            {
                Console.WriteLine("This is a category 5 hurricane");
            }
            else if (windSpeed <= 157 && windSpeed >= 130)
            {
                Console.WriteLine("This is a category 4 hurricane");
            }
            else if (windSpeed <= 130 && windSpeed >= 111)
            {
                Console.WriteLine("This is a category 3 hurricane");
            }
            else if (windSpeed <= 111 && windSpeed > 96)
            {
                Console.WriteLine("This is a category 2 hurricane");
            }
            else if (windSpeed <= 96 && windSpeed > 74)
            {
                Console.WriteLine("This is a category 1 hurricane");
            }
            else
            {
                Console.WriteLine("This is NOT a hurricane");
            }
        }
    }
}
