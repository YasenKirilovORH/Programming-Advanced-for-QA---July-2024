namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersToBeInputed = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numbersToBeInputed; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum); 
        }
    }
}