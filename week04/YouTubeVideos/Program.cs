using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Basics for Beginners", "Code with Ariel", 720);
        video1.AddComment(new Comment("Bianca", "This helped me a lot, thanks!"));
        video1.AddComment(new Comment("Francisco", "Can you make a part 2?"));
        video1.AddComment(new Comment("Raquel", "Great explanation of classes."));

        Video video2 = new Video("Cooking the Perfect Steak", "Chef Daniel", 540);
        video2.AddComment(new Comment("Cristian", "I tried this and it worked perfectly."));
        video2.AddComment(new Comment("Victor", "What temperature do you recommend?"));
        video2.AddComment(new Comment("Ronald", "Best steak recipe I've found."));
        video2.AddComment(new Comment("Nicolas", "Subscribed after watching this!"));

        Video video3 = new Video("Full Body Workout for Beginners", "FitLife with Carlos", 900);
        video3.AddComment(new Comment("Micaela", "Perfect way to start my fitness journey."));
        video3.AddComment(new Comment("Wilson", "How many days a week should I do this?"));
        video3.AddComment(new Comment("Kevin", "This routine really helped me build consistency."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}