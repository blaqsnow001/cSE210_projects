using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Grade:");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if userInput >= 90
        {
            Console.ReadLine("A")
        }
        else if userInput >= 80
        {
            Console.ReadLine("B")
        }
        else if userInput >=70 
        {
            Console.ReadLine("C")
        }
        else if userInput >=60
        {
            Console.ReadLine("D")
        }
        else
        {
            Console.ReadLine("F")
        }
    }
}