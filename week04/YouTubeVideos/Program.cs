using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
    //Create videos and add comments
        Video video1 = new Video("Introduction to C# Programming", "CodeAcademy", 1250);
        video1.Comments.Add(new Comment("Sarah_Dev", "This is exactly what I needed!"));
        video1.Comments.Add(new Comment("Mike123", "Clear explanations, thank you!"));
        video1.Comments.Add(new Comment("Emily_Codes", "Best C# intro I've found"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "TechGuru", 1800);
        video2.Comments.Add(new Comment("CodeMaster", "Great tips for advanced users.")); 
        video2.Comments.Add(new Comment("DevDude", "Learned a lot from this video."));
        videos.Add(video2);  

        Video video3 = new Video("Building Your First App", "AppDevPro", 2100);
        video3.Comments.Add(new Comment("Beginner1", "Following along step by step"));
        video3.Comments.Add(new Comment("Janet_K", "Works perfectly!"));
        video3.Comments.Add(new Comment("Tom_H", "More tutorials please!"));
        videos.Add(video3);

        //Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\t{comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}