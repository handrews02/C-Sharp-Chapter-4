using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            string guessString;
            int min = 1;
            int max = 11;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Console.WriteLine("Enter a number between 1 and 10 >> ");
            guess = int.Parse(Console.ReadLine());

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == randomNumber)
            {
                Console.WriteLine("You win! You guessed " + randomNumber);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
