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
    

    protected virtual string getName()
    {
        return _goalName;
    }
    protected virtual string getDescription()
    {
        return _goalDescription;
    }
    
    protected virtual int getTotalPoints()
    {
        return _totalGoalPoints;
    }
    
    protected virtual int getCurrentPoints()
    {
        return _currentGoalPoints;
    }
    
    protected virtual bool getIsComplete()
    {
        return _isComplete;
    }
    protected virtual void setIsComplete(bool x)
    {
        _isComplete = x;
    }

} 