class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int totalPoints, bool isComplete)
    :base(name, description, totalPoints, isComplete)
    {
        
    }
    public override void Display()
    {
        System.Console.WriteLine($"{getCurrentPoints}{getDescription}{getTotalPoints}");
    }
    public override void isThisComplete()
    {
        if (getIsComplete() == false)
        {
            System.Console.Write(" ");
        }
        if (getIsComplete() == true)
        {
            System.Console.Write("\u221A");
        }
    }
}