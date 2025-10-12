public class Entry
{
    public string _title;
    public string _date;
    public string _prompt;
    public string _answer;
    public int _rating;

    public void Display()
    {
        Console.WriteLine($"\n{_title} - {_date}");
        Console.WriteLine($"prompt: {_prompt}");
        Console.WriteLine($"reponse: {_answer}");
        Console.WriteLine($"1-10 rating for the day: {_rating}");
    }
}