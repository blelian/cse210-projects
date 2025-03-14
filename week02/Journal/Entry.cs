using System;

public class Entry
{
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Response { get; private set; }
    public string Mood { get; private set; }
    public string Weather { get; private set; }

    public Entry(string date, string prompt, string response, string mood, string weather)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
        Weather = weather;
    }

    public override string ToString()
    {
        return $"{Date} | \"{Prompt}\" | \"{Response}\" | \"{Mood}\" | \"{Weather}\"";
    }
}