using System;

class Program
{
    static void Main(string[] args)
    {
        // Added ActivityLogger class for extra credit
        ActivityLogger logger = new ActivityLogger();
        logger.LoadLog(); // Load previous log data

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectionActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
            {
                logger.SaveLog(); // Save log before quitting
                break;
            }

            if (activity != null)
            {
                activity.Run();
                logger.UpdateActivityLog(activity.GetName()); // Log the activity
            }
        }
    }
}