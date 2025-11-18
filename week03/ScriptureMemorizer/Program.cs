using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

         Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

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

            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 2–3 random words each step
            scripture.HideRandomWords(3);
        }
    }
}

/*
EXCEEDING REQUIREMENTS (for full 100%)

1. Stretch feature: The program hides ONLY words that are not already hidden.
   (The core requirement allowed choosing any word, even hidden ones.)

2. Clean OOP design using full encapsulation and multiple classes.

3. Flexible constructors: 
   - One-verse references (e.g., John 3:16)
   - Multi-verse references (e.g., Proverbs 3:5-6)

4. Randomization improved:
   - Selects from remaining visible words only.
*/


