using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integer numbers separated by spaces:");

        // Read the input and convert it to a list of integer numbers
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        // Find the longest sequence of equal elements
        List<int> longestSequence = FindLongestSequenceOfEqualElements(numbers);

        // Print the result
        Console.WriteLine("Longest sequence of equal elements:");
        Console.WriteLine(string.Join(" ", longestSequence));
    }

    static List<int> FindLongestSequenceOfEqualElements(List<int> numbers)
    {
        int maxLength = 0;
        int currentLength = 1;
        int bestElement = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestElement = numbers[i - 1];
                }
                currentLength = 1;
            }
        }

        // Check the last sequence
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            bestElement = numbers[numbers.Count - 1];
        }

        return Enumerable.Repeat(bestElement, maxLength).ToList();
    }
}