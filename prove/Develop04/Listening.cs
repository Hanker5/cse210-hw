public class Listening : Activity
{
    private int _answerCount;
    public Listening() : base
    (
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {
        _answerCount = 0;
    }

    public void RunActivity()
    {
        DisplayIntro();
        Console.WriteLine("Get Ready...");
        Idle(5);

        Console.WriteLine(RanPrompt());
        Console.WriteLine("Start listing answers in: ");
        CountDown(9);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                _answerCount++;
            }
        }

        Console.WriteLine($"You wrote {_answerCount} answers!");
        DisplayOutro();
    }
    private string RanPrompt()
    {
        List<string> prompts = new List<string>([
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ]);

        Random ran = new Random();
        int index = ran.Next(prompts.Count);

        return prompts[index];
    }
}