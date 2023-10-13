using System;

class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    public string _location = "";
    PromptGenerator _gen = new PromptGenerator();
    

    public void getDate()
    {
        System.Console.Write("What is Today's Date? Please use the format MM/DD/YYYY (e.x. 12/09/1956): ");
        _date = Console.ReadLine();
    }
    public void getLocation()
    {
        System.Console.Write("Where are you as you are writing this?: ");
        _location = Console.ReadLine();
    }
    public void getPrompt()
    {
        _prompt = _gen.PromptGen();
        
    }
    public void getResponse()
    {
        System.Console.WriteLine(_prompt);
        System.Console.Write("> ");
        _response = Console.ReadLine();
        
    }
    public void Display()
    {

        System.Console.Write($"Date: {_date} - Location: {_location} - Prompt: {_prompt} \n{_response}\n\n");
    }
    public void loadDate(string date)
    {
        _date = date;
    }
    public void loadLocation(string location)
    {
        _location = location;
    }
    public void loadPrompt(string prompt)
    {
        _prompt = prompt;
    }
    public void loadResponse(string response)
    {
        _response = response;
    }
}