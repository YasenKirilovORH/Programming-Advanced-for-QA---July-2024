namespace _05.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int index = 0; index < firstArray.Length; index++)
            {
                int firstArrayCurrentNumber = firstArray[index];
                int secondArrayCurrentNumber = secondArray[index];

                if (firstArrayCurrentNumber != secondArrayCurrentNumber)
                {
                    Console.WriteLine("Arrays are not identical.");
                    return;
                }
            }
            Console.WriteLine("Arrays are identical.");
        }
    }
}
