using System.Collections.Generic;

namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string line = "";

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(" ");

                string operation = tokens[0];

                if (operation == "Delete")
                {
                    DeleteOperation(numbers, tokens);
                }
                else if (operation == "Insert")
                {
                    InsertOperation(numbers, tokens);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InsertOperation(List<int> numbers, string[] tokens)
        {
            int index = int.Parse(tokens[2]);
            int elementForInsertion = int.Parse(tokens[1]);
            numbers.Insert(index, elementForInsertion);
        }

        private static void DeleteOperation(List<int> numbers, string[] tokens)
        {
            int elementForRemoval = int.Parse(tokens[1]);
            while (numbers.Contains(elementForRemoval))
            numbers.Remove(elementForRemoval);
        }
    }
}
