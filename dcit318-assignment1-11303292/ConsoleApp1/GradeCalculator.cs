using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grade Calculator!");
        Console.Write("Enter your score (0-100):");
        string? initialScore = Console.ReadLine();

        if (int.TryParse(initialScore, out int score) && score >= 0 && score <= 100)
        {
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            Console.WriteLine($"Your grade is " + grade);
        }
        else
        {
            Console.WriteLine("Invalid score. Enter a score between 0 and 100.");
        }

    }
}

