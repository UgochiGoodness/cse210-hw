using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private Random _rand = new Random();
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    private Queue<string> unusedQuestions;

    public ReflectionActivity(ActivityLogger logger)
        : base("Reflection Activity",
               "This activity helps you reflect on times of strength and resilience.",
               logger)
    {
        unusedQuestions = new Queue<string>(Shuffle(questions));
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        int timeUsed = 0;

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(prompts[_rand.Next(prompts.Count)]);
        Console.WriteLine("Reflect on the following questions...");
        Spinner(3);

        while (timeUsed < duration)
        {
            if (unusedQuestions.Count == 0)
                unusedQuestions = new Queue<string>(Shuffle(questions));

            Console.WriteLine(unusedQuestions.Dequeue());
            Spinner(5);

            timeUsed += 5;
        }
    }

    private List<string> Shuffle(List<string> list)
    {
        List<string> copy = new List<string>(list);
        for (int i = copy.Count - 1; i > 0; i--)
        {
            int j = _rand.Next(i + 1);
            (copy[i], copy[j]) = (copy[j], copy[i]);
        }
        return copy;
    }
}
