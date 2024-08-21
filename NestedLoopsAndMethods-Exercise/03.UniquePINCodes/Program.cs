namespace _03.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <= max1; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= max2; secondNumber++)
                {
                    for (int thirdNumber = 2; thirdNumber <= max3; thirdNumber++)
                    {
                        if (firstNumber % 2 == 0 && thirdNumber % 2 == 0) 
                        {
                            if (secondNumber == 2 || secondNumber == 3 || secondNumber == 5 || secondNumber == 7)
                            {
                                Console.WriteLine($"{firstNumber}{secondNumber}{thirdNumber}");
                            }
                        }
                    }
                }
            }
        }
    }
}
