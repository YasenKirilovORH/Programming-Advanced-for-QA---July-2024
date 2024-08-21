namespace _06.ProductOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());


            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                int negativeCount = 0;

                if (firstNum < 0)
                    negativeCount++;
                if (secondNum < 0)
                    negativeCount++;
                if (thirdNum < 0)
                    negativeCount++;

                if (negativeCount % 2 == 0)

                    Console.WriteLine("positive");
                else
                    Console.WriteLine("negative");
            }
        }
    }
}
