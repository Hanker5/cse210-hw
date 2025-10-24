using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // creates a scripture object
        Reference reference = new Reference("John", 3, 16, 17);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        List<string> strings = new List<string>();
        strings = scriptureText.Split(" ").ToList<string>();
        List<Word> words = new List<Word>();
        foreach (string currentWord in strings)
        {
            Word newWord = new Word(currentWord);
            words.Add(newWord);
        }
        Scripture scripture = new Scripture(reference, words);


        // main loop
        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.Write("\ntype 'quit' to quit the program: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.HideWords();
            }
        }
    }
}