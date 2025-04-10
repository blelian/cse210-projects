public class SimpleGoal : Goal
{
    private bool _isComplete;

    public bool IsDone { get => _isComplete; private set => _isComplete = value; }

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetGoalDetails()
    {
        return IsComplete() ? $"{Name} [X]" : $"{Name} [ ]";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GoalType => "SimpleGoal";
}
