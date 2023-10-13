using System;
using System.ComponentModel;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public string firstName = "";
    public string lastName = "";
    bool askForName = false;
    // int entryLineCount = 0;
    // int fileLineCount = 0;
    public Journal()
    {

    }
    public void CreateNewEntry()
    {
        if (askForName == false)
        {
            System.Console.Write("What is your first name?: ");
            firstName = Console.ReadLine();
            System.Console.Write("What is your last name?: ");
            lastName = Console.ReadLine();
            askForName = true;
        }
        Entry newEntry = new Entry();
        newEntry.getDate();
        newEntry.getLocation();
        newEntry.getPrompt();
        newEntry.getResponse();
        _entries.Add(newEntry);
    }
    public void LoadFile()
    {
        System.Console.WriteLine("What is the filename?");
        string _readFileName = Console.ReadLine();
        string[] _readLines = System.IO.File.ReadAllLines(_readFileName);
        string[] name = _readLines[0].Split(" ");
        askForName = true;
        firstName = name[0];
        lastName = name[1];
        // for (int i = 0; i < 2; i++)
        // {

        //     string[] loadingEntries = _readLines.Split("\n");
        //     if(askForName == false)
        //     {
        //         string firstEntry = loadingEntries[0];
        //         string[] name = firstEntry.Split(" ");
        //         firstName = name[0];
        //         lastName = name[1];
        //         askForName = true;
        //         // loadingEntries = line.Split("\n");
        //         continue;
        //     }

        // }
        for(int i = 2; i < _readLines.Length; i += 5)
        {
            Entry newEntry = new Entry();
            // string[] getter = line.Split("\n");
            newEntry.loadDate(_readLines[i]);
            newEntry.loadLocation(_readLines[i+1]);
            newEntry.loadPrompt(_readLines[i+2]);
            newEntry.loadResponse(_readLines[i+3]);
            _entries.Add(newEntry);
        }
    }
    public void writeFile()
    {

        System.Console.WriteLine("What is the filename?");
        string _writeFileName = Console.ReadLine();
        // string[] _writeLines = System.IO.File.ReadAllLines(_writeFileName);

        // foreach (string line in _writeLines)
        // {
            
        //     string[] parts = line.Split(" ");

        // }

        using (StreamWriter outputFile = new StreamWriter(_writeFileName))
        {
            outputFile.WriteLine($"{firstName} {lastName}");
            outputFile.WriteLine();
            foreach (Entry _entry in _entries)
            {
                outputFile.WriteLine($"{_entry._date}\n{_entry._location}\n{_entry._prompt}\n{_entry._response}\n");
            }
        }
    }
    public void Display()
    {
        System.Console.WriteLine($"This is {firstName} {lastName}'s journal.");
        foreach (Entry _entry in _entries)
        {    
            _entry.Display();
        }
        System.Console.WriteLine();
    }
}