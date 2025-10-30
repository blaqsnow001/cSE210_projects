using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); 

        Console.WriteLine("What is your guess ?");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You Guessed it!!");
        }

        while (guess != magicNumber)
        {
         
            Console.WriteLine("What is your guess ?");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!!");
            }
        }
    }
}