using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        Menu menu = new Menu();
        while(run)
        {
            run = menu.Display(run);
            // List<ReflectionActivity> dis = new List<ReflectionActivity>();
            // dis.Add(new ReflectionActivity(5));
            // dis[0].DisplayDelay(5);
        }
    }
}