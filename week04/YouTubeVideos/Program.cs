using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learning C#", "Tech Teacher", 600);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Charlie", "C# is awesome!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 10 Travel Destinations", "WanderWorld", 850);
        v2.AddComment(new Comment("Diana", "I want to go to all of these!"));
        v2.AddComment(new Comment("Evan", "Amazing visuals."));
        v2.AddComment(new Comment("Fiona", "Number 3 is my dream spot."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Cooking Pasta Like a Chef", "KitchenPro", 420);
        v3.AddComment(new Comment("George", "Tried this and it was delicious!"));
        v3.AddComment(new Comment("Hannah", "Simple and tasty."));
        v3.AddComment(new Comment("Ian", "More recipes please!"));
        videos.Add(v3);

        // Display videos
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}