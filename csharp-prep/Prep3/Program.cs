using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write("What is the magic number? ");
        string guess = Console.ReadLine();

        int guessNumber = int.Parse(guess);

        while (guessNumber != number)
        {
            if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
        }
        Console.WriteLine("You guessed it!");
    }
}