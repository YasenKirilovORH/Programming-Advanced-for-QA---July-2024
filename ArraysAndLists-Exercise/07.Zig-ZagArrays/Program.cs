namespace _07.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse (Console.ReadLine());

            int[] firstArray = new int[numberOfLines];
            int[] secondArray = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] twoNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = twoNumbers[0];
                int secondNumber = twoNumbers[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }
            Console.WriteLine(String.Join (" ", firstArray));
            Console.WriteLine(String.Join (" ", secondArray));
        }
    }
}
