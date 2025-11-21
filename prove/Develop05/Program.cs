using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Journal journal = new Journal();

        while(true)
        {
            Console.WriteLine($"You have {journal.GetScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Types of Goals:");
                Console.WriteLine("  1. Simple");
                Console.WriteLine("  2. Eternal");
                Console.WriteLine("  3. Checklist");
                Console.WriteLine();
                Console.Write("What goal would you like to create? ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Simple Goal Creation: ");
                    Console.Write("Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Goal Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Goal Value: ");
                    int value = int.Parse(Console.ReadLine());

                    Goal newGoal = new Simple(name, description, value, false);
                    journal.AddGoal(newGoal);
                    Console.Clear();
                }
                else if (input == 2)
                {   
                    Console.Clear();
                    Console.WriteLine("Eternal Goal Creation: ");
                    Console.Write("Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Goal Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Goal Value: ");
                    int value = int.Parse(Console.ReadLine());

                    Goal newGoal = new Eternal(name, description, value, 0);
                    journal.AddGoal(newGoal);
                    Console.Clear();
                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Checklist Goal Creation: ");
                    Console.Write("Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Goal Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Goal Value: ");
                    int value = int.Parse(Console.ReadLine());
                    Console.Write("Goal Full Completion Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.Write("Full Completion Requirement: ");
                    int required = int.Parse(Console.ReadLine());

                    Goal newGoal = new Checklist(name, description, value, false, bonus, required, 0);
                    journal.AddGoal(newGoal);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Option. Please Try Again. \n");
                }
            }
            else if (input == 2)
            {
                Console.Clear();
                journal.ListGoals();
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 3)
            {
                Console.Clear();
                Console.WriteLine("What would you like to name your file?");
                string filename = Console.ReadLine();
                journal.Save(filename);
                Console.WriteLine($"File saved as {filename}.csv");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 4)
            {
                Console.Clear();
                Console.WriteLine("What is the name of the file you'd like to load?");
                string filename = Console.ReadLine();
                journal.Load(filename);
                Console.WriteLine("File loaded!");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 5)
            {
                Console.Clear();
                journal.ListGoals();
                Console.Write("Which goal did you achieve? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                journal.DoGoal(index);
                Console.Clear();

            }
            else if (input == 6)
            {
                break;
            }
            else if (input == 7)
            {
                Console.Clear();
                Console.WriteLine("Invalid Option. Please Try Again. \n");
            }
        }
    }
}