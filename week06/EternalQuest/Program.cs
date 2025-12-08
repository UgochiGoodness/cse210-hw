using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager gm = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nScore: {gm.Player.Score} | Level: {gm.Player.Level}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1) CreateGoal(gm);
            else if (choice == 2) gm.DisplayGoals();
            else if (choice == 3)
            {
                Console.Write("Goal number: ");
                gm.RecordEvent(int.Parse(Console.ReadLine()) - 1);
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                gm.Save(Console.ReadLine());
            }
            else if (choice == 5)
            {
                Console.Write("Filename: ");
                gm.Load(Console.ReadLine());
            }
        }
    }
}


// EXCEEDING REQUIREMENTS FOR FULL 100%
// I added several creative and gamified features:
//
// 1. Leveling System
//      The player levels up every 500 points.
//      They receive a 100-point bonus each time they level up.
//      Fun celebratory messages appear when leveling up.
//
// 2. BigProgressGoal (New Goal Type)
//      Allows users to track progress toward large goals
//      (e.g., running 100 miles, reading scriptures, etc.)
//      Awards bonus points when the target is reached.
//
// 3. Enhanced Gamification
//      Fun messages, symbols, and progress tracking
//      Makes the Eternal Quest experience more rewarding.



