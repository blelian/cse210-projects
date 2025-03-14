using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string date, string prompt, string response, string mood, string weather)
    {
        entries.Add(new Entry(date, prompt, response, mood, weather));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, filename);
        var json = JsonConvert.SerializeObject(entries, Formatting.Indented);
        File.WriteAllText(filePath, json);
        Console.WriteLine($"Journal saved successfully at {filePath}.");
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("DEBUG: LoadFromFile() called"); // Debug message to check multiple calls

        string filePath = Path.Combine(Environment.CurrentDirectory, filename);

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"The file '{filePath}' does not exist. Creating a new journal file...");
            File.WriteAllText(filePath, "[]"); // Create an empty JSON file
            return;
        }

        try
        {
            var json = File.ReadAllText(filePath);
            var loadedEntries = JsonConvert.DeserializeObject<List<Entry>>(json);

            if (loadedEntries != null)
            {
                entries = loadedEntries; // Only update if valid data is loaded
            }

            Console.WriteLine("Journal loaded."); // Now prints only once
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }
}
