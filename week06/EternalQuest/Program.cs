using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10));

        goalManager.DisplayGoals();

        goalManager.RecordGoalEvent("Run a Marathon");
        goalManager.RecordGoalEvent("Read Scriptures");
        goalManager.RecordGoalEvent("Attend Temple");

        Console.WriteLine($"Total Points: {goalManager.GetTotalPoints()}");
        goalManager.DisplayGoals();
    }
}