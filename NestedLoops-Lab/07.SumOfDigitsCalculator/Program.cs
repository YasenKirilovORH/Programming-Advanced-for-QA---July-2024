namespace _07.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";

            
            while ((input = Console.ReadLine()) != "End")
            {
                int number = int.Parse(input);
                int sum = 0;
                while (number > 0)
                {
                    
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                Console.WriteLine($"Sum of digits = {sum}");
            }
            Console.WriteLine($"Goodbye");
        }
    }
}
