using System;

namespace _04.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());
           

            double priceForChickenMenu = 10.35;
            double priceForFishMenu = 12.40;
            double priceForVegetarianMenu = 8.15;
            double deliveryPrice = 2.50;

            double totalMenusPrice = (chickenMenus * priceForChickenMenu) + (fishMenus * priceForFishMenu) + (vegetarianMenus * priceForVegetarianMenu);

            double desertPrice = totalMenusPrice * 0.20;

            double totalPrice = totalMenusPrice + desertPrice + deliveryPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
