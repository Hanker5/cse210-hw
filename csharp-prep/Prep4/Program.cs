using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            total += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        float average = total / numbers.Count();

        Console.Write($"The sum is: {total}\nThe average is: {average}\nThe largest number is: {largest}");
    }
}