public class Eternal : Goal
{
    private int _numComplete;
    public Eternal(string name, string description, int value, int numComplete)
    : base(name, description, value, false)
    {
        _numComplete = numComplete;
    }

    public override void DoGoal()
    {
        _numComplete++;
    }
    public override int GetScore()
    {
        return _value * _numComplete;
    }
    public override string GetSaveLine()
    {
        return $"Eternal;{_name};{_description};{_value};{_numComplete}";
    }
}