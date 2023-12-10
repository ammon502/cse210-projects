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
                    System.Console.WriteLine("What is the filename?");
                    string _writeFileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(_writeFileName))
                    {
                        foreach (Goal goal in _goals)
                        {
                            if (goal.GetGoalType() == "Simple Goal")
                            {
                                outputFile.WriteLine($"{goal.GetGoalType()}\n{goal.GetName()}\n{goal.GetDescription()}\n{goal.GetCurrentPoints()}\n{goal.GetTotalPoints()}\n{goal.GetIsComplete()}");
                            }
                            if (goal.GetGoalType() == "Eternal Goal")
                            {
                                outputFile.WriteLine($"{goal.GetGoalType()}\n{goal.GetName()}\n{goal.GetDescription()}\n{goal.GetCurrentPoints()}\n{goal.GetTotalPoints()}\n{goal.GetIsComplete()}");
                            }
                            if (goal.GetGoalType() == "Checklist Goal")
                            {
                                outputFile.WriteLine($"{goal.GetGoalType()}\n{goal.GetName()}\n{goal.GetDescription()}\n{goal.GetCurrentPoints()}\n{goal.GetTotalPoints()}\n{goal.GetIsComplete()}\n{goal.GetBonusPoints()}\n{goal.GetNumBonus()}\n{goal.GetNumComp()}");
                            }
                            
                        }
                    }
                    break;
                
                case 4:
                    System.Console.Write("What is the filename?: ");
                    string _readFileName = Console.ReadLine();
                    string[] _readLines = System.IO.File.ReadAllLines(_readFileName);
                    for(int i = 0; i < _readLines.Length; /*increment i in each individual case*/)
                    {
                        string goalType = _readLines[i];
                        switch(goalType)
                        {
                            case "Simple Goal":

                                // outputFile.WriteLine($"{goal.GetGoalType()}\n{goal.GetName()}\n{goal.GetDescription()}\n{goal.GetCurrentPoints()}\n{goal.GetTotalPoints()}\n{goal.GetIsComplete()}")

                                string s_goalName = _readLines[i+1];
                                string s_goalDescription = _readLines[i+2];
                                int s_CurrentPoints = Convert.ToInt16(_readLines[i+3]);
                                int s_totalGoalPoints = Convert.ToInt16(_readLines[i+4]);
                                bool s_isComplete = Convert.ToBoolean(_readLines[i+5]);
                                i += 6;
                                SimpleGoal simp = new SimpleGoal(s_goalName, s_goalDescription, s_CurrentPoints, s_totalGoalPoints, s_isComplete);
                                _goals.Add(simp);
                                break;
                            
                            case "Eternal Goal":
                                string e_goalName = _readLines[i+1];
                                string e_goalDescription = _readLines[i+2];
                                int e_CurrentPoints = Convert.ToInt16(_readLines[i+3]);
                                int e_totalGoalPoints = Convert.ToInt16(_readLines[i+4]);
                                bool e_isComplete = Convert.ToBoolean(_readLines[i+5]);
                                i += 6;
                                EternalGoal eternal = new EternalGoal(e_goalName, e_goalDescription, e_CurrentPoints, e_totalGoalPoints, e_isComplete);
                                _goals.Add(eternal);
                                break;

                            case "Checklist Goal":
                                string c_goalName = _readLines[i+1];
                                string c_goalDescription = _readLines[i+2];
                                int c_CurrentPoints = Convert.ToInt16(_readLines[i+3]);
                                int c_totalGoalPoints = Convert.ToInt16(_readLines[i+4]);
                                bool c_isComplete = Convert.ToBoolean(_readLines[i+5]);
                                int c_BonusPoints = Convert.ToInt16(_readLines[i+6]);
                                int c_NumBonus = Convert.ToInt16(_readLines[i+7]);
                                int c_NumComp = Convert.ToInt16(_readLines[i+8]);
                                i += 9;
                                CheckGoal check = new CheckGoal(c_goalName, c_goalDescription, c_CurrentPoints, c_totalGoalPoints, c_isComplete, c_BonusPoints, c_NumBonus, c_NumComp);
                                _goals.Add(check);
                                break;
                        }
                    }
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