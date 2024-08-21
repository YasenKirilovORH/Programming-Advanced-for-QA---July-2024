namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(PowerOfNumber(baseNumber, power));
        }

        static int PowerOfNumber (int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                
                result = result * number;
            }
            return result;
        }
    }
}
