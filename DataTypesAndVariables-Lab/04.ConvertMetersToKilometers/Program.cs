namespace _04.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());

            double km = distanceInMeters / 1000;

            Console.WriteLine($"{km:F2}");
        }
    }
}
