namespace _11.CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            string extra = Console.ReadLine();

            decimal price = 0m;

            if (typeOfDrink == "coffee")
            {
                price = 1;
            } else if (typeOfDrink == "tea")
            {
                price = 0.60m;
            }
            if (extra == "sugar")
            {
                price += 0.40m;
            }
            Console.WriteLine($"Final price: ${price:F2}");
        }
    }
}
