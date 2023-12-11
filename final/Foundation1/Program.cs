using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<Video> videoList = new List<Video>();

        List<Comment> octopusComments = new List<Comment>();
        Video octopusVid = new Video("Octopus vs Underwater Maze", "Mark Rober", 1020, octopusComments);
        videoList.Add(octopusVid);
        Comment comment1 = new Comment("MerChristmas190", "Good stuff!");
        octopusComments = octopusVid.GetComments();
        octopusComments.Add(comment1);
        octopusVid.UpdateCommentNumber();

        List<Comment> acidComments = new List<Comment>();
        Video acidVLavaVid = new Video("Acid vs. Lava", "Mark Rober", 1200, acidComments);
        videoList.Add(acidVLavaVid);
        Comment acidComment = new Comment("America1998", "Acid is so cool!");
        acidComments = acidVLavaVid.GetComments();
        acidComments.Add(acidComment);
        acidVLavaVid.UpdateCommentNumber();
        Comment acidComment2 = new Comment("MarkRoberFan1", "Acid? Yike!");
        acidComments = acidVLavaVid.GetComments();
        acidComments.Add(acidComment2);
        acidVLavaVid.UpdateCommentNumber();

        List<Comment> policeComments = new List<Comment>();
        Video escapeVid = new Video("How to Escape a Police Sniffing Dog", "Mark Rober", 1620, policeComments);
        videoList.Add(escapeVid);
        Comment comment3 = new Comment("SamIAm", "Green eggs and ham.");
        policeComments = escapeVid.GetComments();
        policeComments.Add(comment3);
        escapeVid.UpdateCommentNumber();
        Comment dogComment = new Comment("DogLover", "Those poor dogs!");
        policeComments.Add(dogComment);
        escapeVid.UpdateCommentNumber();

        Console.WriteLine("Video List:");
        foreach (Video video in videoList)
        {
            video.DisplayVideo();
            List<Comment> commentList = video.GetComments();
            foreach(Comment comment in commentList)
            {
                comment.DisplayComment();
            }
        }
    }
}