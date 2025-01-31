using System;

class Program
{
    static void Main()
    {
        // Create videos
        var video1 = new Video("How to cook pasta", "Chef John", 300);
        var video2 = new Video("Introduction to Python", "Code Master", 600);
        var video3 = new Video("Exploring Space", "Astronaut Annie", 1200);

        // Create comments and add them to videos
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Can't wait to try this!"));
        video1.AddComment(new Comment("Charlie", "This looks delicious!"));

        video2.AddComment(new Comment("Dave", "Very informative!"));
        video2.AddComment(new Comment("Eva", "I learned a lot, thank you!"));
        video2.AddComment(new Comment("Frank", "I wish I had found this earlier!"));

        video3.AddComment(new Comment("Grace", "Amazing video, space is fascinating!"));
        video3.AddComment(new Comment("Hank", "I want to be an astronaut now!"));

        // Put videos into a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display the information
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine("\n" + new string('-', 50) + "\n");
        }
    }
}