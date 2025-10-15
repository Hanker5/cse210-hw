using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1,3);

        List<Fraction> fractions = new List<Fraction>([f1, f2, f3, f4]);
        
        foreach(Fraction current in fractions)
        {
            Console.WriteLine(current.GetFractionString());
            Console.WriteLine(current.GetDecimalValue());
        }
    }
}