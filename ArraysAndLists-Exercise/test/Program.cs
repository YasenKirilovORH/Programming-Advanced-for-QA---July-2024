using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integer numbers separated by spaces:");

        // Read the input and convert it to a list of decimal numbers
        List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

        // Process the list to sum adjacent equal numbers
        SumAdjacentEqualNumbers(numbers);

        // Print the resulting list
        Console.WriteLine("Resulting list:");
        Console.WriteLine(string.Join(" ", numbers));
    }

    static void SumAdjacentEqualNumbers(List<decimal> numbers)
    {
        bool foundEqualNeighbors;

        do
        {
            foundEqualNeighbors = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    // Sum the two equal numbers
                    numbers[i] += numbers[i + 1];

                    // Remove the second number
                    numbers.RemoveAt(i + 1);

                    // Mark that we found equal neighbors
                    foundEqualNeighbors = true;

                    // Break the loop to start from the left again
                    break;
                }
            }
        } while (foundEqualNeighbors);
    }
}