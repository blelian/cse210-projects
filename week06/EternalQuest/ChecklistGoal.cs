public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public int TargetCount { get => _targetCount; private set => _targetCount = value; }
    public int CurrentCount { get => _currentCount; private set => _currentCount = value; }

    public ChecklistGoal(string name, string description, int points, int targetCount) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override string GetGoalDetails()
    {
        return $"{Name} [Completed {_currentCount}/{_targetCount}]";
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GoalType => "ChecklistGoal";
}
