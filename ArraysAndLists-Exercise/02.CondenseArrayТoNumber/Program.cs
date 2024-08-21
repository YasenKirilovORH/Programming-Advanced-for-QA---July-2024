namespace _02.CondenseArrayТoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            while (numbers.Length > 1) 
            {

                int[] condensedArray = new int [numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int sumAdjacentNumbers = numbers[i] + numbers[i + 1];
                    condensedArray[i] = sumAdjacentNumbers;
                }

                numbers = condensedArray;

            }

            Console.WriteLine(numbers[0]);
        }
    }
}
