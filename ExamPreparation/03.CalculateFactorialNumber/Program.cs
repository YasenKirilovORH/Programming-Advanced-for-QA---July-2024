namespace _03.CalculateFactorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int factorial = 1;

                //for (int j = number; j >= 1; j--)
                //{
                //    factorial = factorial * j;
                //}
                //Console.WriteLine(factorial);

                for (int j = 1; j <= number; j++)
                {
                    factorial = factorial * j;
                }
                Console.WriteLine(factorial);
            }
        }
    }

}

