using System;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    public string firstName = "";
    public string lastName = "";
    bool askForName = false;
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
    public void LoadFile(string[] readLines)
    {
        foreach (string line in readLines)
        {
            string[] loadingEntries = line.Split("\n");
            string firstEntry = loadingEntries[0];
            string[] name = firstEntry.Split(" ");
            firstName = name[0];
            lastName = name[1];
            askForName = true;
        }
        foreach (string line in readLines)
        {
            string[] loadingEntries = line.Split("\n\n");
            int i = 0;
            foreach (string element in loadingEntries)
            {
                Entry newEntry = new Entry();
                if (i == 0)
                {
                    i++;
                    continue;
                }
                string[] getter = element.Split("\n");
                newEntry.loadDate(getter[0]);
                newEntry.loadLocation(getter[1]);
                newEntry.loadPrompt(getter[2]);
                newEntry.loadResponse(getter[3]);
            }
        }
    }
    public void writeFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
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