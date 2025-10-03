public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        //Displays the resume, which shows the name first, followed by displaying each one of the jobs.
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}