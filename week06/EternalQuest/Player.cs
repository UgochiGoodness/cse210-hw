public class Player
{
    public int Score { get; private set; }
    public int Level { get; private set; }

    public Player()
    {
        Score = 0;
        Level = 1;
    }

    public void AddPoints(int amount)
    {
        Score += amount;

        int newLevel = (Score / 500) + 1;
        if (newLevel > Level)
        {
            Level = newLevel;
            Score += 100; // level bonus
            Console.WriteLine($"\n🎉 LEVEL UP! You reached Level {Level}!");
            Console.WriteLine("Bonus 100 points awarded!\n");
        }
    }
}
