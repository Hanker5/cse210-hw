using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your favorite first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your favorite last name? ");
        string last_name = Console.ReadLine();

        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");
    }
}