using System;
using System.Collections.Concurrent;
using System.Runtime.ConstrainedExecution;

class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
        {
            "--- Think of a time when you did something really difficult. ---", "--- What worries you most about the future?. ---", "--- What are you really scared of? ---", "--- Are you holding on to something you need to let go of? ---","--- What matters most in your life? ---", "--- Are you using your time wisely? ---"
        };
    public ReflectionActivity(int duration, string desc, string welcome, string durationmessage) : base("Reflection Activity", 
                                        $"Well Done!!\n\nYou have completed another {duration*5} seconds of the Reflection Activity",
                                        duration)
    {
        _desc = desc; 
        _welcomeMessage = welcome;
        _durationMessage = durationmessage;
    }

    public void Reflect(int duration)
    {
        duration = StartActivity(duration) * 5;

        System.Console.WriteLine("Consider the Following Prompt:\n\n");
        Random random = new Random();
        System.Console.WriteLine(Prompts[random.Next(0,Prompts.Count)]);
        System.Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        System.Console.Write("Now ponder on each of the following questions as they are related to this experience.\n");
        BeginIn();

        Console.Clear();
        System.Console.WriteLine("How did you feel when it was complete? ");
        DisplayDelay(_duration);
        System.Console.WriteLine("What was you favorite this about this experience? ");
        DisplayDelay(_duration);
        System.Console.WriteLine($"\n{_endingMessage}");
        DisplayDelay(5);


        // System.Console.WriteLine($"You have completed another {duration * 5} seconds of the Breathing Activity.");
    }
    
}