namespace _03.SmallerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            foreach (int currentNum in array)
            {
                if (currentNum < number)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
