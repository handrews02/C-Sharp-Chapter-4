using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            double testScore;

            Console.WriteLine("Enter your GPA>> ");
            GPA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your admission test score >> ");
            testScore = double.Parse(Console.ReadLine());

            if(GPA > 3.0 && testScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (GPA < 3.0 && testScore >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
