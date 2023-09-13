class EternalGoal:Goal
{
    public EternalGoal(string _goalName, string _goalDescription, int _totalGoalPoints, bool _isComplete)
    :base(_goalName, _goalDescription, _totalGoalPoints, _isComplete)
    {

    }
    public override void Display()
    {
        
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