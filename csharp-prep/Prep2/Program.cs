using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your Grade?: ");
        string input = Console.ReadLine();
        
        long grade = long.Parse(input);
        
        if (grade >= 90)
        {
            System.Console.WriteLine("You have an A");
        }
        else if (grade >= 80)
        {
            System.Console.WriteLine("You have a B");
        }
        else if (grade >= 70)
        {
            System.Console.WriteLine("You have a C");
        }
        else if (grade >= 60)
        {
            System.Console.WriteLine("You have a D");
        }
        else if (grade < 60)
        {
            System.Console.WriteLine("You have an F!");
        }

        if (grade >= 60)
        {
            if (int.Parse(input[1]) >= 7)
            {
                System.Console.WriteLine("+!");
            }
            else if(int.Parse(input[1]) < 7 && int.Parse(input[1]) > 3)
            {
                System.Console.WriteLine("!");
            }
            else if (int.Parse(input[1]) <= 3)
            {
                System.Console.WriteLine("-!");
            }
        }
    }
}