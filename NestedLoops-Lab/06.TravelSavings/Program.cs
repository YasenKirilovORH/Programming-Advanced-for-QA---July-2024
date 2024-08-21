namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = "";

            while ((destination = Console.ReadLine()) != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double sum = 0;
                while (moneyNeeded > sum)
                {
                    double currentAmount = double.Parse(Console.ReadLine());
                    sum += currentAmount;

                    Console.WriteLine($"Collected: {sum:F2}");


                }
                Console.WriteLine($"Going to {destination}!");

            }
        }
    }
}
