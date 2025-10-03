using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        School school1 = new School();
        school1._name = "BYUI";
        school1._numStudents = 12432;
        school1._numTeachers = 606;

        Student student1 = new Student();
        student1._name = "Bill Alexander";
        school1._students.Add(student1);

        school1.ShowDetails();
    }
}