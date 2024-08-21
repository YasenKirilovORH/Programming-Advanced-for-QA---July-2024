namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int factoriel = 1;

            for (int i = 1; i <= number; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
