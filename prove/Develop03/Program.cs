using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        List<string> reference = new List<string>
        {
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "In all thy ways acknowledge him, and he shall direct thy paths."
        };
        
        Scripture scrip = new Scripture(reference);
        scrip.Display();        
        while (scrip.IsAllHidden() == false)
        {
            Console.ReadLine();
            Console.Clear();
            scrip.HideWords(rand.Next(0,5));
            scrip.Display();
        }
    }
}