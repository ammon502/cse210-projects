using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 3.0);
        Bicycle cycling = new Bicycle("03 Nov 2022", 10, 10.0);
        Swimming swimming = new Swimming("03 Nov 2022", 20, 200);

        // System.Console.WriteLine(running.GetSummary());
        // System.Console.WriteLine(cycling.GetSummary());
        // System.Console.WriteLine(swimming.GetSummary());

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}