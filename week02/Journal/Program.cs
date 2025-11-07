using System;
using JournalProgram;
class Program
{
    static void Main()
    {
        Journal Journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, prompt, response);
        Journal.AddEntry(newEntry);

        Console.WriteLine("\nYour journal entry:");
        Journal.DisplayAll();
    }
}
