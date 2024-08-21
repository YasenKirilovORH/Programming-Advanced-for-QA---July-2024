namespace _10.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                bool topNumber = true;

                for (int j = i + 1; j < numbers.Count; j++)
                {
                   int nextCurrentNumber = numbers[j];

                    if (currentNumber <= nextCurrentNumber)
                    {
                        topNumber = false;
                        break;
                    } 
                }
                if (topNumber)
                {
                    output.Add(currentNumber);
                }
            }

            Console.WriteLine(String.Join(" ", output));
        }
    }
}
