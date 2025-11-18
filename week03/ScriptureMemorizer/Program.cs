using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are now hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide more words, or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hides 3 words per step
        }
    }
}

/*
EXCEEDING REQUIREMENTS 

1. STRETCH FEATURE — Smarter Word Hiding
   - The program hides ONLY words that are not already hidden
     (instead of randomly selecting from all words, as the core requires).

2. STRONG OOP DESIGN
   - Uses 4 classes: Program, Reference, Scripture, Word
   - Clean encapsulation with private fields + public methods
   - Multiple constructors in Reference (single verse or verse range)

3. EASY EXTENSIBILITY
   - Scripture selection logic is structured so additional features
     (like file loading or random scripture rotation) can be added easily.
*/
