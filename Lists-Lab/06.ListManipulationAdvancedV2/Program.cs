namespace _06.ListManipulationAdvancedV2
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
                string[] tokens = line
                .Split(" ")
                .ToArray();

                string command = tokens[0];

                if (command == "Contains") // Contains {number}
                {
                    ContainsNumber(numbers, tokens);
                }
                else if (command == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }
                else if (command == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                }
                else if (command == "GetSum")
                {
                    PrintSum(numbers);
                }
                else if (command == "Filter") //Filter {condition} {number}
                {
                    FilterByCondition(numbers, tokens, command);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void FilterByCondition(List<int> numbers, string[] tokens, string command)
        {
            string condition = tokens[1]; // '<', '>', ">=", "<="
            int number = int.Parse(tokens[2]);

            if (condition == "<")
            {
                numbers.RemoveAll(x => x >= number);
            }

            if (condition == ">")
            {
                numbers.RemoveAll(x => x <= number);
            }

            if (condition == ">=")
            {
                numbers.RemoveAll(x => x < number);
            }

            if (condition == "<=")
            {
                numbers.RemoveAll(x => x > number);
            }
        }

        private static void PrintSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        private static void PrintOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    oddNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        private static void ContainsNumber(List<int> numbers, string[] tokens)
        {
            int number = int.Parse(tokens[1]);
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
