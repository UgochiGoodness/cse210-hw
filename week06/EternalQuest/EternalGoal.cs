public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string SaveToString()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
