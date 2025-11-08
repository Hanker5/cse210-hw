public class Reflection : Activity
{
    public Reflection() : base
    (
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    { }

    public void RunActivity()
    {
        DisplayIntro();
        Console.WriteLine("Get Ready...");
        Idle(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        
        Console.WriteLine(RanStartPrompt());
        Idle(10);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(RanPrompt());
            Idle(10);
        }
        DisplayOutro();
    }

    private string RanStartPrompt()
    {
        List<string> prompts = new List<string>([
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ]);

        Random ran = new Random();
        int index = ran.Next(prompts.Count);

        return prompts[index];
    }
    private string RanPrompt()
    {
        List<string> prompts = new List<string>([
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ]);

        Random ran = new Random();
        int index = ran.Next(prompts.Count);

        return prompts[index];
    }
}