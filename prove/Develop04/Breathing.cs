public class Breathing : Activity
{
    public Breathing() : base
    (
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    { }

    public void RunActivity()
    {
        DisplayIntro();
        Console.WriteLine("Get Ready...");
        Idle(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in for ");
            CountDown(4);
            Console.WriteLine("Hold for ");
            CountDown(4);
            Console.WriteLine("Breath out for ");
            CountDown(4);
            Console.WriteLine("Hold for ");
            CountDown(4);
        }

        DisplayOutro();
    }
}