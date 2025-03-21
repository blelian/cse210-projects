using System;
using System.Collections.Generic;
using System.IO;

class Program
{   //To exceed requirements,
    // This program now works with a library of scriptures loaded from a file.
    // It selects a random scripture each time it runs, enhancing the learning experience.
    // If the scriptures.txt file does not exist, it will create one with default content.

    static void Main(string[] args)
    {
        string filePath = "scriptures.txt";
        CreateDefaultScripturesFile(filePath);

        List<Scripture> scriptures = LoadScriptures(filePath);

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }
    }

    // Method to load scriptures from a file
    static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(',', 2); // Split only on the first comma
            if (parts.Length == 2)
            {
                var reference = new Reference(parts[0].Trim());
                var text = parts[1].Trim();
                scriptures.Add(new Scripture(reference, text));
            }
        }
        return scriptures;
    }

    // Method to create a default scriptures file if it doesn't exist
    static void CreateDefaultScripturesFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Proverbs 3:5-6, Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
                writer.WriteLine("John 3:16, For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
                writer.WriteLine("Philippians 4:13, I can do all this through him who gives me strength.");
                writer.WriteLine("Romans 8:28, And we know that in all things God works for the good of those who love him, who have been called according to his purpose.");
            }
            Console.WriteLine($"Created default scriptures file at '{filePath}'.");
        }
    }
}