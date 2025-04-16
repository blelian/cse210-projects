using System;

class Program
{
    /*
    This implementation exceeds the core requirements by adding:
    1. A Leveling System: The user levels up every 1000 points.
    2. A Badge System: Badges are awarded when point milestones are reached.
    3. A NegativeGoal class that deducts points for bad habits.
    4. Save/Load functionality using JSON serialization.
    */

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Display Score and Level");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter goal name to record: ");
                    string name = Console.ReadLine();
                    goalManager.RecordGoalEvent(name);
                    break;
                case "4":
                    Console.WriteLine($"Total Points: {goalManager.GetTotalPoints()}, Level: {goalManager.GetLevel()}");
                    break;
                case "5":
                    goalManager.SaveGoals("goals.json");
                    break;
                case "6":
                    goalManager.LoadGoals("goals.json");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, target));
                break;
            case "4":
                manager.AddGoal(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}
