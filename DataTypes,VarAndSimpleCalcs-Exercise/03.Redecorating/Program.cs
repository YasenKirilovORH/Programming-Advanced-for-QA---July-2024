namespace _03.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededNylonInSqM = int.Parse(Console.ReadLine());
            int neededPaintInLiters = int.Parse(Console.ReadLine());
            int neededThinnerInLiters = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());


            double priceNylonForSqM = 1.50;
            double pricePaintForLiter = 14.50;
            double priceThinnerForLiter = 5.00;
            double priceForBag = 0.40;

            double totalPriceForNylon = (neededNylonInSqM + 2) * priceNylonForSqM;
            double totalPriceForPaint = (neededPaintInLiters + (neededPaintInLiters * 0.1)) * pricePaintForLiter;
            double totalPriceForThinner = neededThinnerInLiters * priceThinnerForLiter;

            double totalMaterialsPrice = totalPriceForNylon + totalPriceForPaint + totalPriceForThinner + priceForBag;

            double priceForWorker = (totalMaterialsPrice * 30/100) * hoursNeeded;

            double finalPrice = totalMaterialsPrice + priceForWorker;

            Console.WriteLine(finalPrice);

        }
    }
}
