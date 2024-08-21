using System.Diagnostics.CodeAnalysis;

namespace _04.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEvenNumbers += number;
                }
                else
                {
                    sumOddNumbers += number;
                }
            }
            Console.WriteLine(sumEvenNumbers - sumOddNumbers);
        }
    }
}
