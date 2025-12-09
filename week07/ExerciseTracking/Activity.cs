using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string Date => _date;
    public int Minutes => _minutes;

    // Methods to override
    public abstract double GetDistance();  // miles
    public abstract double GetSpeed();     // mph
    public abstract double GetPace();      // min per mile

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.00} min per mile";
    }
}
