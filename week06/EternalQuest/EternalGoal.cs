public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override string GetGoalDetails()
    {
        return $"{Name} (Eternal)";
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
}