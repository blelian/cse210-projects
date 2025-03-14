using System;

class Program
{
    static void Main()
    {
            // Make sure to install the Newtonsoft.Json package before using it:
            // Ensure that this library is included to avoid issues with serialization in the Journal class.
            /* 
                In this modified version of the journaling application, I have:
                - Enhanced the Entry class to include additional information: mood and weather, which gives users more context about their day.
                - Updated the saving and loading methods within the Journal class to utilize JSON format using the Newtonsoft.Json library. This provides structured data storage that is easily readable and compatible with many applications, including Excel when dealing with data in tabular form.
                - Introduced serialization and deserialization to convert the list of journal entries to and from a JSON string, making the data handling more flexible and eliminating the need for manual handling of CSV formatting issues such as commas and quotes.
                - This approach exceeds the original requirements by not only improving data organization with additional attributes but also utilizing a widely-recognized format in software development, making the journal system more robust and user-friendly.
            */

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
