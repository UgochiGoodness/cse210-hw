using System;
using System.Collections.Generic;

public class ActivityLogger
{
    private Dictionary<string, int> _counts = new Dictionary<string, int>();

    public void Record(string activity)
    {
        if (!_counts.ContainsKey(activity))
            _counts[activity] = 0;

        _counts[activity]++;
    }

    public void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("Activity Log:");
        Console.WriteLine("-------------");

        foreach (var entry in _counts)
            Console.WriteLine($"{entry.Key}: {entry.Value} times");

        if (_counts.Count == 0)
            Console.WriteLine("No activities logged yet.");
    }
}
