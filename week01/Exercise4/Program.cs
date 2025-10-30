using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input;

        Console.WriteLine("Enter numbers to the list, type 0 when finished:");

        while (true)
        {
            Console.Write("Add number: ");
            input = Console.ReadLine();

            if (input == "0")
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int largest = numbers.Max();

            int smallestNumber = numbers
                .Where(n => n > 0)
                .OrderBy(n => n)
                .FirstOrDefault();

            numbers.Sort();

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Largest number: {largest}");

            if (smallestNumber > 0)
                Console.WriteLine($"Smallest Positive Number: {smallestNumber}");
            else
                Console.WriteLine("No positive numbers were entered!!");

            Console.WriteLine("\nNumbers in Order:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
