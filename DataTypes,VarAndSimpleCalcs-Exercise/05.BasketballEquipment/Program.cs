namespace _05.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double priceForSneakers = annualFee * 0.60;
            double priceForUniform = priceForSneakers * 0.80;
            double priceForBall = priceForUniform * 0.25;
            double priceForAccessories = priceForBall * 0.20;

            double totalPrice = annualFee + priceForSneakers + priceForUniform + priceForBall + priceForAccessories;

            Console.WriteLine(totalPrice);

        }
    }
}
