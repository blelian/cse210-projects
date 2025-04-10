using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private int _level;
    private List<string> _badges = new List<string>();

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
                if (goal is NegativeGoal)
                {
                    _totalPoints -= goal.Points;
                }
                else
                {
                    _totalPoints += goal.Points;
                }
                UpdateLevel();
                CheckForBadges();
                Console.WriteLine($"Recorded event for {goalName}. Total points: {_totalPoints}, Level: {_level}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    private void UpdateLevel()
    {
        _level = _totalPoints / 1000;
    }

    private void CheckForBadges()
    {
        if (_totalPoints >= 1000 && !_badges.Contains("Novice"))
        {
            _badges.Add("Novice");
            Console.WriteLine("Badge earned: Novice!");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetGoalDetails());
        }
    }

    public int GetTotalPoints() => _totalPoints;
    public int GetLevel() => _level;

    public void SaveGoals(string filePath)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() },
            IncludeFields = true
        };
        var json = JsonSerializer.Serialize(_goals, options);
        File.WriteAllText(filePath, json);
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                Converters = { new GoalConverter() },
                IncludeFields = true
            };
            _goals = JsonSerializer.Deserialize<List<Goal>>(json, options);
        }
    }
}
