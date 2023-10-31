using System;

class BreathingActivity : Activity
{
    // 


    public BreathingActivity(int duration) : base("Breath", 
                                      "desc",
                                      "welcome the B",
                                      "endding B",
                                      duration)
    {

    }

    public BreathingActivity(string name, 
        string desc, 
        string welcome, 
        string endding, 
        int duration) : base(name,
                            desc,
                            welcome,
                            endding,
                            duration * 2)
    {
    }    

    public void doit()
    {
        DisplayDelay(3);
        System.Console.WriteLine("HI");
        DisplayDelay(2);
    }
}