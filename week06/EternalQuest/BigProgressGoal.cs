public class BigProgressGoal : Goal
{
    private int _progress;
    private int _target;
    private int _bonus;

    public BigProgressGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _progress = 0;
    }

    public override int RecordEvent()
    {
        Console.Write("Enter progress amount: ");
        int amount = int.Parse(Console.ReadLine());
        _progress += amount;

        if (_progress >= _target)
            return Points + _bonus;

        return Points;
    }

    public override string GetStatus()
    {
        return $"Progress: {_progress}/{_target}";
    }

    public override string SaveToString()
    {
        return $"BigProgressGoal|{Name}|{Description}|{Points}|{_progress}|{_target}|{_bonus}";
    }
}
