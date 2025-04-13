using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("13 April 2025", 30, 4.8),
            new Cycling("13 April 2025", 45, 20.0),
            new Swimming("13 April 2025", 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
