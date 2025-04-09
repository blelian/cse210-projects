using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _totalPoints += goal.Points;
                Console.WriteLine($"Recorded event for {goalName}. Total points: {_totalPoints}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetGoalDetails());
        }
    }

    public int GetTotalPoints() => _totalPoints;
}