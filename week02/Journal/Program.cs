using System;
using System.Collections.Generic;

class Program
{
    /*
     * EXCEEDING REQUIREMENTS:
     * 1. Added a "Mood" field to each journal entry.
     * 2. Enhanced Save/Load functionality to use CSV format (compatible with Excel).
     * 3. Properly handles commas and quotes in text fields.
     */

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Random rnd = new Random();

        List<string> prompts = new List<string>()
        {
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "What is something new I learned today?",
            "What challenged me the most today?",
            "What is one thing I’m grateful for today?"
        };

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = prompts[rnd.Next(prompts.Count)];
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Console.Write("How are you feeling (mood): ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                    _prompt = prompt,
                    _response = response,
                    _mood = mood
                };

                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!");
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename (example: journal.csv): ");
                string filename = Console.ReadLine();
                myJournal.SaveToCsv(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load (example: journal.csv): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromCsv(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye! Have a great day!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select between 1–5.");
            }
        }
    }
}
