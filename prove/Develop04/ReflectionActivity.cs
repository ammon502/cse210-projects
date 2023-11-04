using System;
using System.Collections.Concurrent;
using System.Runtime.ConstrainedExecution;

class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
        {
            "--- Think of a time when you did something really difficult. ---", "--- What worries you most about the future?. ---", "--- What are you really scared of? ---", "--- Are you holding on to something you need to let go of? ---","--- What matters most in your life? ---", "--- Am I using my time wisely? ---"
        };
    public ReflectionActivity(int duration) : base("Reflection Activity", 
                                      "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power and how you can use it in other aspects of your life.\n",
                                      "Welcome to the Reflection Activity!",
                                      $"Well Done!\n\nYou have completed another {duration} seconds of the Reflection Activity",
                                      "How long in seconds, would you like for your session? ",
                                      duration)
    {
        
    }

    public void Reflect()
    {
        System.Console.WriteLine("Get Ready...");
        DisplayDelay(5);
        System.Console.WriteLine("Conder the Following Prompt:\n\n");
        Random random = new Random();
        System.Console.WriteLine(Prompts[random.Next(0,Prompts.Count)]);
        System.Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        System.Console.Write("Now ponder on each of the following questions as the are related to this experience.\nYou mag bein in: 3");
        int delta = 1000;
        Thread.Sleep(delta);    
        Console.Write("\b2"); // Erase the + character  
        Thread.Sleep(delta);  
        Console.Write("\b1"); // Erase the + character
        Thread.Sleep(delta);
        Console.Clear();
        System.Console.Write("How did you feel whe it was complete? ");
        DisplayDelay(10);
        System.Console.Write("What was you favorite this about this experience? ");
        DisplayDelay(10);
        System.Console.WriteLine("\n\nWell Done!!");
        System.Console.WriteLine($"\n{_endingMessage}");
        DisplayDelay(5);
    }
    
}