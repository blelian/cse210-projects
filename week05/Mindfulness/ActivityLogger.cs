using System.Collections.Generic;
using System.IO;

public class ActivityLogger
{
    private Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    public void LoadLog()
    {
        if (File.Exists("activity_log.txt"))
        {
            var lines = File.ReadAllLines("activity_log.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                {
                    _activityLog[parts[0]] = count;
                }
            }
        }
    }

    public void SaveLog()
    {
        using (var writer = new StreamWriter("activity_log.txt"))
        {
            foreach (var entry in _activityLog)
            {
                writer.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }

    public void UpdateActivityLog(string activityName)
    {
        if (_activityLog.ContainsKey(activityName))
            _activityLog[activityName]++;
        else
            _activityLog[activityName] = 1;
    }
}