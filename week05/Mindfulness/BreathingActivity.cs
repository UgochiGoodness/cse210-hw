using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(ActivityLogger logger)
        : base("Breathing Activity",
               "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breath.",
               logger)
    { }

    protected override void PerformActivity()
    {
        int time = GetDuration();
        int elapsed = 0;

        while (elapsed < time)
        {
            Console.Write("\nBreathe in...");
            ExpandingBar(4);
            elapsed += 4;
            if (elapsed >= time) break;

            Console.Write("\nBreathe out...");
            ContractingBar(4);
            elapsed += 4;
        }
    }

    private void ExpandingBar(int seconds)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\r[" + new string('#', i) + new string(' ', 10 - i) + "]");
            Thread.Sleep(seconds * 100);
        }
        Console.WriteLine();
    }

    private void ContractingBar(int seconds)
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.Write("\r[" + new string('#', i) + new string(' ', 10 - i) + "]");
            Thread.Sleep(seconds * 100);
        }
        Console.WriteLine();
    }
}
