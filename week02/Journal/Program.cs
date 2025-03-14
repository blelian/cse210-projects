using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string filename = "journal.json";

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Load Journal");
            Console.WriteLine("2. Add Entry");
            Console.WriteLine("3. Display Entries");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.LoadFromFile(filename); // Called only once
                    break;
                case "2":
                    Console.Write("Date: ");
                    string date = Console.ReadLine();
                    Console.Write("Prompt: ");
                    string prompt = Console.ReadLine();
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    Console.Write("Mood: ");
                    string mood = Console.ReadLine();
                    Console.Write("Weather: ");
                    string weather = Console.ReadLine();

                    journal.AddEntry(date, prompt, response, mood, weather);
                    break;
                case "3":
                    journal.DisplayEntries();
                    break;
                case "4":
                    journal.SaveToFile(filename);
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
