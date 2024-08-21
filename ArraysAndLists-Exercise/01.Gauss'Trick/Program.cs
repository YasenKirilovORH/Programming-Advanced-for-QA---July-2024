namespace _01.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> output = new List<int>();

            int iterations = numbers.Length / 2;

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = numbers[i] + numbers[numbers.Length - 1 - i];
                output.Add(currentNumber);
            }
            if (numbers.Length % 2 != 0)
            {
                int index = numbers.Length / 2;
                output.Add(numbers[index]);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}