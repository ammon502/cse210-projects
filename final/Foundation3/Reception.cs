class Reception : Event
{
    protected bool _RSVP = false;
    protected string _email = "";
    public Reception()
    {
        System.Console.WriteLine("Will you RSVP? Please enter \"Yes\" or \"No\": ");
        if(Console.ReadLine() == "Yes")
        {
            setRSVP(true);
            System.Console.WriteLine("What will you email say?");
        }
    }
    public bool getRSVP()
    {
        return _RSVP;
    }
    public void setRSVP(bool RSVP)
    {
        _RSVP = RSVP;
    }
    public string getEmail()
    {
        return _email;
    }
    public void setEmail(string email)
    {
        _email = email;
    }
    public override void FullDetails()
    {
        System.Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.getFullAddress()}\n{_email}");
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