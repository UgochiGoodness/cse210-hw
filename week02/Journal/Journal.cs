using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToCsv(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Response,Mood"); // header row
            foreach (Entry e in _entries)
            {
                writer.WriteLine(e.ToCsv());
            }
        }
        Console.WriteLine($"Journal saved to '{filename}'.");
    }
    public void LoadFromCsv(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        // skip the first line (header)
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;
            Entry e = new Entry();
            e.FromCsv(lines[i]);
            _entries.Add(e);
        }

        Console.WriteLine($"Journal loaded from '{filename}'.");
    }
}
