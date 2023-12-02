// See https://aka.ms/new-console-template for more information

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

        List<Comment> acidComments = new List<Comment>();
        Video acidVLavaVid = new Video("Acid vs. Lava", "Mark Rober", 1200, acidComments);
        videoList.Add(acidVLavaVid);
        Comment comment2 = new Comment("America1998", "Octopi are cool!");
        acidComments = acidVLavaVid.GetComments();
        acidComments.Add(comment2);

        List<Comment> policeComments = new List<Comment>();
        Video escapeVid = new Video("How to Escape a Police Sniffing Dog", "Mark Rober", 1620, policeComments);
        videoList.Add(escapeVid);
        Comment comment3 = new Comment("SamIAm", "Green eggs and ham.");
        policeComments = escapeVid.GetComments();
        policeComments.Add(comment3);

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
