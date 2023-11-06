using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        Menu menu = new Menu();
        while(run)
        {
            menu.Display();
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    BreathingActivity breathe = new BreathingActivity(0);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    run = false;
                    Console.Clear();
                    break;
                    
            }
            // List<ReflectionActivity> dis = new List<ReflectionActivity>();
            // dis.Add(new ReflectionActivity(5));
            // dis[0].DisplayDelay(5);
        }
    }
}