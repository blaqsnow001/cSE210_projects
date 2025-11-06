using System;
// This is the Journal Project

class Program
{
    static void Main()
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, prompt, response);
        theJournal.AddEntry(newEntry);

        Console.WriteLine("\nYour journal entry:");
        theJournal.DisplayALL();
    }
}
