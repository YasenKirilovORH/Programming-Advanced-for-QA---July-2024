namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberCopy = number;

            bool isSpecial = true;

            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;

                if (number % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }

                numberCopy = numberCopy / 10;
            }

            if (isSpecial)
            {
                Console.WriteLine($"{number} is special");
            }
            else
            {
                Console.WriteLine($"{number} is not special");
            }
        }
    }
}
