public class Activity
{
    private string _title;
    private string _description;
    protected int _time;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_title}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session? ");

        string input = Console.ReadLine();
        _time = int.Parse(input);
    }

    public void DisplayOutro()
    {
        Console.WriteLine("Well done!!");
        Idle(5);
        Console.WriteLine($"You have completed another {_time} seconds of the {_title}");
        Idle(5);
        Console.Clear();
    }

    protected static void Idle(int seconds)
    {
        List<string> frames = new List<string>(["|", "/", "-", "\\"]);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= frames.Count)
            {
                i = 0;
            }
        }
    }
    
    protected static void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}