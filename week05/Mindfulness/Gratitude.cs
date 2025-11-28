// ============================================================
// File: GratitudeActivity.cs
// CREATIVITY ADDITION: A fourth activity type
// This activity helps users practice gratitude by writing 
// detailed appreciation messages for people or things.
// It combines elements of reflection and listing but focuses
// specifically on gratitude and detailed expression.
// ============================================================
using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private List<string> _entries;

    public GratitudeActivity() 
        : base("Gratitude Activity", 
            "This activity will help you cultivate gratitude by reflecting deeply on things you are thankful for. Take time to write detailed entries about what you appreciate.")
    {
        _entries = new List<string>();
        _prompts = new List<string>
        {
            "What is something that made you smile today?",
            "Who is someone you're grateful to have in your life?",
            "What is a challenge you've overcome that you're thankful for?",
            "What is a simple pleasure you often take for granted?",
            "What is an opportunity you've been given that you appreciate?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nYou will be given prompts to write gratitude entries.");
        Console.WriteLine("Take your time to write meaningful responses.\n");
        Console.Write("Get ready to begin in: ");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n\n{GetRandomPrompt()}");
            Console.Write("\nYour response: ");
            
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                _entries.Add(entry);
            }

            if (DateTime.Now >= endTime) break;

            Console.Write("\nReflecting on your gratitude...");
            ShowSpinner(3);
        }

        Console.WriteLine($"\n\nYou wrote {_entries.Count} gratitude entries today!");

        DisplayEndingMessage();
    }
}