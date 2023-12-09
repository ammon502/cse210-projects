using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

class CheckGoal:Goal
{
    private int numberUntilBonus = 0;
    private int number_of_times_completed = 0;
    private int _bonus_points = 0;
    // int this class, total points is used as the points you get for completing it each time incrementally
    public CheckGoal(string name, string description, int _totalPoints, int _numberUntilBonus, int bonus_points, bool _isComplete)
    :base(name, description, _totalPoints, _isComplete)
    {
        numberUntilBonus = _numberUntilBonus;
        _bonus_points = bonus_points;
        _goalType = 3;
    }
    public override void Display()
    {
        System.Console.Write($"{GetName()}: {GetDescription()}: You have {GetCurrentPoints()} points: You can earn up to {GetTotalPoints()} points with your bonus. And you have");
        if (numberUntilBonus > number_of_times_completed)
        {
            System.Console.WriteLine($" not earned your bonus yet.  Completed {number_of_times_completed}/{numberUntilBonus} times");
        }
        else
        {
            System.Console.WriteLine($" earned your bonus of {_bonus_points} points.");
        }
    }

    public override int GetTotalPoints()
    {
        return (base.GetTotalPoints()*numberUntilBonus)+_bonus_points;
    }
    
    // public override int GetCurrentPoints()
    // {
    //     if (numberUntilBonus > number_of_times_completed)
    //     {
    //         return base.GetCurrentPoints();
    //     }
    //     else
    //     {
    //         return base.GetCurrentPoints() + GetBonusPoints();
    //     } 
    // }

    public int GetBonusPoints()
    {
        return _bonus_points;
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
    public override void CompleteGoal()
    {
        number_of_times_completed += 1;
        if(number_of_times_completed < numberUntilBonus)
        {
            _currentGoalPoints = GetCurrentPoints() + _totalGoalPoints;
            System.Console.Write(_currentGoalPoints);
        }
        else
        {
            _currentGoalPoints += _bonus_points += _totalGoalPoints;
            System.Console.Write(_currentGoalPoints);
        }
    }
    public override void RecordEvent()
    {
        _currentGoalPoints += _totalGoalPoints;
        number_of_times_completed +=1;
        if (number_of_times_completed == numberUntilBonus)
        {
            _currentGoalPoints += _bonus_points;
            SetIsComplete(true);
        }
        System.Console.WriteLine($"{GetGoalType()} Event Recorded\n");


    }
    
}