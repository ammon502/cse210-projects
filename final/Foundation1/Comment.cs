class Comment
{
    string _creatorName = "";
    string _content = "";
    public Comment(string content)
    {
        _content = content;
    }
    public void getContent()
    {
        System.Console.WriteLine($"{_creatorName} says: {_content}");
    }
    public void setContent(string content)
    {
        _content = content;
    }
    public void getName()
    {
        System.Console.WriteLine(_creatorName);
    }
    public void setName(string Name)
    {
        _creatorName = Name;
    }
}