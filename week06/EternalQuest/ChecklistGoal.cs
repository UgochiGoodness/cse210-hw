public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted >= _target)
            return Points + _bonus;

        return Points;
    }

    public override string GetStatus()
    {
        return $"Completed {_timesCompleted}/{_target} times";
    }

    public override string SaveToString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_timesCompleted}|{_target}|{_bonus}";
    }
}
