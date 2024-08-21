namespace _04.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lineOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            bool foundEquals;

            do
            {
                foundEquals = false;

                for (int i = 0; i < lineOfNumbers.Count - 1; i++)
                {
                    if (lineOfNumbers[i] == lineOfNumbers[i + 1])
                    {
                        lineOfNumbers[i] += lineOfNumbers[i + 1];

                        lineOfNumbers.RemoveAt(i + 1);

                        foundEquals = true;                
                        break;                  
                    }
                }
            }
            while (foundEquals);

            
            Console.WriteLine(String.Join(" ", lineOfNumbers));
        }
    }
}
