using System.Dynamic;

public class Fraction
{
    private int _top { get; set; }
    private int _bottom { get; set; }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double top = _top * 1.0;
        double bottom = _bottom * 1.0;
        return top / bottom;
    }
}