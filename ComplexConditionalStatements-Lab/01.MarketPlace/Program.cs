using System.Net.Http.Headers;

namespace _01.MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();

            if (fruit == "Banana")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine($"{2.50:F2}");
                }
                else
                {
                    Console.WriteLine($"{2.70:F2}");
                }
            }
            else if (fruit == "Apple")
            {
                if(day == "Weekday")
                {
                    Console.WriteLine($"{1.30:F2}");
                }
                else
                {
                    Console.WriteLine($"{1.60:F2}");
                }
            }
            else
            {
                if (day == "Weekday")
                {
                    Console.WriteLine($"{2.20:F2}");
                }
                else
                {
                    Console.WriteLine($"{3.00:F2}");
                }
            }

        }
    }
}
