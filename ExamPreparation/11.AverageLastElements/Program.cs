namespace _11.AverageLastElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int range = int.Parse(Console.ReadLine());
            List<int> numbersInRange = new List<int>();

            for (int i = numbers.Length - range; i < numbers.Length; i++)
            {
                numbersInRange.Add(numbers[i]);
            }

            double sum = numbersInRange.Sum();
            double result = sum / range;

            Console.WriteLine($"{result:F2}");
        }
    }
}
