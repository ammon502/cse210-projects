class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int totalPoints, bool isComplete)
    :base(name, description, totalPoints, isComplete)
    {
        
    }
    public override void Display()
    {
        System.Console.WriteLine($"{GetName()}: {GetDescription()}: You have {GetCurrentPoints()} points: You can earn up to {GetTotalPoints()} points");
    }
    public override void IsThisComplete()
    {
        if (GetIsComplete() == false)
        {
            System.Console.Write(" ");
        }
        if (GetIsComplete() == true)
        {
            System.Console.Write("\u221A");
        }
    }
}