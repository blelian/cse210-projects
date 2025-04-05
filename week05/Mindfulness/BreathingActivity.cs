using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public override string GetName() => "Breathing Activity"; // Ensure public modifier

    protected override string GetDescription() => 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountdown(4);
            Console.WriteLine();
        }
    }
}