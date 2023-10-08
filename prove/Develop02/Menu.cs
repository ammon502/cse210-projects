using System;
public class Menu
{
    bool runProgram = true;
    public Menu()
    {

    }
    public void Display(Journal journal)
    {
        
        
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
                journal.LoadFile();
                    break;
                
                case "4":
                journal.writeFile();
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