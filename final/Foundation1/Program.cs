using System;

class Program
{
    static void Main(string[] args)
    {   
        int commentCount = 1;//this is not replacing the comment count method in the video class
        int _videoCount = 0;     
        List<Video> _video = new List<Video>();  //List of videos
        List<Comment> _comment = new List<Comment>();
        //looping through videos to set and get and display its attributes, including the comments attributes
        for (int i = 0 ; i < 3; i++)
        {
            Video video = new Video();   // create a new video each time
            System.Console.Write("How long is the video?: ");
            video.setLength(Double.Parse(Console.ReadLine()));
            
            System.Console.Write("What is the Video's name?: ");  // set video title
            video.setTitle(Console.ReadLine());

            System.Console.Write("What is the Video's Author's name?: "); //set video author
            video.setAuthor(Console.ReadLine());
            

            _video.Add(video);   // add the video to the list


            video.setComment();
        }
        
        int commCount = 0;
        foreach (Video v in _video)
        //looping through videos to see how many comments in each one, and 
        {
            System.Console.WriteLine($"Video {_videoCount+1} created by {v.getAuthor()} is {v.getLength()} minutes long:"); //display non comment properties of the video
            // v.setComment(); // filling in the comments

            // System.Console.Write($"Comment {commentCount+1}: ");
            v.getComment(); // displaying the comments
            commentCount++;
            

            System.Console.WriteLine($"Video {_videoCount+1} has {v.numComments()} comments\n");//
            _videoCount++;
        }
    }
}