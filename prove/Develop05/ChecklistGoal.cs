class CheckGoal:Goal
{
    public CheckGoal(string name, string description, int _totalPoints, int _numberUntillBonus, bool _isComplete)
    :base(name, description, _totalPoints, _isComplete)
    {

    }
    public override void Display()
    {
        
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