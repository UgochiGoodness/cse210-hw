/*
EXCEEDS REQUIREMENTS:
- Added a “Gratitude Activity” as an additional activity type.
- Added a session log that stores how many times each activity was completed.
- Added a rule so random prompts/questions are not repeated until all have been used once.
- Added richer breathing animation (expanding / contracting bar).
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        ActivityLogger logger = new ActivityLogger();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity (extra requirement)");
            Console.WriteLine("5. View Activity Log (extra requirement)");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            Activity activity = null;

            switch (input)
            {
                case "1":
                    activity = new BreathingActivity(logger);
                    break;

                case "2":
                    activity = new ReflectionActivity(logger);
                    break;

                case "3":
                    activity = new ListingActivity(logger);
                    break;

                case "4":
                    activity = new GratitudeActivity(logger);
                    break;

                case "5":
                    logger.DisplayLog();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    continue;

                case "6":
                    running = false;
                    continue;

                default:
                    Console.WriteLine("Invalid option. Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }

            activity.Run();
        }
    }
}