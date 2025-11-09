using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Response: {_response}\n");
    }

    // Converts entry into CSV-safe string (handles quotes and commas)
    public string ToCsv()
    {
        return $"{EscapeCsv(_date)},{EscapeCsv(_prompt)},{EscapeCsv(_response)},{EscapeCsv(_mood)}";
    }

    public void FromCsv(string csvLine)
    {
        string[] parts = ParseCsv(csvLine);
        _date = parts[0];
        _prompt = parts[1];
        _response = parts[2];
        _mood = parts[3];
    }

    private string EscapeCsv(string field)
    {
        if (field.Contains(",") || field.Contains("\""))
        {
            field = "\"" + field.Replace("\"", "\"\"") + "\"";
        }
        return field;
    }

    private string[] ParseCsv(string csvLine)
    {
        var fields = new System.Collections.Generic.List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in csvLine)
        {
            if (c == '"' && !inQuotes)
                inQuotes = true;
            else if (c == '"' && inQuotes)
                inQuotes = false;
            else if (c == ',' && !inQuotes)
            {
                fields.Add(current);
                current = "";
            }
            else
                current += c;
        }
        fields.Add(current);
        return fields.ToArray();
    }
}
