using System;

class PromptGenerator
{
    public PromptGenerator()
    {
        
    }
    public List<string> _prompts = new List<string>();
    public void CompilePrompts()
    {
        _prompts.Add("What scares you?"); 
        _prompts.Add("Do you have a plan? Do you need a plan? Have you had a plan fall spectacularly to pieces?"); 
        _prompts.Add("What is your take on soul mates?"); 
        _prompts.Add("Are you a worrier? Is there a particular worry that you can't shake? How do you cope with worry?"); 
        _prompts.Add("Dear Past Me . . ."); 
        _prompts.Add("Dear Future Me . . ."); 
    }
    
    public string PromptGen()
    {
        CompilePrompts();
        string _prompt = "";
        Random random = new Random();
        _prompt = _prompts[random.Next(0,5)];
        return _prompt;
    }
}