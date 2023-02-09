using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        List<string> verses = new List<string>
        {
            "And it came to pass",
            "the house is blue",
            "the end"
        };
    }
}