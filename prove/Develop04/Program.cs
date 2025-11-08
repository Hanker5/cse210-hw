using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listening activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int selection = int.Parse(input);

            if (selection == 1)
            {
                Breathing breathing = new Breathing();
                breathing.RunActivity();
            }
            else if (selection == 2)
            {
                Reflection reflection = new Reflection();
                reflection.RunActivity();
            }
            else if (selection == 3)
            {
                Listening listening = new Listening();
                listening.RunActivity();
            }
            else if (selection == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid option. Please try again.");
            }
        }
    }
}