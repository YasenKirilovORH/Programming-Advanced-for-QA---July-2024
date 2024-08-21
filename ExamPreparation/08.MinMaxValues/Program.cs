namespace _08.MinMaxValues
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
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < range; i++)
            {

                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }

                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
        }
    }
}
