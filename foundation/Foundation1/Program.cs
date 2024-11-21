using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
       
        Video video1 = new Video("Glass marble tutorial", "Venisa McAllister", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Well explained."));

        Video video2 = new Video("Dirtbike Maintainance", "Samuel McAllister", 900);
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "Really enjoyed this."));
        video2.AddComment(new Comment("Frank", "Looking forward to more videos."));

        Video video3 = new("Nativity Play", "Emily McAllister", 750);
        video3.AddComment(new Comment("Grace", "This was amazing!"));
        video3.AddComment(new Comment("Heidi", "Thanks for sharing."));
        video3.AddComment(new Comment("Ivan", "Can't wait for the next one."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
