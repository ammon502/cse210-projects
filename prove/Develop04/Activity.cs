using System.Dynamic;

class Activity
{
    protected string _name = "";
    protected string _desc = "";
    protected string _welcomeMessage = "";
    protected string _endingMessage = "";
    protected string _durationMessage = "";
    protected int _duration = 0;

    protected Activity()
    {
       // nothing 
    }

    protected Activity(string name, 
             string desc, 
             string welcome, 
             string ending,
             string  durationMessage,
             int duration)
    {
        _name = name;
        _desc = desc; 
        _welcomeMessage = welcome; 
        _endingMessage = ending;
        _durationMessage = durationMessage;
        _duration = duration;
    }

    protected void Display()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine (_desc);
        System.Console.WriteLine(_welcomeMessage);
        System.Console.WriteLine(_endingMessage);
        System.Console.WriteLine(_duration); 
    }

    protected void BeginIn()
    {
        System.Console.Write("\nYou may begin in: ");
        
        int delta = 1000;
        Thread.Sleep(delta);    
        Console.Write("\b2");
        Thread.Sleep(delta);  
        Console.Write("\b1");
        Thread.Sleep(delta);
    }

    protected void DisplayDelay(int delay)
    {
        int delta = 300;
        double time = delay * 500;
        Console.Write("+");
        while (time > 0)
        {
            Console.Write("\b|");

            
            time -= delta;
            Console.Write("\b/"); // Erase the + character
            Thread.Sleep(delta);    
            // Console.Write('/'); // Replace it with the / character
            
            
            time -= delta;
            Console.Write("\b-"); // Erase the + character  
            Thread.Sleep(delta);  
            // Console.Write(""); // Replace it with the - character

            
            time -= delta;
            Console.Write("\b\u005C"); // Erase the + character
            Thread.Sleep(delta);    
            // Console.Write("\u005C"); // Replace it with the \ character

            
            time -= delta;
            // Console.Write("\b"); // Erase the + character
            Thread.Sleep(delta);  
        }
        Console.Write("\b");
    }

    public void GetReady()
    {
        System.Console.WriteLine("Get Ready...");
        DisplayDelay(5);
    }

}