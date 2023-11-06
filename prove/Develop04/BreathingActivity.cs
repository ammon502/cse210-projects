using System;

class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base("Breathing Activity", 
                                      "\nThis activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.\n",
                                      "Welcome to the Breathing Activity!",
                                      $"Well Done!\n\nYou have completed another {duration} seconds of the Breathing Activity",
                                      "How long in seconds, would you like for your session? ",
                                      duration)
    {
        
    }

    public BreathingActivity(string name, 
        string desc, 
        string welcome, 
        string ending, 
        string durationMessage,
        int duration) : base(name,
                            desc,
                            welcome,
                            ending,
                            durationMessage,
                            duration * 2)
    {
        
    }    

    public void Breathe(int duration)
    {
        Console.Clear();
        System.Console.Write($"{_welcomeMessage}\n\n{_desc}\n\n{_durationMessage}");
        duration = int.Parse(Console.ReadLine())/ 5;
        GetReady();
        for(int i = 0; i < duration; i++)
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
            System.Console.Write("\b\n\n");
        }

        System.Console.WriteLine("Well Done!!\n");

        System.Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        DisplayDelay(5);
    }
}