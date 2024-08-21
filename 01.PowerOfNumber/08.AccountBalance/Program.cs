using System.Security.Principal;

namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double bankAccountBalance = 0;

            while (input != "End")
            {
                double amount = double.Parse(input);

                if (amount >= 0)
                {
                    Console.WriteLine($"Increase: {amount:F2}");
                    bankAccountBalance += amount;
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
                    bankAccountBalance += amount;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Balance: {bankAccountBalance:F2}");
            
        }
    }
}
