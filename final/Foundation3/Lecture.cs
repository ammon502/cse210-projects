class Lecture : Event
{
    protected int _capacity = 0;
    protected string _speaker = "";
    public override void FullDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.getFullAddress()}\n{_speaker}\nWe can Hold up to {_capacity} people, sign up today!");
    }
    public override void StandardDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.getFullAddress()}");
    }
    public override void ShortDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}");
    }
    public int getCapacity()
    {
        return _capacity;
    }
    public void setCapactity(int capacity)
    {
        _capacity = capacity;
    }
    public string getSpeaker()
    {
        return _speaker;
    }
    public void setSpeaker(string speaker)
    {
        _speaker = speaker;
    }
}