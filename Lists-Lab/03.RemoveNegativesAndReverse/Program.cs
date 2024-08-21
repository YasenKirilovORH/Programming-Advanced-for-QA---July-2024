﻿using System.Globalization;

namespace _03.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> positiveNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }
            if (positiveNumbers.Count != 0)
            {
                positiveNumbers.Reverse();
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

