namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());

            for (int number = startRange; number <= endRange; number++)
            {
                bool isPrime = true;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
