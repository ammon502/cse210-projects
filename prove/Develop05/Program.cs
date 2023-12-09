using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        bool runProgram = true;
        int totalPoints = 0;
        while (runProgram)
        {
            int count = 1;
            int points = 0;
            foreach (Goal goal in _goals)
            {
                count ++;
                points += goal.GetCurrentPoints();
            }
            System.Console.WriteLine();
            if (points != totalPoints)
            {
                totalPoints = points;
            }
            count = 1;
            System.Console.WriteLine($"You have {totalPoints} points.\n");
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("\t1. Create New Goal");
            System.Console.WriteLine("\t2. List Goals");
            System.Console.WriteLine("\t3. Save Goals");
            System.Console.WriteLine("\t4. Load Goals");
            System.Console.WriteLine("\t5. Record Event");
            System.Console.WriteLine("\t6. Quit");
            System.Console.Write("Select a Choice from the menu: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            
            switch(userInput)
            {
                case 1:
                    System.Console.WriteLine("The types of Goals are:");
                    System.Console.WriteLine("\t1. Simple Goal");
                    System.Console.WriteLine("\t2. Eternal Goal");
                    System.Console.WriteLine("\t3. Checklist Goal");
                    System.Console.Write("Which type of goal would you like to create? ");
                    int _goalType = Convert.ToInt16(Console.ReadLine());
                    System.Console.Write("What is the name of your Goal? ");
                    string _goalName = Console.ReadLine();
                    System.Console.Write("What is a short Description of this Goal? ");
                    string _goalDescription = Console.ReadLine();
                    System.Console.Write("What is the amount of points associated with this Goal? ");
                    int _totalGoalPoints = Convert.ToInt16(Console.ReadLine());
                    switch(_goalType)
                    {
                        case 1:
                            SimpleGoal simp = new SimpleGoal(_goalName, _goalDescription, _totalGoalPoints, false);
                            _goals.Add(simp);
                            break;
                        
                        case 2:
                            EternalGoal eternal = new EternalGoal(_goalName, _goalDescription, _totalGoalPoints, false);
                            _goals.Add(eternal);
                            break;

                        case 3:
                            System.Console.Write("How many times does this goal need to be accomplished for the bonus?: ");
                            int _num_times_bonus = Convert.ToInt16(Console.ReadLine());
                            System.Console.Write("How many points do you get when bonus is reached?: ");
                            int _bonus = Convert.ToInt16(Console.ReadLine());
                            CheckGoal check = new CheckGoal(_goalName, _goalDescription, _totalGoalPoints, _num_times_bonus, _bonus, false);
                            _goals.Add(check);
                            break;
                    }
                    break;

                case 2:
                    foreach (Goal goal in _goals)
                    {
                        System.Console.Write($"{count}. [");
                        goal.IsThisComplete();
                        System.Console.Write("] ");
                        goal.Display();
                        count ++;
                        points += goal.GetCurrentPoints();
                    }
                    System.Console.WriteLine();
                    if (points != totalPoints)
                    {
                        totalPoints = points;
                    }
                    break;
                
                case 3:
                    
                    break;
                
                case 4:

                    break;
                
                case 5:
                    System.Console.Write("What number Goal would you like to complete? plese enter your response a an integer based on the order the goals were entered into the List. ");
                    int goalNum = Convert.ToInt16(Console.ReadLine());
                    
                    if (!_goals[goalNum].GetIsComplete())
                    {
                        _goals[goalNum].RecordEvent();
                    }
                    else
                    {
                        System.Console.WriteLine("Goal Completed already. Event Not Recorded. \n");
                    }

                    break;
                
                case 6:
                    runProgram = false;
                    break;
            }
        }
    }
}