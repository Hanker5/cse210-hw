public class Checklist : Goal
{
    private int _bonus;
    private int _required;
    private int _numComplete;
    
    public Checklist(string name, string description, int value, bool isComplete, int bonus, int required, int numComplete)
    : base(name, description, value, isComplete)
    {
        _bonus = bonus;
        _required = required;
        _numComplete = numComplete;
    }

    public override void DoGoal()
    {
        _numComplete++;
        if (_numComplete >= _required)
        {
            _isComplete = true;
        }
    }

    public override int GetScore()
    {
        int score = _numComplete * _value;
        if (_isComplete)
        {
            score += _bonus;
        }
        return score;
    }
    public override string GetSaveLine()
    {
        return $"Checklist;{_name};{_description};{_value};{_isComplete};{_bonus};{_required};{_numComplete}";
    }

    public override string Display()
    {
        if (_isComplete)
        {
            return $"[x] {_name} ({_description}) -- Currently completed: {_numComplete}/{_required}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_numComplete}/{_required}";
        }
    }
}