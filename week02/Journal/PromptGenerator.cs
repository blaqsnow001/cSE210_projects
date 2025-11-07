using System;
using System.Collections.Generic;
namespace JournalProgram
{
    public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What is something you learned today?",
            "Who did you talk to today?",
            "What made you smile today?",
            "What is one thing you are grateful for?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

}
