using System;

class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
        {
            "--- What Crimes have you committed in the last month? ---", "--- What were some of you happiest memories as a child? ---", "--- Is there anyhting in your life that you feel like you could change to become a better person? ---"
        };
    public ListingActivity(int duration, string desc, string welcome, string durationmessage) : base("Listing Activity",
                                      $"Well Done!\n\nYou have completed another {duration*5} seconds of the Listing Activity",
                                      duration)
    {
        _desc = desc; 
        _welcomeMessage = welcome;
        _durationMessage = durationmessage;
    }
    
    public void List(int duration)
    {
        System.Console.WriteLine("\n\nList as many responses you can to the following prompt:\n\n");
        Random random = new Random();
        System.Console.WriteLine(Prompts[random.Next(0,Prompts.Count)]);
        
        BeginIn();
        System.Console.WriteLine("\b \n");
        int inputCount = 0;
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            System.Console.Write("You have ");
            System.Console.Write(startTime.AddSeconds(duration)-DateTime.Now);
            System.Console.WriteLine(" seconds left!");
            if (inputCount == 0)
            {
                System.Console.WriteLine("First Response: ");
            }
            else
            {
                System.Console.WriteLine("Next Response: ");
            }
            Console.ReadLine();
            inputCount ++;
        }
        
        System.Console.WriteLine($"You listed {inputCount} items!\n\nWellDone!!\n");
        System.Console.WriteLine($"You have completed another {duration} seconds of the Listing Activity.");
        DisplayDelay(5);
    }
}