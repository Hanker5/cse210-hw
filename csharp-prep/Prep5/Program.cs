using System;

class Program
{
    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int fav_num = int.Parse(input);
        return fav_num;
    }

    //Accepts out integer parameter and prompts the user for the year they were born. 
    // The out parameter is set to their birth year. This function does not return a 
    // value. The user's birth year is given back from the function via the out parameter.
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string input = Console.ReadLine();
        year = int.Parse(input);
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int num)
    {
        return num * num;
    }

    //Accepts the user's name, the squared number, and the user's birth year. Display the 
    // user's name and squared number. Calculate hold many years old they will turn this 
    // year and display that.    
    static void DisplayResult(string name, int sqr_num, int year)
    {
        int age = 2025 - year;

        Console.WriteLine($"{name}, the square of your number is {sqr_num}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int fav_num = PromptUserNumber();
        int birth_year;
        PromptUserBirthYear(out birth_year);
        int sqr_num = SquareNumber(fav_num);
        DisplayResult(name, sqr_num, birth_year);
    }
}