namespace _02.MaxMinInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            int minNum =int.MaxValue;
            int maxNum =int.MinValue;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            int rangeSum = minNum + maxNum;
            Console.WriteLine(rangeSum);
        }
    }
}
