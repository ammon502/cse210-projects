abstract class Event
{
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    public string _type = "";
    protected Address _address;


    protected Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
 
 
 
 
    public abstract void FullDetails();
    public void StandardDetails()
    {
        System.Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{GetDate()}\n{GetTime()}\n{_address.GetFullAddress()}\n");
    }
    public void ShortDetails()
    {
        System.Console.WriteLine($"{GetType()}\n{GetDescription()}\n{GetDate()}\n");
    }
    public virtual string GetTitle()
    {
        return _title;
    }
    protected virtual void SetTitle(string title)
    {
        _title = title;
    }
    public virtual string GetDescription()
    {
        return _description;
    }
    protected virtual void SetDescription(string description)
    {
        _description = description;
    }
    public virtual string GetDate()
    {
        return _date;
    }
    protected virtual void SetDate(string date)
    {
        _date = date;
    }
    public virtual string GetTime()
    {
        return _time;
    }
    protected virtual void SetTime(string time)
    {
        _time = time;
    }

}