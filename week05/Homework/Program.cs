using System;

class Program
{
    static void Main(string[] args)
    {
         // Test base Assignment class
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment(
            "Roberto Rodriguez", 
            "Fractions", 
            "Section 7.3", 
            "Problems 8-19"
        );
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment(
            "Mary Waters", 
            "European History", 
            "The Causes of World War II"
        );
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
    }
