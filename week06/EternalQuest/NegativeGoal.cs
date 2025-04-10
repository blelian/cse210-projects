public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Negative goal '{Name}' recorded. Deducting {Points} points.");
    }

    public override string GetGoalDetails()
    {
        return $"{Name} (Negative Goal)";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GoalType => "NegativeGoal";
}