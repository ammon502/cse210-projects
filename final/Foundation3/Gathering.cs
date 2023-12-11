class OutdoorGathering : Event
{
    protected string _weather = "";
    public OutdoorGathering(string title, string description, string date, string time, Address address)
    :base(title, description, date, time, address)
    {
        _weather = "Rainy";
        _type = "Outdoor Gathering";
    }
    public override void FullDetails()
    {
        System.Console.WriteLine($"{GetTitle()}\n{GetType()}\n{GetDescription()}\n{GetDate()}\n{GetTime()}\n{_address.GetFullAddress()}\n{_weather}\n");
    }
    
    
}