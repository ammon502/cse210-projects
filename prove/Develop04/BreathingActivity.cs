using System;

class BreathingActivity : Activity
{

    public BreathingActivity(int duration, string desc, string welcome, string durationmessage) : base("Breathing Activity",
                                      $"Well Done!\n\nYou have completed another {duration*5} seconds of the Breathing Activity",
                                      duration)
    {
        _desc = desc; 
        _welcomeMessage = welcome;
        _durationMessage = durationmessage;
    }

    public void Breathe(int duration)
    {
        Console.Clear();
        GetWelcome();
        duration = StartActivity(duration);
        _duration = duration;
        for(int i = 0; (i*2) < duration; i++)  // the way duration is calculated, this loop shouldnt run for more than the time input or more then 10 seconds after the time input
        {
            System.Console.Write("Breathe in...5");
            Thread.Sleep(1000);
            System.Console.Write("\b4");
            Thread.Sleep(1000);
            System.Console.Write("\b3");
            Thread.Sleep(1000);
            System.Console.Write("\b2");
            Thread.Sleep(1000);
            System.Console.Write("\b1");
            Thread.Sleep(1000);
            System.Console.Write("\b \n");
            System.Console.Write("Now Breathe out...5");
            Thread.Sleep(1000);
            System.Console.Write("\b4");
            Thread.Sleep(1000);
            System.Console.Write("\b3");
            Thread.Sleep(1000);
            System.Console.Write("\b2");
            Thread.Sleep(1000);
            System.Console.Write("\b1");
            Thread.Sleep(1000);
            System.Console.Write("\b \n\n");
        }

        // System.Console.WriteLine("\nWell Done!!\n");

        // System.Console.WriteLine($"You have completed another {duration * 5} seconds of the Breathing Activity.");
        System.Console.WriteLine($"\n{_endingMessage}");

        DisplayDelay(5);
    }
}