namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());

            double result = 0;

            if (@operator == '+')
            {
                result = numOne + numTwo;
            }
            else if (@operator == '-')
            {
                result = numOne - numTwo;
            }
            else if (@operator == '*')
            {
                result = numOne * numTwo;
            }
            else if (@operator ==  '/') 
            {
                result = numOne / numTwo;
            }
            Console.WriteLine($"{numOne} {@operator} {numTwo} = {result:F2}");
        }
    }
}
