namespace test
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }
            Console.WriteLine(sum);
        }
    }
}
