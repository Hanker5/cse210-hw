using System.IO;
using Microsoft.VisualBasic;
public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter($"{filename}.csv"))
        {
            foreach (Entry currentEntry in _entries)
            {
                outputFile.WriteLine($"{currentEntry._title},{currentEntry._date},{currentEntry._prompt},{currentEntry._answer},{currentEntry._rating}");
            }
        }
    }
    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines($"{filename}.csv");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string title = parts[0];
            string date = parts[1];
            string prompt = parts[2];
            string answer = parts[3];
            string ratingString = parts[4];
            int rating = int.Parse(ratingString);

            NewEntry(title, date, prompt, answer, rating);
        }
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public string RanPrompt()
    {
        Random random = new Random();
        List<string> prompts = new List<string>();
        prompts = [
        "What was the best part of your day?",
        "What challenged you today?",
        "What did you learn about yourself today?",
        "What's something small that made you smile?",
        "What's something you accomplished big or small?",
        "If you could relive one hour of today which would it be and why?"];
        int index = random.Next(1, prompts.Count);
        return prompts[index];
    }
    public void NewEntry(string title, string date, string prompt, string answer, int rating)
    {
        Entry newEntry = new Entry();
        newEntry._title = title;
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._answer = answer;
        newEntry._rating = rating;
        _entries.Add(newEntry);
    }
}