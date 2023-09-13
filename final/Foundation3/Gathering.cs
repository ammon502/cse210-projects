class OutdoorGathering : Event
{
    protected string _weather = "";
    public OutdoorGathering()
    {

    }
    public override void FullDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.getFullAddress()}\n{_weather}");
    }
    public override void StandardDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.getFullAddress()}");
    }
    public override void ShortDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}");
    }
}