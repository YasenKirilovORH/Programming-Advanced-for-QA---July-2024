namespace _08.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(FindMultiplicationSign(firstNumber, secondNumber, thirdNumber));
        }

        static string FindMultiplicationSign(int number1, int number2, int number3)
        {
            string result = "";
            
            if (number1 == 0 || number2 == 0 || number3 == 0)
            {
                result = "zero";
            }
            else
            {
                int negativeCount = 0;

                if (number1 < 0)
                {
                    negativeCount++;
                }
                if (number2 < 0)
                {
                    negativeCount++;
                }
                if (number3 < 0)
                {
                    negativeCount++;
                }
                if (negativeCount % 2 == 1)
                {
                    result = "negative";
                }
                else
                {
                    result = "positive";
                }
            } 
            return result;
        }
    }
}
