namespace _05.SumFactorialEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int factorialSum = 0;
            while (number > 0)
            {

                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 0) 
                {
                    factorialSum += NumberFactorial(currentDigit);
                }
            }
            Console.WriteLine(factorialSum);

        }
        public static int NumberFactorial (int number)
        {
            int sum = 1;
            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
