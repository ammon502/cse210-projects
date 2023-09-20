using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = 0;
        int sum = 0;
        double average = 0;
        int max = 0;
        int min = 0;
        int count = 0;

        do
        {
            System.Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                if (input > 0)
                {
                    if (min > input)
                    {
                        min = input;
                    }
                }
                numbers.Add(input);
            }
        } while(input != 0);
        
        foreach(var x in numbers)
        {
            sum += x;
            average += x;
            if(max < x)
            {
                max = x;
            }
            count += 1;
        }

        average = average/count;
        System.Console.WriteLine($"The sum is: {sum}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is: {max}");
        System.Console.WriteLine($"The smallest positive number is: {min}");
        numbers.Sort();
        System.Console.WriteLine($"The sorted list is: ");
        foreach(var x in numbers)
        {
            System.Console.WriteLine(x);
        }
    }
}