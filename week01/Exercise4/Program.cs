using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break; 
            }

            numbers.Add(input);
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];
            int? smallestPositive = null; 

            foreach (int number in numbers)
            {
                sum += number; 
                
                if (number > max)
                {
                    max = number;
                }

                if (number > 0 && (smallestPositive == null || number < smallestPositive))
                {
                    smallestPositive = number;
                }
            }

            double average = (double)sum / numbers.Count;

            numbers.Sort();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive ?? 0}"); // Display 0 if no positive number
            Console.WriteLine("The sorted list is:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}