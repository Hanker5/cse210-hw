public class Journal
{
    private List<Goal> _goals;

    public Journal()
    {
        _goals = new List<Goal>();
    }

    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines($"{filename}.csv");
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string goalType = parts[0];
            Goal newGoal = null;
            if (goalType == "Simple")
            {
                string name = parts[1];
                string description = parts[2];
                int value = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                newGoal = new Simple(name,description,value,isComplete);
            }
            else if (goalType == "Eternal")
            {
                string name = parts[1];
                string description = parts[2];
                int value = int.Parse(parts[3]);
                int numComplete = int.Parse(parts[4]);
                newGoal = new Eternal(name,description,value,numComplete);
            }
            else if (goalType == "Checklist")
            {
                string name = parts[1];
                string description = parts[2];
                int value = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int required = int.Parse(parts[6]);
                int numComplete = int.Parse(parts[7]);
                newGoal = new Checklist(name,description,value,isComplete,bonus,required,numComplete);
            }
            _goals.Add(newGoal);
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter($"{filename}.csv"))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveLine());
            }
        }
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ListGoals()
    {
        Console.WriteLine("Your Goals Are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.Display()}");
            index++;
        }
    }
    public void DoGoal(int index)
    {
        _goals[index].DoGoal();
    }
    public int GetScore()
    {
        int score = 0;
        foreach (Goal goal in _goals)
        {
            score += goal.GetScore();
        }
        return score;
    }
}