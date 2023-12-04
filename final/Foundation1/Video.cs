class Video
{
    string _videoTitle = "";
    string _videoAuthor = "";
    double _videoLength = 0.0;
    List<Comment> _comment = new List<Comment>();
    
    public Video()
    {
        for (int i = 0; i < 3; i++)
        {
            string comment = $"Comment {i}";
            Comment c = new Comment(comment);
            _comment.Add(c);
        }
    }

    public void setComment()
    {
        int count = 1;
        foreach (Comment c in _comment)
        {
            System.Console.Write($"What is the name of the person who created comment {count}?: ");
            string name = Console.ReadLine();
            c.setName(name);
            System.Console.Write($"What  will comment {count} say?: ");
            string s = Console.ReadLine();
            c.setContent(s);
            count ++;
        }
    }
    public void getComment()
    {
        int count = 1;
        foreach (Comment c in _comment)
        {
            System.Console.Write($"Comment {count} written by ");
            c.getContent();
            count ++;
        }
    }
    

    public string getTitle()
    {
        return _videoTitle;
    }
    public void setTitle(string title)
    {
        _videoTitle = title;
    }
    
    public string getAuthor()
    {
        return _videoAuthor;
    }
    public void setAuthor(string author)
    {
        _videoAuthor = author;
    }

    public double getLength()
    {
        return _videoLength;
    }
    public void setLength(double length)
    {
        _videoLength = length;
    }

    public int numComments()
    {
        int count = 0;
        foreach ( Comment c in _comment)
        {
            count++;
        }
        return count;
    }
}