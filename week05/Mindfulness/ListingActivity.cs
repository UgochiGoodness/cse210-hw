using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private Random _rand = new Random();
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(ActivityLogger logger)
        : base("Listing Activity",
               "List as many positive things as you can within the time limit.",
               logger)
    { }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(prompts[_rand.Next(prompts.Count)]);

        Console.WriteLine("\nGet ready to list items...");
        Countdown(5);

        int duration = GetDuration();
        int endTime = Environment.TickCount + (duration * 1000);

        List<string> items = new List<string>();

        Console.WriteLine("Start listing:");

        while (Environment.TickCount < endTime)
        {
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
