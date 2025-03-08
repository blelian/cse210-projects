using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
            int lastDigit = percentage % 10;

            // Determining if it's an A or A-
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (percentage >= 80)
        {
            letter = "B";
            int lastDigit = percentage % 10;

            // Determine the sign for B
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (percentage >= 70)
        {
            letter = "C";
            int lastDigit = percentage % 10;

            // Determine the sign for C
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (percentage >= 60)
        {
            letter = "D";
            int lastDigit = percentage % 10;

            // Determining the sign for D
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F"; // No F+ or F-
        }

        // Printing the letter grade with sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Checking if the user passed the course
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't be discouraged! Keep trying for next time.");
        }
    }
}