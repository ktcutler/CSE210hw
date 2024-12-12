using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Funny Cat Video", "Cat Productions", 60);
        Video video2 = new Video("Car Wreck Compilation", "Cool Vids Tube", 120);
        Video video3 = new Video("2024 Ford Raptor Review", "CarReviews", 10);

        video1.AddComment(new Comment("Kole Cutler", "OMG this is so cute!"));
        video1.AddComment(new Comment("Dylan Cutler", "I love how the cats are all so crazy"));
        video1.AddComment(new Comment("Kaylee Cutler", "Wow this video was wayyyyy to short"));

        video2.AddComment(new Comment("Jonathan Cutler", "These wrecks were HORRRIBLE"));
        video2.AddComment(new Comment("Liz Cutler", "Pray for their families"));
        video2.AddComment(new Comment("Ansley Floyd", "That was a wild wreck!!"));

        video3.AddComment(new Comment("Shirley Floyd", "Really Great Review"));
        video3.AddComment(new Comment("Angila Hales", "What a versitle truck"));
        video3.AddComment(new Comment("David Hales", "Chevys are better!!"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine($"All Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._personName}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}