using System.Diagnostics.Metrics;

namespace _09.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double finalPrice = FinalPrice(product, quantity);
            Console.WriteLine($"{finalPrice:F2}");

        }
        static double FinalPrice(string product, int quantity)
        {
            double singlePrice = 0;

            if (product == "coffee")
            {
                singlePrice = 1.50;
            }
            else if (product == "water")
            {
                singlePrice = 1.00;
            }
            else if (product == "coke")
            {
                singlePrice = 1.40;
            }
            else if (product == "snacks")
            {
                singlePrice = 2.00;
            }
            double result = singlePrice * quantity;
            return result;
        }
    }
}
