namespace _02.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= number; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <= number; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <= number; thirdDigit++)
                    {
                        int result = firstDigit * secondDigit * thirdDigit;

                        if (firstDigit >= 10 || secondDigit >= 10 || thirdDigit >= 10)
                        {
                            continue;
                        }

                        if (result == number)
                        {
                            Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");
                        }
                    }    
                }
            }
        }
    }
}
