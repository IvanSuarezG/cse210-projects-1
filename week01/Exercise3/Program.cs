using System;

class Program
{
    static void Main(string[] args)
    {
        string tryAgain;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int attempts = 0;
            int guess = -1;

            Console.WriteLine("Guess the magic number between 1 and 100!");

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Attempts: {attempts}");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            tryAgain = Console.ReadLine();

        } while (tryAgain == "yes");

        Console.WriteLine("End Program!");
    }
}