class EternalGoal:Goal
{
    public EternalGoal(string _goalName, string _goalDescription, int _totalGoalPoints, bool _isComplete)
    :base(_goalName, _goalDescription, _totalGoalPoints, _isComplete)
    {
        _goalType = 2;
    }
    public override void Display()
    {
        System.Console.WriteLine($"{GetName()}: {GetDescription()}: You have {GetCurrentPoints()} points! Keep completing this activity to earn {GetTotalPoints()} points every time!");
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