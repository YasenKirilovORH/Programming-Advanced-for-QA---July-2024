using System.Security;

namespace _07.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> magicNumbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                bool isPrime = true;
                int sum = 0;
                while (currentNum > 0)
                {
                    int currentDigit = currentNum % 10;
                    currentNum /= 10;
                    sum += currentDigit;

                    isPrime = isPrimeNumber(currentDigit);
                    if (!isPrime)
                    {
                        break;
                    }
                }

                if (isPrime && sum % 2 == 0)
                {
                    magicNumbers.Add(i);
                }
            }
            string message = magicNumbers.Count > 0 ? string.Join(" ", magicNumbers) : "no";

            Console.WriteLine(message);
        }

        public static bool isPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
