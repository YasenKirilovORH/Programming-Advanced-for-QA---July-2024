using System.Diagnostics;

namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            PrintUpperPartOfTriangle(number);
            PrintLowerPartOfTriangle(number - 1);
        }

        private static void PrintLowerPartOfTriangle(int number)
        {
            for (int row = number; row >= 1; row--)
            {
                PrintRow(row);
            }
        }

        private static void PrintUpperPartOfTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintRow(row);
            }
        } 

        private static void PrintRow(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }

    }
}
