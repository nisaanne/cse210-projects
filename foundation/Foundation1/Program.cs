using System;
using System.Collections.Generic;


public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}


public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}


public class Program
{
    public static void Main()
    {
       
        var video1 = new Video("Glass marble tutorial", "Venisa McAllister", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Well explained."));

        var video2 = new Video("Dirtbike Maintainance", "Samuel McAllister", 900);
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "Really enjoyed this."));
        video2.AddComment(new Comment("Frank", "Looking forward to more videos."));

        var video3 = new Video("Nativity Play", "Emily McAllister", 750);
        video3.AddComment(new Comment("Grace", "This was amazing!"));
        video3.AddComment(new Comment("Heidi", "Thanks for sharing."));
        video3.AddComment(new Comment("Ivan", "Can't wait for the next one."));

        
        var videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
