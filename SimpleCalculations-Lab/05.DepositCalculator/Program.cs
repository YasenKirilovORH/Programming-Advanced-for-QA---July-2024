namespace _05.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            decimal annualInterest = depositAmount * ((decimal)annualInterestRate / 100);
            decimal monthlyInterest = (decimal)annualInterest / 12;

            decimal totalAmount = depositAmount + (decimal)termOfDeposit * monthlyInterest;

            Console.WriteLine($"{totalAmount:F2}");

        }
    }
}
