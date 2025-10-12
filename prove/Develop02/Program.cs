using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Henry's Journaling Program!!");
        bool go = true;
        Journal currentJournal = new Journal();
        while (go)
        {
            Console.WriteLine("\nWhat action would you like to perform?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter a number 1-5: ");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                string prompt = currentJournal.RanPrompt();
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();
                Console.WriteLine("How would you rate your day on a scale of 1-10?");
                string input = Console.ReadLine();
                int rating = int.Parse(input);
                Console.WriteLine("What would you like to title today's entry?");
                string title = Console.ReadLine();
                currentJournal.NewEntry(title, date, prompt, answer, rating);
                Console.WriteLine("Thank you for writing today!");
            }
            else if (selection == "2")
            {
                currentJournal.Display();
            }
            else if (selection == "3")
            {
                Console.WriteLine("\nWhat file would you like to load?");
                string filename = Console.ReadLine();
                currentJournal = new Journal();
                currentJournal.Load(filename);
            }
            else if (selection == "4")
            {
                Console.WriteLine("What name would you like to save the file to?");
                string filename = Console.ReadLine();
                currentJournal.Save(filename);
            }
            else if (selection == "5")
            {
                go = false;
            }
            else
            {
                Console.WriteLine("That is not a valid option. Please try again.");
            }
        }
    }
}