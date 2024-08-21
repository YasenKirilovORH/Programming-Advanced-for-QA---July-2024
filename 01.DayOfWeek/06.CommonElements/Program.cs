namespace _06.CommonElements
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
                int currentNumberInFirstArray = firstArray[index];
                foreach (int currentNumberInSecondArray in secondArray)
                {
                    if (currentNumberInFirstArray == currentNumberInSecondArray)
                    {
                        Console.Write(currentNumberInFirstArray + " ");
                        break;
                    }
                }
            }
        }
    }
}
