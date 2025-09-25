using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? ");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);
        int guessCount = 0;

        while (true)
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            int guess = int.Parse(input);
            guessCount++;

            if (guess > magicNumber)
            {
                Console.Write("lower\n");
            }
            else if (guess < magicNumber)
            {
                Console.Write("higher\n");
            }
            else if (guess == magicNumber)
            {
                Console.Write($"You guessed it in {guessCount} guesses!");
                break;
            }
        }
    }
}