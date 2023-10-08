using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        menu.Display(journal);
    }
}