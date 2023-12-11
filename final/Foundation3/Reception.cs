class Reception : Event
{
    private bool _RSVP = false;
    private string _email = "";
 
 
 
    public Reception(string title, string description, string date, string time, Address address)
    :base(title, description, date, time, address)
    {
        System.Console.Write("Will you RSVP? Please enter \"Yes\" or \"No\": ");
        if(Console.ReadLine() == "Yes")
        {
            SetRSVP(true);
            // System.Console.Write("What will your email say?");
            _email = "L is for the way you look at me. O is for...: L.O.V.E song sung by Frank Sinatra";

        }
        else
        {
            // _email = "Dear Alfalfa, I hate you stinking guts! You are the Scum Between my toes! - Darla, The Little Rascals";
        }
        
        _type = "Reception";
    }
    public bool GetRSVP()
    {
        return _RSVP;
    }
    public void SetRSVP(bool RSVP)
    {
        _RSVP = RSVP;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    public override void FullDetails()
    {
        System.Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{GetDate()}\n{GetTime()}\n{_address.GetFullAddress()}\n{GetEmail()}\n");
    }
    
    
}