using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Proverbs", 3, 5, 6);
        Scripture s = new Scripture(r, "Trust in the Lord with all thine heart");

        while (!s.IsCompletelyHidden())
        {
            Console.Clear();
            Consiole.WriteLine(s.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if(input.ToLower() == "quit")
            {
                break;
            }

            s.HideWordsRandomly(2);

            Console.Clear();
            Console.WriteLine(s.GetDisplayText());
        }

    }
}