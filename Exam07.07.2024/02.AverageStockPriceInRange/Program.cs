namespace _02.AverageStockPriceInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] stockPrice = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            double sum = 0;
            int stocksCount = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                double currentStock = stockPrice[i];
                sum += currentStock;
                stocksCount++;
            }
            double averagePrice = sum / stocksCount;
            Console.WriteLine($"{averagePrice:F2}");
        }
    }
}
