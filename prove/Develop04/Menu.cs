using System;

class Menu
{
    public bool Display(bool run)
    {
        Console.Clear();
        System.Console.Write("Menu Options:\n\t1. Start Brathing Activity\n\t2. Start Reflection Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the Menu: ");
        switch(int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.Clear();
                string bWelcomeMessage = "Welcome to the Breathing Activity!\n";
                string bDesc = "\nThis activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.\n";
                string bDurationMessage = "How long in seconds, would you like for your session? ";
                
                System.Console.Write($"{bWelcomeMessage}\n\n{bDesc}\n\n{bDurationMessage}");
                
                int bDuration = int.Parse(Console.ReadLine())/ 5;
                
                BreathingActivity breathe = new BreathingActivity(bDuration, bDesc,  bWelcomeMessage, bDurationMessage);
                
                breathe.Breathe(5);
                break;
            case 2:
                    Console.Clear();
                    string rWelcomeMessage ="Welcome to the Reflection Activity!";
                    string rDesc = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power and how you can use it in other aspects of your life.\n";
                    string rDurationMessage = "How long in seconds, would you like for your session? ";
                    
                    System.Console.Write($"{rWelcomeMessage}\n\n{rDesc}\n\n{rDurationMessage}");   

                    int rDuration = int.Parse(Console.ReadLine())/ 5;
                ReflectionActivity reflect = new ReflectionActivity(rDuration, rDesc,  rWelcomeMessage, rDurationMessage);
                reflect.Reflect(5);
                break;
            case 3:
                Console.Clear();
                string lWelcomeMessage = "Welcome to the Listing Activity!";
                string lDesc = "This activity can help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                string lDurationMessage = "How long in seconds, would you like for your session? ";
                
                System.Console.Write($"{lWelcomeMessage}\n\n{lDesc}\n\n{lDurationMessage}");   

                int lDuration = int.Parse(Console.ReadLine())/ 5;
                ListingActivity list = new ListingActivity(lDuration, lWelcomeMessage, lDesc, lDurationMessage);
                list.List(5);
                break;
            case 4:
                run = false;
                Console.Clear();
                break;
        }
        return run;
    }
}