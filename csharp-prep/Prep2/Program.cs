using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            // A
            Console.WriteLine("Your grade is an A!");
        }
        else if (grade >= 80)
        {
            //B
            Console.WriteLine("Your grade is a B!");
        }
        else if (grade >= 70)
        {
            //C
            Console.WriteLine("Your grade is a C!");
        }
        else if (grade >= 60)
        {
            //D
            Console.WriteLine("Your grade is a D!");
        }
        else
        {
            //F
            Console.WriteLine("Your grade is an F!");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed... Better Luck next time!");
        }
    }
}