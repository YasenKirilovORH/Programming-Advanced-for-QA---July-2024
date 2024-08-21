namespace _09.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

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
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestElement = numbers [numbers.Count - 1];
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(bestElement + " ");
            }
            Console.WriteLine();
        }
    }
}
