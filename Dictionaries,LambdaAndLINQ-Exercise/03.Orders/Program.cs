using System.Text.RegularExpressions;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productCount = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while(input != "buy")
            {
                string[] productDetails = input.Split();
                string productType = productDetails[0];
                decimal price = decimal.Parse(productDetails[1]);
                int quantity = int.Parse(productDetails[2]);

                if(!productPrice.ContainsKey(productType) && !productCount.ContainsKey(productType))
                {
                    productPrice.Add(productType, price);
                    productCount.Add(productType, quantity);
                }
                else
                {
                    productPrice[productType] = price;
                    productCount[productType] += quantity;
                }

                input = Console.ReadLine();
            }
            foreach(KeyValuePair<string, decimal> entry in productPrice)
            {
                string productName = entry.Key;
                decimal price = entry.Value;
                int quantity = productCount[productName];
                decimal totalProductPrice = price * quantity;

                Console.WriteLine($"{productName} -> {totalProductPrice:F2}");
            }
        }
    }
}
