using System.Collections.Generic;
class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public PromptGenerator()
    {
        _prompts.Add("What did you learn today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("Who was the most interesting person you interacted with today?");
        _prompts.Add("What was the strongest emotion you felt today?");
        _prompts.Add("What was the best part of your day?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    
}