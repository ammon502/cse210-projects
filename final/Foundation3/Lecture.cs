class Lecture : Event
{
    private int _capacity = 0;
    private string _speaker = "";
    private int _attending = 0;
    public Lecture(string title, string description, string date, string time, Address address, int capacity, string speaker, int attending)
    :base(title, description, date, time, address)
    {
        _capacity = capacity;
        _speaker = speaker;
        _attending = attending;
        _type = "Lecture";
    }
    public override void FullDetails()
    {
        System.Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{GetDate()}\n{GetTime()}\n{_address.GetFullAddress()}{GetSpeaker()}\nWe can hold up to {GetCapacity() - GetAttending()} people, sign up today!\n");
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapactity(int capacity)
    {
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetAttending()
    {
        return _attending;
    }
}