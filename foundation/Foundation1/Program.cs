using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Alessandro Cipriano", 600);
        Video video2 = new Video("Programming Tips", "John Doe", 450);

        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful!"));

        video2.AddComment(new Comment("User3", "Nice tips."));
        video2.AddComment(new Comment("User4", "Thanks for sharing."));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
        }
    }
}