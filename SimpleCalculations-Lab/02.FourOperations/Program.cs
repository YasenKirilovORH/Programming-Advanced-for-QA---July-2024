using System.Collections.Generic;

namespace _02.FourOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());


            Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {firstNumber + secondNumber:F2}");
            Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {firstNumber - secondNumber:F2}");
            Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {firstNumber * secondNumber:F2}");
            Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {firstNumber / secondNumber:F2}");


        }
    }
}
