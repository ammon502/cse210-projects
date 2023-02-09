using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        Journal journal = new Journal();
        while (runProgram)
        {
            System.Console.WriteLine("Please select one of the following choices:");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            System.Console.Write("What would you like to do?: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                journal.CreateNewEntry();
                    break;
                
                case "2":
                journal.Display();
                    break;
                

                case "3":
                System.Console.WriteLine("What is the filename?");
                string _readFileName = Console.ReadLine();
                string[] _readLines = System.IO.File.ReadAllLines(_readFileName);
                journal.LoadFile(_readLines);
                    break;
                

                case "4":
                System.Console.WriteLine("What is the filename?");
                string _writeFileName = Console.ReadLine();
                string[] _writeLines = System.IO.File.ReadAllLines(_writeFileName);
                foreach (string line in _writeLines)
                {
                    string[] parts = line.Split(" ");
                }
                    break;
                
                
                case "5":
                runProgram = false;
                    break;
                default:
                    break;
            }
            
        }
    }
}