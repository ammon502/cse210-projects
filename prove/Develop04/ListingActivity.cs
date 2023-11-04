using System;

class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
        {
            "Filler"
        };
    public ListingActivity(int duration) : base("Listing Activity", 
                                      "\nList as many responses as you can to the following prompt:",
                                      "Welcome to the Listing Activity!",
                                      $"Well Done!\n\nYou have completed another {duration} seconds of the Listing Activity",
                                      "How long in seconds, would you like for your session? ",
                                      duration)
    {
        
    }
    
    public void Listing()
    {

    }
}