class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int totalPoints, bool isComplete)
    :base(name, description, totalPoints, isComplete)
    {
        
    }
    public override void Display()
    {
        System.Console.WriteLine($"{getName()}: {getDescription()}: You have {getCurrentPoints()} points: You can earn up to {getTotalPoints()} points");
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