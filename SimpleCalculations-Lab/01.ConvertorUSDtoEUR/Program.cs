namespace _01.ConvertorUSDtoEUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());

            double rate = 0.88;

            decimal euro = usd * (decimal) rate;

            Console.WriteLine($"{euro:F2}");
        }
    }
}
