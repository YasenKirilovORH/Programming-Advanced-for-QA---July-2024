namespace _06.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageOfOccupiedSpace = double.Parse(Console.ReadLine());

            double totalVolumeOfAquarium = length * width * height;

            double volumeInLiter = totalVolumeOfAquarium / 1000;

            double requiredLiters = volumeInLiter * (1 - (percentageOfOccupiedSpace / 100));

            Console.WriteLine($"{requiredLiters:F2}");
        }
    }
}
