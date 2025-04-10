using System;

class Program
{
    /*
    This implementation exceeds the requirements by adding:
    1. A leveling system that tracks user progress based on total points.
    2. A badge system that awards badges for achieving milestones.
    3. A NegativeGoal class to allow users to set goals that deduct points for bad habits.
    4. Save and Load functionality for persistent goal management.
    */

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10));
        goalManager.AddGoal(new NegativeGoal("Stop Snacking", "Avoid snacking between meals", 200));

        goalManager.DisplayGoals();

        goalManager.RecordGoalEvent("Run a Marathon");
        goalManager.RecordGoalEvent("Read Scriptures");
        goalManager.RecordGoalEvent("Attend Temple");
        goalManager.RecordGoalEvent("Stop Snacking");

        Console.WriteLine($"Total Points: {goalManager.GetTotalPoints()}, Level: {goalManager.GetLevel()}");
        goalManager.DisplayGoals();

        goalManager.SaveGoals("goals.json");
        goalManager.LoadGoals("goals.json");
    }
}