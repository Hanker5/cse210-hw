using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Game Developer";
        job1._company = "Haystack Studios";
        job1._startYear = 2025;
        job1._endYear = 2080;

        Job job2 = new Job();
        job2._jobTitle = "Sumo Wrestler";
        job2._company = "Big Soy";
        job2._startYear = 2090;
        job2._endYear = 2100;

        Resume resume1 = new Resume();
        resume1._name = "Hanry Heys";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}