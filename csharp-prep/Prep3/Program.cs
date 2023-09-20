using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magNum = random.Next(0,100);
        System.Console.Write("What is your guess? ");
        int guess = 0;
        do
        {
            guess  = int.Parse(Console.ReadLine());
            if(guess>magNum)
            {
                System.Console.WriteLine("Lower");
                System.Console.Write("What is your guess? ");
                continue;
            }
            else if(guess<magNum)
            {
                System.Console.WriteLine("Higher");
                System.Console.Write("What is your guess? ");
                continue;
            }
            else if(guess==magNum)
            {
                System.Console.WriteLine("You guessed it!");
                break;
            }
            else
            {
                System.Console.WriteLine("I Broke!");
                break;
            }
        }
        while(guess != magNum);
        // This is the version the asks the user for the Magic Number
        //
        //
        // Console.Write("What is your Magic Number? ");
        // int magNum = int.Parse(Console.ReadLine());
        // System.Console.Write("What is your guess? ");
        // int guess = 0;
        // do
        // {
        //     guess  = int.Parse(Console.ReadLine());
        //     if(guess>magNum)
        //     {
        //         System.Console.WriteLine("Lower");
        //         System.Console.Write("What is your guess? ");
        //         continue;
        //     }
        //     else if(guess<magNum)
        //     {
        //         System.Console.WriteLine("Higher");
        //         System.Console.Write("What is your guess? ");
        //         continue;
        //     }
        //     else if(guess==magNum)
        //     {
        //         System.Console.WriteLine("You guessed it!");
        //         break;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("I Broke!");
        //         break;
        //     }
        // }
        // while(guess != magNum);
    }
}