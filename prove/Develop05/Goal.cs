abstract class Goal
{
    private bool _isComplete = false;
    private string _goalName = "";
    private string _goalDescription = "";
    private int _totalGoalPoints = 0;
    private int _currentGoalPoints = 0;

    protected Goal(string name, string description, int totalPoints, bool isComplete)
    {
        _isComplete = isComplete;
        _totalGoalPoints = totalPoints;
        _goalDescription = description;
        _goalName = name;
    }
    abstract public void Display();
    abstract public void isThisComplete();
    

    protected void getName()
    {
        System.Console.Write($"{_goalName}");
    }
    protected void getDescription()
    {
        System.Console.Write($"{_goalDescription}");
    }
    protected void getTotalPoints()
    {
        System.Console.Write($"{_totalGoalPoints}");
    }
    protected void getCurrentPoints()
    {
        System.Console.Write($"{_currentGoalPoints}");
    }
    protected bool getIsComplete()
    {
        return _isComplete;
    }
    protected void setIsComplete(bool x)
    {
        _isComplete = x;
    }

} 