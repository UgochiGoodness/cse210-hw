using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected ActivityLogger _logger;

    protected Activity(string name, string description, ActivityLogger logger)
    {
        _name = name;
        _description = description;
        _logger = logger;
    }

    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
        _logger.Record(_name);
    }

    private void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter duration (in seconds): ");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Spinner(3);
    }

    protected int GetDuration() => _duration;

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        Spinner(2);
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        Spinner(4);
    }

    protected void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int index = 0;

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(frames[index]);
            Thread.Sleep(250);
            Console.Write("\b");
            index = (index + 1) % frames.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Each derived class overrides this:
    protected abstract void PerformActivity();
}
