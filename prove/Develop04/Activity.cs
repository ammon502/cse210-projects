class Activity
{
    private string _name = "";
    private string _desc = "";
    private string _welcomeMessage = "";
    private string _enddingMessage = "";
    private int _duration = 0;

    public Activity()
    {
       // nothing 
    }

    public Activity(string name, 
             string desc, 
             string welcome, 
             string endding, 
             int duration)
    {
        _name = name;
        _desc = desc; 
        _welcomeMessage = welcome; 
        _enddingMessage = endding; 
        _duration = duration;
    }

    public void Display()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine (_desc);
        System.Console.WriteLine(_welcomeMessage);
        System.Console.WriteLine(_enddingMessage);
        System.Console.WriteLine(_duration); 
    }

    public void DisplayDelay(int delay)
    {
        int delta = 10;
        double time = delay * 500;
        while (time > 0)
        {
            Console.Write("+");

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write('/'); // Replace it with the / character
            
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write("\u005C"); // Replace it with the \ character

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
        }
    }


}