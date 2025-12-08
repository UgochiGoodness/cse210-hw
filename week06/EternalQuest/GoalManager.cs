public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    public Player Player { get; private set; } = new Player();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal g in _goals)
            Console.WriteLine($"{g.GetStatus()} - {g.Name}");
    }

    public void RecordEvent(int index)
    {
        int earned = _goals[index].RecordEvent();
        Player.AddPoints(earned);
        Console.WriteLine($"\nYou earned {earned} points!");
    }

    public void Save(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(Player.Score);
        writer.WriteLine(Player.Level);

        foreach (Goal g in _goals)
            writer.WriteLine(g.SaveToString());
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        Player = new Player();
        Player.AddPoints(int.Parse(lines[0]));

        for (int i = 2; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');
            string type = p[0];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3])));

            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));

            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[5]), int.Parse(p[6])));

            else if (type == "BigProgressGoal")
                _goals.Add(new BigProgressGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[5]), int.Parse(p[6])));
        }
    }
}
