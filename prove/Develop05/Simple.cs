public class Simple : Goal
{
    public Simple(string name, string description, int value, bool isComplete) 
    : base(name, description, value, isComplete)
    {    }
    
    public override void DoGoal()
    {
        _isComplete = true;
    }
    public override int GetScore()
    {
        if (_isComplete)
        {
            return _value;
        }
        else
        {
            return 0;
        }
    }
    public override string GetSaveLine()
    {
        return $"Simple;{_name};{_description};{_value};{_isComplete}";
    }
}