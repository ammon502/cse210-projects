using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcomeMessage();
        static string PromptUserName()
        {
            System.Console.Write("Please enter a username you would like to use: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            System.Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int start)
        {
            int finish = start * start;
            return finish;
        }
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        void DisplayResult()
        {
            System.Console.WriteLine($"{name}, the square of your favorite number is {SquareNumber(favNum)}");
        }
        DisplayResult();
    }
}