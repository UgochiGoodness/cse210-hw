using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    public GratitudeActivity(ActivityLogger logger)
        : base("Gratitude Activity",
               "Think about things in your life you are thankful for.",
               logger)
    { }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nFocus on things you are grateful for.");
        Spinner(3);

        int duration = GetDuration();
        int endTime = Environment.TickCount + (duration * 1000);

        List<string> thanks = new List<string>();

        Console.WriteLine("List things you are grateful for:");

        while (Environment.TickCount < endTime)
        {
            thanks.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou wrote {thanks.Count} gratitude items.");
    }
}
