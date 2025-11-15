using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture with verse range
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        
        Scripture scripture = new Scripture(reference, text);
        
        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3);
        }
        
        // Display final hidden scripture
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are now hidden. Good job!");
        }
    }
}