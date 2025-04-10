using System.Text.Json.Serialization;

[JsonConverter(typeof(GoalConverter))]
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name { get => _name; private set => _name = value; }
    public string Description { get => _description; private set => _description = value; }
    public int Points { get => _points; private set => _points = value; }

    public abstract void RecordEvent();
    public abstract string GetGoalDetails();
    public abstract bool IsComplete();
    public abstract string GoalType { get; }
}
