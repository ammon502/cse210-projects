class SimpleGoal : Goal
{
    public SimpleGoal(string _goalName, string _goalDescription, int _totalGoalPoints, bool _isComplete)
    :base(_goalName, _goalDescription, _totalGoalPoints, _isComplete)
    {
        
    }
    public override void Display()
    {
        System.Console.WriteLine($"{_goalName}{_goalDescription}{_totalGoalPoints}");
    }
    public override void isThisComplete()
    {
        if (_isComplete == false)
        {
            System.Console.Write(" ");
        }
        if (_isComplete == true)
        {
            System.Console.Write("\u221A");
        }
    }
}