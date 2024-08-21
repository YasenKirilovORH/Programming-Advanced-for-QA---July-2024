using System.Diagnostics;
using System.Xml.Schema;

namespace _03.Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            decimal tomatoPrice = decimal.Parse(Console.ReadLine());
            double tomatoQuantity= double.Parse(Console.ReadLine());
            decimal cucumberPrice = decimal.Parse(Console.ReadLine());
            double cucumberQuantity = double.Parse(Console.ReadLine());

            decimal totalPrice = ((decimal)tomatoQuantity * tomatoPrice) + ((decimal)cucumberQuantity * cucumberPrice);


            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
