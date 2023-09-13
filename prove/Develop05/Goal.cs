abstract class Goal
{
    protected bool _isComplete = false;
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _totalGoalPoints = 0;
    protected int _currentGoalPoints = 0;

    protected Goal(string name, string description, int totalPoints, bool _isComplete)
    {
        
    }
    abstract public void Display();
    abstract public void isThisComplete();
} 