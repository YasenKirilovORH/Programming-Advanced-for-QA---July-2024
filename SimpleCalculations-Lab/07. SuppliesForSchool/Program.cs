using System.Diagnostics;

namespace _07._SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal penPackagePrice = 5.80m;
            decimal markersPackagePrice = 7.20m;
            decimal boardCleanerPricePerLiter = 1.20m;

            int totalPenPackages = int.Parse(Console.ReadLine());
            int totalMarkersPackages = int.Parse(Console.ReadLine());
            int totalLiterOfBoardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            decimal totalPriceWithoutDiscount = (totalPenPackages * penPackagePrice) + (totalMarkersPackages * markersPackagePrice) + (totalLiterOfBoardCleaner * boardCleanerPricePerLiter);

            decimal totalPriceWithDiscount = totalPriceWithoutDiscount - (totalPriceWithoutDiscount * discount / 100);

            Console.WriteLine($"{totalPriceWithDiscount:F2}");
        }
    }
}
