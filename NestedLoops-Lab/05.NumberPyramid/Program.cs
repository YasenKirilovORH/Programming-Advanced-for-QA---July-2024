namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            int row = 1;
            while (currentNumber <= number) 
            {
                for (int col = 1; col <= row && currentNumber <= number; col++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}
