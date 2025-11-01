using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        MathAssignment math1 = new MathAssignment("Johny Depp","Decimals","6.9","6 & 7");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Billy","Bob","Geometry for Ocelots by Exurb1a");

        Console.WriteLine(write1.GetWritingInformation());
    }
}