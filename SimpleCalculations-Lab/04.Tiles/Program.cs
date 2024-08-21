using System.Drawing;

namespace _04.Tiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double bathroomWidth = double.Parse(Console.ReadLine());
            double bathroomHeight = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());

            double bathroomArea = (bathroomWidth * bathroomHeight) *1.10;
            double tileArea = tileWidth * tileHeight;

            double totalTilesNeeded = bathroomArea / tileArea;

            Console.WriteLine($"{totalTilesNeeded:F0}");
        }
    }
}
