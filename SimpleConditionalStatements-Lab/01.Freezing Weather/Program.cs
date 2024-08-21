namespace _01.Freezing_Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatureInCelsius = int.Parse(Console.ReadLine());

            if (temperatureInCelsius <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}
