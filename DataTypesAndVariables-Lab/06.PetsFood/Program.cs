namespace _06.PetsFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());

            decimal totalPriceDogFood = countDogFood * 2.50m;
            decimal totalPriceCatFood = countCatFood * 4.00m;

            decimal totalPrice = totalPriceDogFood + totalPriceCatFood;

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
