using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine();

        foreach (Word w in _words)
        {
            Console.Write(w.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        // Choose only NOT hidden words (stretch feature)
        var available = _words.Where(w => !w.IsHidden()).ToList();

        if (available.Count == 0)
            return;

        for (int i = 0; i < count; i++)
        {
            if (available.Count == 0)
                break;

            int index = _random.Next(available.Count);
            available[index].Hide();
            available.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
