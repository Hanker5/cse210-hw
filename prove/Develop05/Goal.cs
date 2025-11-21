public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _value;
    protected bool _isComplete;

    public Goal(string name, string description, int value, bool isComplete)
    {
        _name = name;
        _description = description;
        _value = value;
        _isComplete = isComplete;
    }

    public abstract void DoGoal();
    public abstract int GetScore();
    public abstract string GetSaveLine();
    public virtual string Display()
    {
        if (_isComplete)
        {
            return $"[x] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }
}