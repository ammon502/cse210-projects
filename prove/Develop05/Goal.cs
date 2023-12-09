using System.Security.Cryptography;

abstract class Goal
{
    protected bool _isComplete = false;
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _totalGoalPoints = 0;
    protected int _currentGoalPoints = 0;
    protected int _goalType = 0;

    protected Goal(string name, string description, int totalPoints, bool isComplete)
    {
        _isComplete = isComplete;
        _totalGoalPoints = totalPoints;
        _goalDescription = description;
        _goalName = name;
    }
    abstract public void Display();
    abstract public void IsThisComplete();
    

    protected virtual string GetName()
    {
        return _goalName;
    }
    protected virtual string GetDescription()
    {
        return _goalDescription;
    }
    
    public virtual int GetTotalPoints()
    {
        return _totalGoalPoints;
    }
    
    public virtual int GetCurrentPoints()
    {
        return _currentGoalPoints;
    }
    
    public virtual bool GetIsComplete()
    {
        return _isComplete;
    }
    protected virtual void SetIsComplete(bool x)
    {
        _isComplete = x;
    }
    public virtual void CompleteGoal()
    {
        _currentGoalPoints += _totalGoalPoints;
    }

    public virtual void RecordEvent()
    {
        _currentGoalPoints += _totalGoalPoints;
        if (_goalType == 1)
        {
        _isComplete = true;
        }
        System.Console.WriteLine($"{GetGoalType()} Event Recorded\n");

    }

    public virtual string GetGoalType()
    {
        if (_goalType == 1)
        {
            return "Simple Goal";
        }

        if (_goalType == 2)
        {
            return "Eternal Goal";
        }

        if (_goalType == 3)
        {
            return "Checklist Goal";
        }
        return "base GetGoalType Broke";
    }
} 