using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }  
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        string userName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favourite number? ");
            return int.Parse(Console.ReadLine());
        }
         int userNumber = PromptUserNumber();

         static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        int square = SquareNumber(userNumber);


         static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Mr {name}, the square of your number is {square}.");
        } 
        DisplayResult(userName, square);
        }

    }
