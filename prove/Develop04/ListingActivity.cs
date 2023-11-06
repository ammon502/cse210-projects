using System;

class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
        {
            "--- What Crimes have you committed in the last month? ---", "--- What were some of you happiest memories as a child? ---", "--- Is there anyhting in your life that you feel like you could change to become a better person? ---"
        };
    public ListingActivity(int duration) : base("Listing Activity", 
                                      "\nList as many responses as you can to the following prompt:",
                                      "Welcome to the Listing Activity!",
                                      $"Well Done!\n\nYou have completed another {duration} seconds of the Listing Activity",
                                      "How long in seconds, would you like for your session? ",
                                      duration)
    {
        
    }
    
    public void Listing(int duration)
    {
        Console.Clear();
        System.Console.Write($"{_welcomeMessage}\n\n{_desc}\n\n{_durationMessage}");
        duration = int.Parse(Console.ReadLine())/ 5; // Get ready runs for 5 seconds in theory so dividing input by 5 allows it to rung the proper length of time...in theory
        GetReady();
        System.Console.WriteLine("\n\nList as many responses you can to the following prompt:\n\n");
        Random random = new Random();
        System.Console.WriteLine(Prompts[random.Next(0,Prompts.Count)]);
        BeginIn();
        int inputCount = 0;
        int delta = 300;
        double timeDiff = duration * 500;
        DateTime startTime = DateTime.Now;
        while ((startTime-DateTime.Now) > timeDiff)
        {
            
            inputCount ++;
        }
    }
}